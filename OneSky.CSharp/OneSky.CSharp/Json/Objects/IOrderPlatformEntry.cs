namespace OneSky.CSharp.Json
{
    public interface IOrderPlatformEntry : IOrder
    {
        string Status { get; }
    }
}