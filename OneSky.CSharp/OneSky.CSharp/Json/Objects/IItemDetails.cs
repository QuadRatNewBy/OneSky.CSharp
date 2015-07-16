namespace OneSky.CSharp.Json
{
    public interface IItemDetails : IItemContainer
    {
        IItemTranslateables Translateables { get; }
    }
}