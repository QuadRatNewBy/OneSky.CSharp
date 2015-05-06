namespace OneSkyDotNet
{
    public interface IPluginAnonymous
    {
        string SingUp(string email);

        string SingIn(string email, string password);
    }
}