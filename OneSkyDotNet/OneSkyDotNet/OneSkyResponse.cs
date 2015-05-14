namespace OneSkyDotNet
{
    using System.Text;

    internal class OneSkyResponse : IOneSkyResponse
    {
        public int StatusCode { get; internal set; }
        public string StatusDescription { get; internal set; }
        public string Content { get; internal set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}\n", this.StatusCode, this.StatusDescription) + this.Content;
        }
    }
}
