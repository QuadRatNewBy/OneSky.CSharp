namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginQuotation
    {
        IOneSkyResponse<IMeta, IEnumerable<IQuotationPlugin>> PostQuotations(
            int projectId,
            string fromLocale,
            IEnumerable<string> toLocales,
            IDictionary<string, IItem> items,
            string specialization = "general");
    }
}