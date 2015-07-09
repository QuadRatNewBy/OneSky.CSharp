namespace OneSkyDotNet.Json
{
    public interface IOrderPlatformEntry : IOrder
    {
        string Status { get; }
    }
}