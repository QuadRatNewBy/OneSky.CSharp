#pragma warning disable 0649 //Field(s) initialized by JSON parser

namespace OneSky.CSharp.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class OrderPluginNew : OrderPlugin, IOrderPluginNew
    {
        [JsonProperty("tasks")]
        private IEnumerable<IOrderTaskBase> tasks;

        public IEnumerable<IOrderTaskBase> Tasks
        {
            get
            {
                return this.tasks;
            }
        }
    }
}