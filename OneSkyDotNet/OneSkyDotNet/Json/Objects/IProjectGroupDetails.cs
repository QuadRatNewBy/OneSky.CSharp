namespace OneSkyDotNet.Json
{
    public interface IProjectGroupDetails : IProjectGroup
    {
        int EnabledLanguageCount { get; }

        int ProjectCount { get; }
    }
}