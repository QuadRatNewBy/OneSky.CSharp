namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IOrderPluginDetails : IOrderPlugin
    {
        IEnumerable<IOrderTaskDetails> Tasks { get; }
    }
}