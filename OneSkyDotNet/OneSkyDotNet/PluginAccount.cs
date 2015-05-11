namespace OneSkyDotNet
{
    public class PluginAccount : IPluginAccount
    {
        private const string GetCreditAddress = "https://plugin.api.onesky.io/1/accounts/credit";

        private IPluginAnonymous anonymous;

        private OneSky oneSky;

        internal PluginAccount(OneSky oneSky, IPluginAnonymous anonymous)
        {
            this.anonymous = anonymous;
            this.oneSky = oneSky;
        }

        public string SingUp(string email)
        {
            return this.anonymous.SingUp(email);
        }

        public string SingIn(string email, string password)
        {
            return this.anonymous.SingIn(email, password);
        }

        public string GetCredit()
        {
            return this.oneSky.CreateRequest(GetCreditAddress).Get();
        }
    }
}