namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    internal class PluginAnonymous : IPluginAnonymous
    {
        private OneSkyDotNet.IPluginAnonymous anonymous;

        public PluginAnonymous(OneSkyDotNet.IPluginAnonymous anonymous)
        {
            this.anonymous = anonymous;
        }

        public IOneSkyResponse<IMeta, INull> SingUp(string email)
        {
            var plain = this.anonymous.SingUp(email);
            var tuple = JsonHelper.PluginDeserialize(plain, new Null(), x => x);
            return new OneSkyResponse<IMeta, INull>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }

        public IOneSkyResponse<IMeta, IEnumerable<IAccount>> SingIn(string email, string password)
        {
            var plain = this.anonymous.SingIn(email, password);
            var tuple = JsonHelper.PluginDeserialize(plain, new { accounts = new List<Account>() }, x => x.accounts);
            return new OneSkyResponse<IMeta, IEnumerable<IAccount>>(
                plain.StatusCode,
                plain.StatusDescription,
                tuple.Item1,
                tuple.Item2);
        }
    }
}