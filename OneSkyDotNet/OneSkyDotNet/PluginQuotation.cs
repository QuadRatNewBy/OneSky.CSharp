namespace OneSkyDotNet
{
    public class PluginQuotation : IPluginQuotation
    {
        private const string PostQuotationsAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/quotations";

        private const string PostQuotationsFromLocaleBody = "from_locale";
        private const string PostQuotationsToLocalesBody = "to_locales";
        private const string PostQuotationsItemsBody = "items";
        private const string PostQuotationsSpecializationBody = "specialization";

        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PluginQuotation(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string PostQuotations(int projectId, string fromLocale, string toLocales, string items, string specialization = "general")
        {
            return
                this.oneSky.CreateRequest(PostQuotationsAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Body(PostQuotationsFromLocaleBody, fromLocale)
                    .Body(PostQuotationsToLocalesBody, toLocales)
                    .Body(PostQuotationsItemsBody, items)
                    .Body(PostQuotationsSpecializationBody, specialization)
                    .Post();
        }
    }
}