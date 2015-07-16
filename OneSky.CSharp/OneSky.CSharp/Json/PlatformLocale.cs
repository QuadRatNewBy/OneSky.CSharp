namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PlatformLocale : IPlatformLocale
    {
        private CSharp.IPlatformLocale locale;

        internal PlatformLocale(CSharp.IPlatformLocale locale)
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