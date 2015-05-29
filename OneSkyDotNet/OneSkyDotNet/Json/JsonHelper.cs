namespace OneSkyDotNet.Json
{
    using System;

    using Newtonsoft.Json;

    internal static class JsonHelper
    {
        internal static Tuple<TMeta, TData> PlatformDeserialize<TMeta, TData>(string plain) 
            where TMeta : IMeta, new()
            where TData : new()
        {
            var data = new TData();
            var meta = new TMeta();

            try
            {
                var json = JsonConvert.DeserializeAnonymousType(plain, new { meta = new TMeta() });

                if (json != null && !ReferenceEquals(json.meta, null))
                {
                    meta = json.meta;

                    if (meta.Status >= 200 && meta.Status < 300)
                    {
                        data = JsonConvert.DeserializeAnonymousType(plain, new { data = new TData() }).data;
                    }
                }
            }
            catch (JsonReaderException)
            {
                // Silencning. Meta.Status will be 0 for user to check.
            }

            return new Tuple<TMeta, TData>(meta, data);
        }

        internal static IOneSkyResponse<TMetaInterface, TDataInterface> PlatformCompose
            <TMetaInterface, TDataInterface, TMetaObject, TDataObject>(OneSkyDotNet.IOneSkyResponse plain)
            where TMetaObject : TMetaInterface, new()
            where TDataObject : TDataInterface, new()
            where TMetaInterface : IMeta
        {
            var tuple = PlatformDeserialize<TMetaObject, TDataObject>(plain.Content);
            return new OneSkyResponse<TMetaInterface, TDataInterface>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        internal static Tuple<Meta, TData> PluginDeserialize<TData, TObject>(
            OneSkyDotNet.IOneSkyResponse plain,
            TObject container,
            Func<TObject, TData> extractor) where TData : new()
        {
            var data = new TData();
            var meta = new Meta();

            if (plain.StatusCode >= 200 && plain.StatusCode < 300)
            {
                var anon = JsonConvert.DeserializeAnonymousType(plain.Content, container);
                data = extractor(anon);
            }
            else
            {
                meta = JsonConvert.DeserializeObject<Meta>(plain.Content);
            }

            return new Tuple<Meta, TData>(meta, data);
        }

        internal static Tuple<Meta, TData> PluginDeserialize<TData>(
            OneSkyDotNet.IOneSkyResponse plain) where TData : new()
        {
            var data = new TData();
            var meta = new Meta();

            if (plain.StatusCode >= 200 && plain.StatusCode < 300)
            {
                data = JsonConvert.DeserializeObject<TData>(plain.Content);
            }
            else
            {
                meta = JsonConvert.DeserializeObject<Meta>(plain.Content);
            }

            return new Tuple<Meta, TData>(meta, data);
        }
    }
}