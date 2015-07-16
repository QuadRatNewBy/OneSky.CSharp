namespace OneSky.CSharp
{
    public interface IPluginAnonymous
    {
        IOneSkyResponse SingUp(string email);

        IOneSkyResponse SingIn(string email, string password);
    }
}