namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;    

    using Newtonsoft.Json;

    internal class PlatformLocale : IPlatformLocale
    {
        private OneSkyDotNet.IPlatformLocale locale;

        internal PlatformLocale(OneSkyDotNet.IPlatformLocale locale)
        {
            this.locale = locale;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<ILocale>> List()
        {
            var plainResponse = this.locale.List();
            var jsonResponseMeta = JsonConvert.DeserializeAnonymousType(
                plainResponse.Content,
                new { meta = new MetaList() });

            IEnumerable<ILocale> data = new List<ILocale>();

            if (jsonResponseMeta.meta.Status >= 200 && jsonResponseMeta.meta.Status < 300)
            {
                var jsonResponseData = JsonConvert.DeserializeAnonymousType(
                    plainResponse.Content,
                    new { data = new List<Localeo>() });

                data = jsonResponseData.data;
            }

            return new OneSkyResponse<IMetaList, IEnumerable<ILocale>>(
                plainResponse.StatusCode,
                plainResponse.StatusDescription,
                jsonResponseMeta.meta,
                data);
        }
    }
}