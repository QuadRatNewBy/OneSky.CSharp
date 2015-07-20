namespace OneSky.CSharp
{
    internal class PlatformProjectType : IPlatformProjectType
    {
        private const string ProjectTypeListAddress = "https://platform.api.onesky.io/1/project-types";

        private OneSkyHelper oneSky;

        internal PlatformProjectType(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        public IOneSkyResponse List()
        {
            return this.oneSky.CreateRequest(ProjectTypeListAddress).Get();
        }
    }
}