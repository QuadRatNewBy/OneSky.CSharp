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
            var meta = JsonConvert.DeserializeAnonymousType(plain, new { meta = new TMeta() }).meta;

            var data = new TData();

            if (meta.Status >= 200 && meta.Status < 300)
            {
                data = JsonConvert.DeserializeAnonymousType(plain, new { data = new TData() }).data;
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
    }
}