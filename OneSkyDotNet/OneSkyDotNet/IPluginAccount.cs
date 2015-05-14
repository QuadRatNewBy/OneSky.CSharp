namespace OneSkyDotNet
{
    public interface IPluginAccount : IPluginAnonymous
    {
        IOneSkyResponse GetCredit();
    }
}