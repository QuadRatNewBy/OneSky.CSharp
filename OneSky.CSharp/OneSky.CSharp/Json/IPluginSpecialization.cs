namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IPluginSpecialization
    {
        IOneSkyResponse<IMeta, IEnumerable<ISpecialization>> GetSpecializations();
    }
}