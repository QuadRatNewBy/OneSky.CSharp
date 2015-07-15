namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    internal class PluginQuotation : IPluginQuotation
    {
        private OneSkyDotNet.IPluginQuotation quotation;

        public PluginQuotation(OneSkyDotNet.IPluginQuotation quotation)
        {
            this.quotation = quotation;
        }

        public IOneSkyResponse<IMeta, IEnumerable<IQuotationPlugin>> PostQuotations(
            int projectId,
            string fromLocale,
            IEnumerable<string> toLocales,
            IDictionary<string, IItem> items,
            string specialization = "general")
        {
            var plainItems = JsonConvert.SerializeObject(items.ToDictionary(x => x.Key, x => new Item(x.Value)));
            var plainToLocales = string.Join(",", toLocales);
            var plain = this.quotation.PostQuotations(projectId, fromLocale, plainToLocales, plainItems, specialization);
            var tuple = JsonHelper.PluginDeserialize(plain, new { quotations = new List<QuotationPlugin>() }, x => x.quotations);
            return new OneSkyResponse<IMeta, IEnumerable<IQuotationPlugin>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}