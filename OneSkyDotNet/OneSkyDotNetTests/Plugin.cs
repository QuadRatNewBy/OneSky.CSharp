namespace OneSkyDotNetTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FluentAssertions;

    using OneSkyDotNet.Json;

    using Xunit;

    public class Plugin
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private OneSkyDotNet.Json.IPlugin plugin =
            OneSkyDotNet.Json.OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Plugin;

        private string projectLocale = "be";

        private string projectName;

        private int projectId;

        private int projectId2;

        private IDictionary<string, IItem> items;

        [Fact]
        public void GrandTest()
        {
            this.items = new Dictionary<string, IItem>();
            this.items.Add("item1", new Item { Content = this.RandomString(16), Title = this.RandomString(5) });
            this.items.Add("item2", new Item { Content = this.RandomString(16), Title = this.RandomString(5) });
            this.items.Add("item3", new Item { Content = this.RandomString(16), Title = this.RandomString(5) });
            this.items.Add("also_an_item", new Item { Content = this.RandomString(16), Title = this.RandomString(5) });
            this.items.Add("or_not", new Item { Content = this.RandomString(16), Title = this.RandomString(5) });
            this.ProjectCreate();
            this.ProjectCreateFake();
            this.ProjectList();
            this.PostQuotation();
        }

        public void ProjectCreate() 
        {
            this.projectName = RandomString(32);

            var response = this.plugin.Project.PostProject(this.projectName, locale: this.projectLocale);

            response.DataContent.Name.Should().StartWith(this.projectName);
            response.DataContent.BaseLanguage.Locale.Should().Be(this.projectLocale);

            this.projectId = response.DataContent.Id;
        }

        public void ProjectCreateFake() 
        {
            var name = RandomString(16);
            var response = this.plugin.Project.PostProject(name);

            response.DataContent.Name.Should().StartWith(name);
            response.DataContent.BaseLanguage.Locale.Should().Be("en");

            this.projectId2 = response.DataContent.Id;
        }

        public void ProjectList()
        {
            var response = this.plugin.Project.GetProjects();

            response.DataContent.Should().Contain(x => x.Id == this.projectId2)
                .And.Contain(x => x.Name.StartsWith(this.projectName));
        }

        public void PostQuotation()
        {
            var response = this.plugin.Quotation.PostQuotations(
                this.projectId,
                "en",
                new List<string> { "de", "fr" },
                this.items,
                "game");

            response.DataContent.Should()
                .NotBeEmpty()
                .And.HaveCount(2)
                .And.Contain(x => x.FromLanguage.Locale == "en")
                .And.Contain(x => x.ToLanguage.Locale == "de")
                .And.Contain(x => x.ToLanguage.Locale == "fr");
        }
    }
}
