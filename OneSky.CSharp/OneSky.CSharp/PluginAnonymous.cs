namespace OneSky.CSharp
{
    internal class PluginAnonymous : IPluginAnonymous
    {
        private const string SignUpAddress = "https://plugin.api.onesky.io/1/accounts/sign-up";

        private const string SignInAddress = "https://plugin.api.onesky.io/1/accounts/sign-in";

        private const string SignUpEmailBody = "email";

        private const string SignInEmailBody = "email";

        private const string SignInPasswordBody = "password";

        public IOneSkyResponse SignUp(string email)
        {
            return OneSkyHelper.CreateAnonymousRequest(SignUpAddress).Body(SignUpEmailBody, email).Post();
        }

        public IOneSkyResponse SignIn(string email, string password)
        {
            return
                OneSkyHelper.CreateAnonymousRequest(SignInAddress)
                    .Body(SignInEmailBody, email)
                    .Body(SignInPasswordBody, password)
                    .Post();
        }
    }
}