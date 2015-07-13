namespace OneSkyDotNet.Json
{
    internal class PluginOrder : IPluginOrder
    {
        private OneSkyDotNet.IPluginOrder order;

        public PluginOrder(OneSkyDotNet.IPluginOrder order)
        {
            this.order = order;
        }
    }
}