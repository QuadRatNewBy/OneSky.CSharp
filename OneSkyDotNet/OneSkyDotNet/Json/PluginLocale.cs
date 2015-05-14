namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class PluginLocale : IPluginLocale
    {
        private OneSkyDotNet.IPluginLocale locale;

        internal PluginLocale(OneSkyDotNet.IPluginLocale locale)
        {
            this.locale = locale;
        }

        public IOneSkyResponse<string, IEnumerable<ILocale>> GetLocales()
        {
            var plainResponse = this.locale.GetLocales();
            var jsonResponse = JsonConvert.DeserializeAnonymousType(
                plainResponse.Content,
                new { locales = new List<Localeo>() });

            return new OneSkyResponse<string, IEnumerable<ILocale>>(
                plainResponse.StatusCode,
                plainResponse.StatusDescription,
                string.Empty,
                jsonResponse.locales);
        }
    }
}