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
            var jsonResponse = JsonConvert.DeserializeAnonymousType(
                plainResponse.Content,
                new { meta = new MetaList(), data = new List<Localeo>() });

            return new OneSkyResponse<IMetaList, IEnumerable<ILocale>>(
                plainResponse.StatusCode,
                plainResponse.StatusDescription,
                jsonResponse.meta,
                jsonResponse.data);
        }
    }
}