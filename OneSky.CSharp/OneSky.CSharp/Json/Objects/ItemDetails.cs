namespace OneSky.CSharp.Json
{
    using Newtonsoft.Json;

    internal class ItemDetails : ItemContainer, IItemDetails
    {
        [JsonProperty("translateables")]
        private ItemTranslateables translateables;

        public IItemTranslateables Translateables
        {
            get
            {
                return this.translateables;
            }
        }
    }
}