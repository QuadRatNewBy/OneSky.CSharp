namespace OneSkyDotNet
{
    public interface IPluginQuotation
    {
        IOneSkyResponse PostQuotations(int projectId, string fromLocale, string toLocales, string items, string specialization = "general");
    }
}