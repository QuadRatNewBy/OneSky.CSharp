namespace OneSky.CSharp
{
    internal class PluginQuotation : IPluginQuotation
    {
        private const string PostQuotationsAddress = "https://plugin.api.onesky.io/1/projects/{project_id}/quotations";

        private const string PostQuotationsFromLocaleBody = "from_locale";

        private const string PostQuotationsToLocalesBody = "to_locales";

        private const string PostQuotationsItemsBody = "items";

        private const string PostQuotationsSpecializationBody = "specialization";

        private const string ProjectIdPlaceholder = "project_id";

        private OneSkyHelper oneSky;

        internal PluginQuotation(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse PostQuotations(
            int projectId,
            string fromLocale,
            string toLocales,
            string items,
            string specialization = "general")
        {
            return
                this.oneSky.CreateRequest(PostQuotationsAddress)
                    .Placeholder(ProjectIdPlaceholder, projectId)
                    .Body(PostQuotationsFromLocaleBody, fromLocale)
                    .Body(PostQuotationsToLocalesBody, toLocales)
                    .Body(PostQuotationsItemsBody, items)
                    .Body(PostQuotationsSpecializationBody, specialization)
                    .Post();
        }
    }
}