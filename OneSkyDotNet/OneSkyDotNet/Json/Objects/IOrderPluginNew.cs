namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IOrderPluginNew : IOrderPlugin
    {
        IEnumerable<IOrderTaskBase> Tasks { get; }
    }
}