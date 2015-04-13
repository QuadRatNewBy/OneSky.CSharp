namespace OneSkyDotNet
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class OneSkyRequest
    {
        private bool hasParams;

        private string url;

        private string contentType;

        private IList<KeyValuePair<string, object>> body;

        private IList<KeyValuePair<string, string>> files;

        internal OneSkyRequest(string url)
        {
            this.hasParams = false;
            this.body = new List<KeyValuePair<string, object>>();
            this.files = new List<KeyValuePair<string, string>>();

            var urlParam = url.Split(new[] { '?' });
            var param = string.Join("?", urlParam.Skip(1)).Split(new[] { '&' });

            this.url = urlParam[0];

            foreach (var kvp in param.Select(s => s.Split(new[] { '=' })))
            {
                this.Parameter(kvp[0], kvp[1]);
            }
        }

        public OneSkyRequest Placeholder(string placeholder, object value, bool condition = true)
        {
            if (condition)
            {
                this.url = this.url.Replace(string.Format("{{{0}}}", placeholder), value.ToString());
            }
            return this;
        }

        public OneSkyRequest Parameter(string parameter, object value, bool condition = true)
        {
            if (condition)
            {
                var prefix = this.hasParams ? '&' : '?';
                this.url += string.Format("{0}{1}={2}", prefix, parameter, value);
                this.hasParams = true;
            }
            return this;
        }

        public OneSkyRequest Body(string key, object value, bool condition = true)
        {
            if (condition)
            {
                this.body.Add(new KeyValuePair<string, object>(key, value));
            }
            return this;
        }

        public OneSkyRequest Files(string name, string path, bool condition = true)
        {
            if (condition)
            {
                this.files.Add(new KeyValuePair<string, string>(name, Path.GetFullPath(path)));
            }
            return this;
        }
    }
}