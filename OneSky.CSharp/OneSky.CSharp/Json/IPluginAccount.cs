namespace OneSkyDotNet.Json
{
    public interface IPluginAccount : IPluginAnonymous
    {
        IOneSkyResponse<IMeta, IAccountCredit> GetCredit();
    }
}