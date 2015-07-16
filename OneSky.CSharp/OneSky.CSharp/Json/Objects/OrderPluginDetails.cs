namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderPluginDetails : OrderPlugin, IOrderPluginDetails
    {
        [JsonProperty("tasks")]
        private IEnumerable<OrderTaskDetails> tasks;

        public IEnumerable<IOrderTaskDetails> Tasks
        {
            get
            {
                return this.tasks;
            }
        }
    }
}