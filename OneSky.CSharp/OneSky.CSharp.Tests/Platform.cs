namespace OneSky.CSharp.Tests
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading;

  using FluentAssertions;

  using OneSky.CSharp.Json;

  using Xunit;

  public class Platform
  {
    private static Random random = new Random((int)DateTime.Now.Ticks); //thanks to McAden

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

    private IPlatform platform =
        OneSkyClient.CreateClient(Settings.PublicKey, Settings.PrivateKey).Platform;

    private string projectGroupLocale = "en";

    private string fileNameDe = "File.de.txt";
    private string fileNameEn = "File.en.txt";

    private string screenshotFileName = "Screenshot.png";

    private string filePathDe
    {
      get
      {
        return string.Format("Data\\{0}", this.fileNameDe);
      }
    }

    private string filePathEn
    {
      get
      {
        return string.Format("Data\\{0}", this.fileNameEn);
      }
    }

    private string screenshotPath
    {
      get
      {
        return string.Format("Data\\{0}", this.screenshotFileName);
      }
    }

    private string projectGroupName;

    private int projectGroupId;

    private int projectGroupId2;

    private int projectId;

    private string projectName;

    private int fileImportIdA;

    private int fileImportIdB;

    [Fact]
    public void GrandTest()
    {
      this.ProjectGroupCreate();
      this.ProjectGroupCreateFake();
      this.ProjectGroupList();
      this.ProjectGroupListMeta();
      this.ProjectGroupShowFresh();
      this.ProjectGroupLanguagesFresh();

      this.ProjectCreate();
      this.ProjectListFresh();
      this.ProjectUpdate();
      this.ProjectShowFresh();
      this.ProjectLanguageFresh();

      this.FileUploadBaseLanguage();
      this.FileUploadNonBaseLanguage();

      // In case import runs toooo slooooow (unfortunately happened to me couple of times)
      // Some times it's really annoying.
      // ...
      // For the love of god - it's only 7 lines!
      Thread.Sleep(TimeSpan.FromSeconds(60));

      this.ProjectLanguage();
      this.FileList();

      this.ImportTaskList();
      this.ImportTaskShow();

      this.TranslationExport();
      this.TranslationExportFail();
      this.TranslationExportMultilingualFile();
      this.TranslationExportMultilingualFileFail();
      this.TranslationStatus();

      this.QuotationShow();

      this.Screenshot();

      // Cleanup
      this.FileDelete();
      this.ProjectDelete();
      this.ProjectGroupDeleteFake();
      this.ProjectGroupDelete();
    }

    private void ProjectGroupCreate()
    {
      this.projectGroupName = this.RandomString(8);

      var response = this.platform.ProjectGroup.Create(this.projectGroupName, this.projectGroupLocale);

      response.Meta.Status.Should().Be(201, "[Documentation]").And.Be(response.StatusCode);

      response.Data.Name.Should().StartWith(this.projectGroupName, "[Created that way]");
      response.Data.BaseLanguage.Should().NotBeNull();
      response.Data.BaseLanguage.Locale.Should().Be(this.projectGroupLocale, "[Created that way]");

      this.projectGroupId = response.Data.Id;
    }

    private void ProjectGroupCreateFake()
    {
      var response = this.platform.ProjectGroup.Create(this.RandomString(4));

      response.Meta.Status.Should().Be(201, "[Documentation]").And.Be(response.StatusCode);

      response.Data.BaseLanguage.Should().NotBeNull();
      response.Data.BaseLanguage.Locale.Should().Be("en", "[As Default]");

      this.projectGroupId2 = response.Data.Id;
    }

    private void ProjectGroupList()
    {
      var perPage = 100;
      var response = this.platform.ProjectGroup.List(1, perPage);

      response.Meta.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

      response.Data.Should()
          .NotBeNullOrEmpty("We've created 2 Project Groups by now")
          .And.HaveCount(response.Meta.RecordCount)
          .And.Contain(x => x.Id == this.projectGroupId2, "we created 'fake' project group")
          .And.Contain(x => x.Name.StartsWith(this.projectGroupName));
    }

    private void ProjectGroupListMeta()
    {
      var perPage = 1;
      var response1 = this.platform.ProjectGroup.List(1, perPage);
      var response2 = this.platform.ProjectGroup.List(2, perPage);

      response1.Meta.FirstPage.Should()
          .NotBeNullOrWhiteSpace("First page always exists")
          .And.Be(response2.Meta.FirstPage);

      response2.Meta.LastPage.Should()
          .NotBeNullOrWhiteSpace("Last page always exists")
          .And.Be(response1.Meta.LastPage)
          .And.NotBe(
              response1.Meta.FirstPage,
              "We created 2 Project Groups but displaying 1 per page. There should definitrly be more that one page");

      response1.Meta.NextPage.Should().NotBeNullOrWhiteSpace();
      response2.Meta.PreviousPage.Should().NotBeNullOrWhiteSpace();
    }

    private void ProjectGroupShowFresh()
    {
      var response = this.platform.ProjectGroup.Show(this.projectGroupId);

      response.Meta.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

      response.Data.Name.Should().StartWith(this.projectGroupName);
      response.Data.EnabledLanguageCount.Should().Be(1, "Only language set during creation");
      response.Data.ProjectCount.Should().Be(0, "We have not created projects yet");
    }

    private void ProjectGroupLanguagesFresh()
    {
      var response = this.platform.ProjectGroup.Languages(this.projectGroupId);

      response.Meta.Status.Should().Be(200, "[Documentation]").And.Be(response.StatusCode);

      response.Data.Should()
          .HaveCount(response.Meta.RecordCount)
          .And.HaveCount(1, "Clean start - only one language")
          .And.Contain(x => x.Locale == this.projectGroupLocale, "We created this locale")
          .And.ContainSingle(x => x.IsBaseLanguage, "One base language");
    }

    private void ProjectCreate()
    {
      this.projectName = this.RandomString(8);

      var projectType = this.platform.ProjectType.List().Data.First(x => x.Code.EndsWith("-others"));

      var response = this.platform.Project.Create(this.projectGroupId, projectType.Code, this.projectName);

      response.StatusCode.Should().Be(201);

      response.Data.Name.Should().Be(this.projectName);
      response.Data.ProjectType.Name.Should().Be(projectType.Name);
      response.Data.ProjectType.Code.Should().Be(projectType.Code);
      response.Data.Description.Should().BeNullOrWhiteSpace("Created without description");

      this.projectId = response.Data.Id;
    }

    private void ProjectListFresh()
    {
      var response = this.platform.Project.List(this.projectGroupId);

      response.Data.Should().HaveCount(response.Meta.RecordCount)
          .And.Contain(x => x.Id == this.projectId)
          .And.Contain(x => x.Name == this.projectName);
    }

    private void ProjectUpdate()
    {
      var response = this.platform.Project.Update(this.projectId, this.projectName, "TestDesc");
      response.StatusCode.Should().Be(200);
    }

    private void ProjectShowFresh()
    {
      var response = this.platform.Project.Show(this.projectId);

      response.Data.Name.Should().Be(this.projectName);
      response.Data.Description.Should().Be("TestDesc");
      response.Data.ProjectType.Code.Should().EndWith("-others");
    }

    private void ProjectLanguageFresh()
    {
      var response = this.platform.Project.Languages(this.projectId);

      response.Data.Should()
          .HaveCount(response.Meta.RecordCount)
          .And.HaveCount(1, "Clean start - only one language")
          .And.Contain(x => x.Locale == this.projectGroupLocale, "We created this locale")
          .And.ContainSingle(x => x.IsBaseLanguage, "One base language");
    }

    private void FileUploadBaseLanguage()
    {
      var response = this.platform.File.Upload(this.projectId, this.filePathEn, "INI");
      response.Meta.Status.Should().Be(201);
      response.Data.Name.Should().Be(this.fileNameEn, "as uploaded");
      response.Data.Locale.Locale.Should().Be(this.projectGroupLocale, "as base lunguage");
      response.Data.Format.Should().Be("INI");
      this.fileImportIdA = response.Data.Import.Id;

      // Sleeping for 10 seconds. Just to be sure that file import is done.
      Thread.Sleep(TimeSpan.FromSeconds(90));
    }

    private void FileUploadNonBaseLanguage()
    {
      var response = this.platform.File.Upload(this.projectId, this.filePathDe, "INI", "de");
      response.Meta.Status.Should().Be(201);
      response.Data.Name.Should().Be(this.fileNameDe, "as uploaded");
      response.Data.Locale.Locale.Should().Be("de", "as specified");
      response.Data.Format.Should().Be("INI");
      this.fileImportIdB = response.Data.Import.Id;

      // Sleeping for 10 seconds. Just to be sure that file import is done.
      Thread.Sleep(TimeSpan.FromSeconds(90));
    }

    private void ProjectLanguage()
    {
      var response = this.platform.Project.Languages(this.projectId);

      response.Data.Should()
          .HaveCount(response.Meta.RecordCount)
          .And.HaveCount(2, "Only one non-base language added")
          .And.Contain(x => x.Locale == "de", "added one")
          .And.ContainSingle(x => x.IsBaseLanguage, "Still only one base language");
    }

    private void FileList()
    {
      // Sleeping for 10 seconds. Just to be sure that file import is done.
      Thread.Sleep(TimeSpan.FromSeconds(10));

      var response = this.platform.File.List(this.projectId);

      response.Meta.Status.Should().Be(200);
      response.Data.Should()
          .HaveCount(response.Meta.RecordCount)
          .And.Contain(x => x.Name == this.fileNameEn, "We have created one")
          .And.NotContain(
              x => x.Name == this.fileNameDe,
              "this file contains same keys, so it SHOULD be added as translation, not as new file")
          .And.Contain(x => x.LastImport != null && x.LastImport.Id == this.fileImportIdA, "As one of imported files");
    }

    private void QuotationShow()
    {
      var responseDe = this.platform.Quotation.Show(this.projectId, new List<string> { this.fileNameEn }, "de");
      var responseFr = this.platform.Quotation.Show(this.projectId, new List<string> { this.fileNameEn }, "fr");

      responseDe.Data.Files.Should().Contain(x => x.Name == this.fileNameEn);
      responseDe.Data.FromLanguage.Locale.Should().Be(this.projectGroupLocale);
      responseFr.Data.FromLanguage.Locale.Should().Be(this.projectGroupLocale);
      responseDe.Data.ToLanguage.Locale.Should().Be("de");
      responseFr.Data.ToLanguage.Locale.Should().Be("fr");
      responseFr.Data.TranslationAndReview.TotalCost.Should()
          .BeGreaterOrEqualTo(responseDe.Data.TranslationAndReview.TotalCost);
    }

    private void ImportTaskList()
    {
      var response = this.platform.ImportTask.List(this.projectId);

      response.Data.Should().Contain(x => x.Id == this.fileImportIdA);
    }

    private void ImportTaskShow()
    {
      var response = this.platform.ImportTask.Show(this.projectId, this.fileImportIdA);

      response.Data.File.Name.Should().Be(this.fileNameEn);
      response.Data.Id.Should().Be(this.fileImportIdA);
    }

    private void TranslationExport()
    {
      var response = this.platform.Translation.Export(this.projectId, this.projectGroupLocale, this.fileNameEn);
      response.Meta.Status.Should().NotBe(response.StatusCode).And.Be(0);
      response.Data.Should().NotBeNullOrEmpty();
    }

    private void TranslationExportFail()
    {
      var response = this.platform.Translation.Export(this.projectId, this.projectGroupLocale, this.fileNameEn + "z");
      response.Meta.Status.Should().Be(response.StatusCode).And.Be(400);
      response.Data.Should().BeNullOrEmpty();
    }

    private void TranslationExportMultilingualFile()
    {
      var response = this.platform.Translation.ExportMultilingualFile(this.projectId, this.fileNameEn, fileFormat: "I18NEXT_MULTILINGUAL_JSON");
      response.Meta.Status.Should().NotBe(response.StatusCode).And.Be(0);
      response.Data.Should().NotBeNullOrEmpty();
    }

    private void TranslationExportMultilingualFileFail()
    {
      var response = this.platform.Translation.ExportMultilingualFile(this.projectId, this.fileNameEn + "z", fileFormat: "I18NEXT_MULTILINGUAL_JSON");
      response.Meta.Status.Should().Be(response.StatusCode).And.Be(400);
      response.Data.Should().BeNullOrEmpty();
    }

    private void TranslationStatus()
    {
      var responseFr = this.platform.Translation.Status(this.projectId, this.fileNameEn, "fr");
      var responseEn = this.platform.Translation.Status(this.projectId, this.fileNameEn, "en");
      var responseDe = this.platform.Translation.Status(this.projectId, this.fileNameEn, "de");
      responseDe.Data.Progress.Should().StartWith("75", "because 'de' test file contains 3 of 4 strings");
      responseEn.Data.Progress.Should().StartWith("100", "because 'en' test file contains all strings");
      responseFr.Data.Progress.Should().Be("0%", "because we dont have 'fr' file uploaded or translated");
    }

    private void Screenshot()
    {
      var tags = new List<IScreenshotTag>
                           {
                               new ScreenshotTag("File_Key2", 216, 130, 561, 95, this.fileNameEn),
                               new ScreenshotTag("File_Key3", 394, 292, 209, 52),
                               new ScreenshotTag("File_Key1", 24, 8, 138, 59),
                               new ScreenshotTag("File_Key9", 43, 393, 115, 57)
                           };

      var screenshot = new Screenshot(this.screenshotPath, tags);

      var response = this.platform.Screenshot.Upload(this.projectId, new List<IScreenshot> { screenshot });

      response.StatusCode.Should().BeOneOf(201);
    }

    // Cleaning up
    private void FileDelete()
    {
      var response = this.platform.File.Delete(this.projectId, this.fileNameEn);
      response.Meta.Status.Should().Be(200);
      response.Data.Name.Should().StartWith(this.fileNameEn);
    }

    private void ProjectDelete()
    {
      var response = this.platform.Project.Delete(this.projectId);
      response.StatusCode.Should().Be(200);
    }

    private void ProjectGroupDeleteFake()
    {
      var response = this.platform.ProjectGroup.Delete(this.projectGroupId2);
      response.StatusCode.Should().Be(200);
    }

    private void ProjectGroupDelete()
    {
      var response = this.platform.ProjectGroup.Delete(this.projectGroupId);
      response.StatusCode.Should().Be(200);
    }

    private void QuickStart()
    {
      // Creating OneSky Client
      var oneskyClient = OneSky.CSharp.Json.OneSkyClient.CreateClient(
          "Your public API key",
          "Your secret API key");

      // Creating 'Project Group' and 'Project'
      var projectGroup = oneskyClient.Platform.ProjectGroup.Create("QuickStart group", "by" /*your locale*/).Data;
      var project = oneskyClient.Platform.Project.Create(projectGroup.Id, "QuickStart project").Data;

      // Uploading 2 files - for base locale and for 'en' locale
      oneskyClient.Platform.File.Upload(project.Id, "Path/To/Your/File.ext", "INI" /*or your file format*/);
      oneskyClient.Platform.File.Upload(project.Id, "Path/To/Your/File.InEn.ext", "INI", "en");

      // Downloading tranlsation for specific locale ('en') and saving it to file
      var translation = oneskyClient.Platform.Translation.Export(project.Id, "en", "File.ext").Data;
      System.IO.File.WriteAllBytes("Path/To/Save/Translation.ext", Encoding.UTF8.GetBytes(translation));
    }
  }
}