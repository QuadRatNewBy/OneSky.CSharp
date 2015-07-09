namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IPluginAnonymous
    {
        IOneSkyResponse<IMeta, INull> SingUp(string email);

        IOneSkyResponse<IMeta, IEnumerable<IAccount>> SingIn(string email, string password);
    }
}