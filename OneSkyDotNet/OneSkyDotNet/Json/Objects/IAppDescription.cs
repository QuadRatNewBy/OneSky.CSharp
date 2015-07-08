namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    public interface IAppDescription
    {
        string Name { get; }

        string Description { get; }

        string ShortDescription { get; }

        string DetailedDescription { get; }

        string RecentChanges { get; }

        string Features { get; }

        string Tagline { get; }

        IDictionary<string, string> Keywords { get; }

        IDictionary<string, string> Tags { get; }

        IDictionary<string, string> IapName { get; }

        IDictionary<string, string> IapDescription { get; }
    }
}
