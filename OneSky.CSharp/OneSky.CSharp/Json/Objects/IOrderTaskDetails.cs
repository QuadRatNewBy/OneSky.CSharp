namespace OneSky.CSharp.Json
{
    public interface IOrderTaskDetails : IOrderTask
    {
        int Id { get; }

        ILocale FromLanguage { get; }
    }
}