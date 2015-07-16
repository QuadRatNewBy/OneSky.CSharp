namespace OneSkyDotNet.Json
{
    public interface IOrderPlugin : IOrder
    {
        decimal Amount { get; }
    }
}