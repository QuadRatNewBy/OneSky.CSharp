namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PluginAccount : IPluginAccount
    {
        private IPluginAnonymous anonymous;

        private CSharp.IPluginAccount account;

        public PluginAccount(CSharp.IPluginAccount account, IPluginAnonymous anonymous)
        {
            this.account = account;
            this.anonymous = anonymous;
        }

        public IOneSkyResponse<IMeta, INull> SignUp(string email)
        {
            return this.anonymous.SignUp(email);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IAccount>> SignIn(string email, string password)
        {
            return this.anonymous.SignIn(email, password);
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