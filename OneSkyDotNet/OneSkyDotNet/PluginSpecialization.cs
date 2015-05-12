namespace OneSkyDotNet
{
    internal class PluginSpecialization : IPluginSpecialization
    {
        private const string GetSpecializationsAddress = "https://plugin.api.onesky.io/1/specializations";

        private OneSky oneSky;

        internal PluginSpecialization(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string GetSpecializations()
        {
            return this.oneSky.CreateRequest(GetSpecializationsAddress).Get();
        }
    }
}