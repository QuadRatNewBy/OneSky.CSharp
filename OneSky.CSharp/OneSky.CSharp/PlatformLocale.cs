namespace OneSky.CSharp
{
    /// <summary>
    /// Platform API Locale endpoints object.
    /// </summary>
    internal class PlatformLocale : IPlatformLocale
    {
        /// <summary>
        /// The locale list address.
        /// </summary>
        private const string LocaleListAddress = "https://platform.api.onesky.io/1/locales";

        /// <summary>
        /// The OneSky helper.
        /// </summary>
        private readonly OneSkyHelper oneSky;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformLocale"/> class.
        /// </summary>
        /// <param name="oneSky">
        /// The OneSky helper.
        /// </param>
        internal PlatformLocale(OneSkyHelper oneSky)
        {
            this.oneSky = oneSky;
        }

        /// <summary>
        /// Lists all locales.
        /// </summary>
        /// <returns>
        /// The <see cref="IOneSkyResponse"/>.
        /// </returns>
        public IOneSkyResponse List()
        {
            return this.oneSky.CreateRequest(LocaleListAddress).Get();
        }
    }
}