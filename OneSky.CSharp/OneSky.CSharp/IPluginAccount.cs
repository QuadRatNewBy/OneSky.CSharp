namespace OneSky.CSharp
{
    public interface IPluginAccount : IPluginAnonymous
    {
        IOneSkyResponse GetCredit();
    }
}