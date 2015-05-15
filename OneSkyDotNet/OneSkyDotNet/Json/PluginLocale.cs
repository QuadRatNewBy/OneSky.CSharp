namespace OneSkyDotNet.Json
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    internal class PluginLocale : IPluginLocale
    {
        private OneSkyDotNet.IPluginLocale locale;

        internal PluginLocale(OneSkyDotNet.IPluginLocale locale)
        {
            this.locale = locale;
        }

        public IOneSkyResponse<IMeta, IEnumerable<ILocale>> GetLocales()
        {
            var plain = this.locale.GetLocales();
            var tuple = JsonHelper.PluginDeserialize(plain, new { locales = new List<Localeo>() }, x => x.locales);
            return new OneSkyResponse<IMeta, IEnumerable<ILocale>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}