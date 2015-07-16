namespace OneSkyDotNet.Json
{
    public interface IItemDetails : IItemContainer
    {
        IItemTranslateables Translateables { get; }
    }
}