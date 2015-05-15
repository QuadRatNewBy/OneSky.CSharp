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
            var plain = this.locale.List();
            return JsonHelper.PlatformCompose<IMetaList, IEnumerable<ILocale>, MetaList, List<Localeo>>(plain);
        }
    }
}