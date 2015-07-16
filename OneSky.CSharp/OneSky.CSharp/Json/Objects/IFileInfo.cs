namespace OneSky.CSharp.Json
{
    public interface IFileInfo : IFile
    {
        string Format { get; }

        ILocale Locale { get; }
    }
}