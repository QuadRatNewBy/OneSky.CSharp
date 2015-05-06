namespace OneSkyDotNet
{
    public interface IPluginQuotation
    {
        string PostQuotations(int projectId, string fromLocale, string toLocales, string items, string specialization = null);
    }
}