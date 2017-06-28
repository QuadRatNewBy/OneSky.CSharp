namespace OneSky.CSharp
{
    internal class PluginAccount : IPluginAccount
    {
        private const string GetCreditAddress = "https://plugin.api.onesky.io/1/accounts/credit";

        private IPluginAnonymous anonymous;

        private OneSkyHelper oneSky;

        internal PluginAccount(OneSkyHelper oneSky, IPluginAnonymous anonymous)
        {
            this.anonymous = anonymous;
            this.oneSky = oneSky;
        }

        public IOneSkyResponse SignUp(string email)
        {
            return this.anonymous.SignUp(email);
        }

        public IOneSkyResponse SignIn(string email, string password)
        {
            return this.anonymous.SignIn(email, password);
        }

        public IOneSkyResponse GetCredit()
        {
            return this.oneSky.CreateRequest(GetCreditAddress).Get();
        }
    }
}