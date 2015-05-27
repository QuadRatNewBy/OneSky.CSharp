namespace OneSkyDotNet.Json
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    internal class AppDescription : IAppDescription
    {
        [JsonProperty("APP_NAME")]
        private string appName;

        [JsonProperty("TITLE")]
        private string title;

        [JsonProperty("AMAZON_APPSTORE_TITLE")]
        private string amazonTitle;

        [JsonProperty("DISPLAY_NAME")]
        private string displayName;

        [JsonProperty("DESCRIPTION")]
        private string description;

        [JsonProperty("APP_DESCRIPTION")]
        private string appDescription;

        [JsonProperty("SHORT_DESCRIPTION")]
        private string shortDescription;

        [JsonProperty("AMAZON_APPSTORE_SHORT_DESCRIPTION")]
        private string amazonShortDescription;        

        [JsonProperty("DETAILED_DESCRIPTION")]
        private string detailedDescription;

        [JsonProperty("AMAZON_APPSTORE_LONG_DESCRIPTION")]
        private string amazonDetailedDescription;

        [JsonProperty("APP_VERSION_DESCRIPTION")]
        private string appVersionDescription;

        [JsonProperty("RECENT_CHANGES")]
        private string recentChanges;

        [JsonProperty("AMAZON_APPSTORE_FEATURE_BULLETS")]
        private string features;

        [JsonProperty("TAGLINE")]
        private string tagline;
                
        [JsonProperty("APP_KEYWORD")]
        Dictionary<string, string> appKeywords;

        [JsonProperty("KEYWORDS")]
        Dictionary<string, string> keywords;

        [JsonProperty("AMAZON_APPSTORE_KEYWORDS")]
        Dictionary<string, string> amazonKeywords;

        [JsonProperty("APP_IAP_NAME")]
        Dictionary<string, string> iapName;

        [JsonProperty("APP_IAP_DESCRIPTION")]
        Dictionary<string, string> iapDescription;

        public string Name
        {
            get
            {
                return this.appName ?? this.title ?? this.amazonTitle ?? this.displayName;
            }
        }

        public string Description
        {
            get
            {
                return this.description ?? this.appDescription;
            }
        }

        public string ShortDescription { get { return this.shortDescription ?? this.amazonShortDescription; } }

        public string DetailedDescription { get { return this.detailedDescription ?? this.amazonDetailedDescription; } }

        public string RecentChanges { get { return this.recentChanges ?? this.appVersionDescription; } }

        public string Features { get { return this.features; } }

        public string Tagline { get { return this.tagline; } }

        public IDictionary<string, string> Keywords { get { return this.appKeywords ?? this.keywords ?? this.amazonKeywords; } }

        public IDictionary<string, string> IapName { get { return this.iapName; } }

        public IDictionary<string, string> IapDescription { get { return this.iapDescription; } }
    }
}
