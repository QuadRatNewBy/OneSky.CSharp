namespace OneSky.CSharp.Json
{
    public interface IProjectPlugin : IProject
    {
        string Platform { get; }

        ILocale BaseLanguage { get; }
    }
}
