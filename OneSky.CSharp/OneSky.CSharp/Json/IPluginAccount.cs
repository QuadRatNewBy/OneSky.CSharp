namespace OneSky.CSharp.Json
{
    public interface IPluginAccount : IPluginAnonymous
    {
        IOneSkyResponse<IMeta, IAccountCredit> GetCredit();
    }
}