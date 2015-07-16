namespace OneSky.CSharp.Json
{
    public interface IItemEntry : IItemContainer
    {
        IItem Translateables { get; }

        ILocale Language { get; }
    }
}