namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PluginAccount : IPluginAccount
    {
        private IPluginAnonymous anonymous;

        private OneSkyDotNet.IPluginAccount account;

        public PluginAccount(OneSkyDotNet.IPluginAccount account, IPluginAnonymous anonymous)
        {
            this.account = account;
            this.anonymous = anonymous;
        }

        public IOneSkyResponse<IMeta, INull> SingUp(string email)
        {
            return this.anonymous.SingUp(email);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IAccount>> SingIn(string email, string password)
        {
            return this.anonymous.SingIn(email, password);
        }

        public IOneSkyResponse<IMeta, IAccountCredit> GetCredit()
        {
            var plain = this.account.GetCredit();
            var tuple = JsonHelper.PluginDeserialize(plain, new AccountCredits(), x => x);
            return new OneSkyResponse<IMeta, IAccountCredit>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}