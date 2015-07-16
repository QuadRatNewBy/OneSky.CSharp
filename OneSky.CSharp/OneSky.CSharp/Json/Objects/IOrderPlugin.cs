namespace OneSky.CSharp.Json
{
    public interface IOrderPlugin : IOrder
    {
        decimal Amount { get; }
    }
}