namespace OneSkyDotNet
{
    internal class PluginAnonymous : IPluginAnonymous
    {
        private const string SingUpAddress = "https://plugin.api.onesky.io/1/accounts/sign-up";
        private const string SingInAddress = "https://plugin.api.onesky.io/1/accounts/sign-in";

        private const string SingUpEmailBody = "email";
        private const string SingInEmailBody = "email";
        private const string SingInPasswordBody = "password";

        public string SingUp(string email)
        {
            return OneSky.CreateAnonymousRequest(SingUpAddress).Body(SingUpEmailBody, email).Post();
        }

        public string SingIn(string email, string password)
        {
            return
                OneSky.CreateAnonymousRequest(SingInAddress)
                    .Body(SingInEmailBody, email)
                    .Body(SingInPasswordBody, password)
                    .Post();
        }
    }
}