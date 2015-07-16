namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPlatformOrder
    {
        IOneSkyResponse<IMetaList, IOrderPlatformEntry> List(int projectId, int page = 1, int perPage = 50, string fileName = null);

        IOneSkyResponse<IMeta, IOrderPlatformDetails> Show(int projectId, int orderId);

        IOneSkyResponse<IMeta, IOrderPlatformNew> Create(
            int projectId,
            IEnumerable<string> files,
            string toLocale,
            string orderType = "translate-only",
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string translatorType = "preferred",
            string tone = "not-specified",
            string specialization = "general",
            string note = null); 
    }
}