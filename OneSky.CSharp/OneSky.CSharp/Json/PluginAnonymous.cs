namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    internal class PluginAnonymous : IPluginAnonymous
    {
        private CSharp.IPluginAnonymous anonymous;

        public PluginAnonymous(CSharp.IPluginAnonymous anonymous)
        {
            this.anonymous = anonymous;
        }

        public IOneSkyResponse<IMeta, INull> SignUp(string email)
        {
            var plain = this.anonymous.SignUp(email);
            var tuple = JsonHelper.PluginDeserialize(plain, new Null(), x => x);
            return new OneSkyResponse<IMeta, INull>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IAccount>> SignIn(string email, string password)
        {
            var plain = this.anonymous.SignIn(email, password);
            var tuple = JsonHelper.PluginDeserialize(plain, new { accounts = new List<Account>() }, x => x.accounts);
            return new OneSkyResponse<IMeta, IEnumerable<IAccount>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}