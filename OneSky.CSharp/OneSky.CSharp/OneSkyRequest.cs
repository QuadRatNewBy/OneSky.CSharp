namespace OneSky.CSharp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;

    /// <summary>
    /// The OneSkyRequest helper. Hides details of HTTP requests.
    /// </summary>
    internal class OneSkyRequest : IOneSkyRequest
    {
        /// <summary>
        /// Request body objects.
        /// </summary>
        private readonly IList<KeyValuePair<string, object>> body;

        /// <summary>
        /// Request files.
        /// </summary>
        private readonly IList<KeyValuePair<string, string>> files;

        /// <summary>
        /// Does request has parameters.
        /// </summary>
        private bool hasParams;

        /// <summary>
        /// Request url.
        /// </summary>
        private string url;

        /// <summary>
        /// Request content type.
        /// </summary>
        private string contentType;

        /// <summary>
        /// Initializes a new instance of the <see cref="OneSkyRequest"/> class.
        /// </summary>
        /// <param name="url">
        /// Request url.
        /// </param>
        internal OneSkyRequest(string url)
        {
            this.hasParams = false;
            this.body = new List<KeyValuePair<string, object>>();
            this.files = new List<KeyValuePair<string, string>>();

            var urlParam = url.Split(new[] { '?' });
            var param = string.Join("?", urlParam.Skip(1)).Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

            this.url = urlParam[0];

            foreach (var kvp in param.Select(s => s.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries)))
            {
                this.Parameter(kvp[0], kvp[1]);
            }
        }

        /// <summary>
        /// Replaces placeholder like <c>{placeholder}</c> in request url.
        /// </summary>
        /// <param name="placeholder">
        /// Placeholder to replace (without curly brackets).
        /// </param>
        /// <param name="value">
        /// Value to insert.
        /// </param>
        /// <param name="condition">
        /// Replacement condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        public IOneSkyRequest Placeholder(string placeholder, object value, bool condition = true)
        {
            if (condition)
            {
                this.url = this.url.Replace(string.Format("{{{0}}}", placeholder), value.ToString());
            }

            return this;
        }

        /// <summary>
        /// Appends parameter to url (like parameter=value).
        /// </summary>
        /// <param name="parameter">
        /// Parameter name.
        /// </param>
        /// <param name="value">
        /// Parameter value.
        /// </param>
        /// <param name="condition">
        /// Appending condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        public IOneSkyRequest Parameter(string parameter, object value, bool condition = true)
        {
            if (condition)
            {
                var prefix = this.hasParams ? '&' : '?';

                var ienum = value as IEnumerable;

                if (value.GetType() != typeof(string) && ienum != null)
                {
                    foreach (var c in ienum)
                    {
                        this.url += string.Format("{0}{1}[]={2}", prefix, parameter, c);
                    }
                }
                else
                {
                    this.url += string.Format("{0}{1}={2}", prefix, parameter, value);
                }

                this.hasParams = true;
            }

            return this;
        }

        /// <summary>
        /// Adds new object to request body.
        /// </summary>
        /// <param name="key">
        /// Object key.
        /// </param>
        /// <param name="value">
        /// Object value.
        /// </param>
        /// <param name="condition">
        /// Adding condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        public IOneSkyRequest Body(string key, object value, bool condition = true)
        {
            if (condition)
            {
                this.body.Add(new KeyValuePair<string, object>(key, value));
            }

            return this;
        }

        /// <summary>
        /// Adds file to request body.
        /// </summary>
        /// <param name="name">
        /// File name.
        /// </param>
        /// <param name="path">
        /// Path to file.
        /// </param>
        /// <param name="condition">
        /// Adding condition (resolved).
        /// </param>
        /// <returns>
        /// Same <see cref="IOneSkyRequest"/> instance.
        /// </returns>
        public IOneSkyRequest Files(string name, string path, bool condition = true)
        {
            if (condition)
            {
                this.files.Add(new KeyValuePair<string, string>(name, Path.GetFullPath(path)));
            }

            return this;
        }

        /// <summary>
        /// Sends <c>GET</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        public IOneSkyResponse Get()
        {
            var response = this.Send("GET");
            return response;
        }

        /// <summary>
        /// Sends <c>POST</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        public IOneSkyResponse Post()
        {
            var data = this.GenerateBody();
            var response = this.Send("POST", data);
            return response;
        }

        /// <summary>
        /// Sends <c>PUT</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        public IOneSkyResponse Put()
        {
            var data = this.GenerateBody();
            var response = this.Send("PUT", data);
            return response;
        }

        /// <summary>
        /// Sends <c>DELETE</c> request.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/> response.
        /// </returns>
        public IOneSkyResponse Delete()
        {
            var response = this.Send("DELETE");
            return response;
        }

        /// <summary>
        /// Generates request body.
        /// </summary>
        /// <returns>
        /// Bytes of request body.
        /// </returns>
        private byte[] GenerateBody()
        {
            if (this.files.Count == 0)
            {
                return this.GenerateJsonBody();
            }

            return this.GenerateFileBody();
        }

        /// <summary>
        /// Generates request body in JSON format.
        /// </summary>
        /// <returns>
        /// Bytes of request body.
        /// </returns>
        private byte[] GenerateJsonBody()
        {
            this.contentType = "application/json";
            var sb = new StringBuilder();
            sb.Append("{");
            var notFirst = false;

            foreach (var keyValuePair in this.body)
            {
                var ienum = keyValuePair.Value as IEnumerable;

                if (keyValuePair.Value.GetType() != typeof(string) && ienum != null)
                {
                    var innerFirst = true;
                    sb.Append(string.Format("{1}\"{0}\": [", keyValuePair.Key, notFirst ? "," : string.Empty));
                    foreach (var obj in ienum)
                    {
                        if (!innerFirst)
                        {
                            sb.Append(", ");
                        }

                        sb.Append(obj);
                        innerFirst = false;
                    }

                    sb.Append("]");
                }
                else if (keyValuePair.Value.ToString().StartsWith("{") && keyValuePair.Value.ToString().EndsWith("}"))
                {
                    sb.Append(
                        string.Format(
                            "{2}\"{0}\":{1}",
                            keyValuePair.Key,
                            keyValuePair.Value,
                            notFirst ? "," : string.Empty));
                }
                else
                {
                    sb.Append(
                        string.Format(
                            "{2}\"{0}\":\"{1}\"",
                            keyValuePair.Key,
                            keyValuePair.Value,
                            notFirst ? "," : string.Empty));
                }

                notFirst = true;
            }

            sb.Append("}");
            var str = sb.ToString();
            return Encoding.UTF8.GetBytes(str);
        }

        /// <summary>
        /// Generates request body in 'file' (multipart/form-data) format.
        /// </summary>
        /// <returns>
        /// Bytes of request body.
        /// </returns>
        private byte[] GenerateFileBody()
        {
            byte[] result;
            var boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            this.contentType = "multipart/form-data; boundary=" + boundary;

            using (var memoryStream = new MemoryStream())
            {
                var boundarybytes = Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                var formdataTemplate = "\r\n--" + boundary
                                       + "\r\nContent-Disposition: form-data; name=\"{0}\";\r\n\r\n{1}";
                const string FileHeaderTemplate =
                    "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\n Content-Type: application/octet-stream\r\n\r\n";

                foreach (var keyValuePair in this.body)
                {
                    var formitem = string.Format(formdataTemplate, keyValuePair.Key, keyValuePair.Value);
                    var formitembytes = Encoding.UTF8.GetBytes(formitem);
                    memoryStream.Write(formitembytes, 0, formitembytes.Length);
                }

                memoryStream.Write(boundarybytes, 0, boundarybytes.Length);

                foreach (var keyValuePair in this.files)
                {
                    var header = string.Format(FileHeaderTemplate, keyValuePair.Key, keyValuePair.Value);
                    var headerbytes = Encoding.UTF8.GetBytes(header);
                    memoryStream.Write(headerbytes, 0, headerbytes.Length);

                    using (var fileStream = new FileStream(keyValuePair.Value, FileMode.Open, FileAccess.Read))
                    {
                        var buffer = new byte[1024];
                        int bytesRead;

                        do
                        {
                            bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                            memoryStream.Write(buffer, 0, bytesRead);
                        }
                        while (bytesRead != 0);
                    }

                    memoryStream.Write(boundarybytes, 0, boundarybytes.Length);
                }

                result = new byte[memoryStream.Length];

                memoryStream.Seek(0, SeekOrigin.Begin);
                memoryStream.Read(result, 0, result.Length);
            }            

            return result;
        }

        /// <summary>
        /// Sends request with specified verb.
        /// </summary>
        /// <param name="method">
        /// HTTP verb/method.
        /// </param>
        /// <param name="data">
        /// Request data.
        /// </param>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        private IOneSkyResponse Send(string method, byte[] data = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(this.url);
            request.Accept = "Accept=application/json";
            request.ContentType = this.contentType;
            request.Method = method.ToUpper();

            if (method != "GET" && data != null)
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                }
            }

            var oneSkyResponse = new OneSkyResponse();
            var result = new StringBuilder();

            try
            {
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    using (var responseReader = new StreamReader(responseStream))
                    {
                        while (!responseReader.EndOfStream)
                        {
                            var line = responseReader.ReadLine();
                            if (line != null)
                            {
                                result.Append(line);
                                result.Append('\n');
                            }
                        }
                    }
                }

                this.GetResponseStatus(oneSkyResponse, response);
            }
            catch (WebException ex)
            {
                var stream = ex.Response.GetResponseStream();
                if (stream == null)
                {
                    throw;
                }

                using (var responseReader = new StreamReader(stream))
                {
                    while (!responseReader.EndOfStream)
                    {
                        var line = responseReader.ReadLine();
                        if (line != null)
                        {
                            result.Append(line);
                        }
                    }
                }

                this.GetResponseStatus(oneSkyResponse, ex.Response);
            }

            oneSkyResponse.Content = result.ToString();

            return oneSkyResponse;
        }

        /// <summary>
        /// Sets response status code and description of <see cref="OneSkyResponse"/> object.
        /// </summary>
        /// <param name="oneSkyResponse">
        /// The <see cref="OneSkyResponse"/> object.
        /// </param>
        /// <param name="response">
        /// Actual HTTP response.
        /// </param>
        private void GetResponseStatus(OneSkyResponse oneSkyResponse, WebResponse response)
        {
            var httpResponse = (HttpWebResponse)response;
            if (httpResponse != null)
            {
                oneSkyResponse.StatusCode = (int)httpResponse.StatusCode;
                oneSkyResponse.StatusDescription = httpResponse.StatusDescription;                
            }            
        }
    }
}