namespace OneSkyDotNet.Json
{
    public interface IItemEntry : IItemContainer
    {
        IItem Translateables { get; }

        ILocale Language { get; }
    }
}