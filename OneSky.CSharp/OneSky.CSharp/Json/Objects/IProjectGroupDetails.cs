namespace OneSky.CSharp.Json
{
    public interface IProjectGroupDetails : IProjectGroup
    {
        int EnabledLanguageCount { get; }

        int ProjectCount { get; }
    }
}