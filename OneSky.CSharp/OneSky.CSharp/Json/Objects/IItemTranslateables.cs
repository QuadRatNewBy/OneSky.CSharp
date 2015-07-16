namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    public interface IItemTranslateables
    {
        IDictionary<string, string> Title { get; }

        IDictionary<string, string> Content { get; }
    }
}