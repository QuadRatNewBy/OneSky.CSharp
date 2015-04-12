namespace OneSkyDotNet
{
    public interface IPlatformPlainProjectGroup
    {
        string List(int page = 1, int perPage = 50);

        string Show();

        string Create(string name, string locale = "en");

        string Delete();

        string Languages();
    }
}