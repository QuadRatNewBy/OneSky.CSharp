namespace OneSkyDotNet
{
    public interface IPlatformPlainQuotation
    {
        string Show(
            string files,
            string toLocale,
            bool isIncludingNotTranslated = true,
            bool isIncludingNotApproved = true,
            bool isIncludingOutdated = true,
            string specialization = "general");
    }
}