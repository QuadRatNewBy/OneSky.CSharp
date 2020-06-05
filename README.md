# OneSky.CSharp #
C# client for OneSky API.
Branch for version 1.*

[<img src="https://img.shields.io/nuget/v/OneSky.CSharp.svg">](https://www.nuget.org/packages/OneSky.CSharp/)

## Information ##

### Installation ###
Install NuGet package:

1. Run `Install-Package OneSky.CSharp` in the _Package Manager Console_
2. Or find package in _NuGet Package Manager_

Or just _Pull & Compile_

### Dependencies ###
* **Newtonsoft.Json** [For JSON interaction]

### Quick Start ###
```csharp
// Creating OneSky Client
var oneskyClient = OneSky.CSharp.Json.OneSkyClient.CreateClient(
    "Your public API key",
    "Your secret API key");

// Creating 'Project Group' and 'Project'
var projectGroup = oneskyClient.Platform.ProjectGroup
    .Create("QuickStart group", "by" /*your locale*/).Data;
var project = oneskyClient.Platform.Project
    .Create(projectGroup.Id, "QuickStart project").Data;

// Uploading 2 files - for base locale and for 'en' locale
oneskyClient.Platform.File
    .Upload(project.Id, "Path/To/Your/File.ext", "INI" /*or your file format*/);
oneskyClient.Platform.File
    .Upload(project.Id, "Path/To/Your/File.InEn.ext", "INI", "en");

// Downloading tranlsation for specific locale ('en') and saving it to file
var translation = oneskyClient.Platform.Translation
    .Export(project.Id, "en", "File.ext").Data;
System.IO.File.WriteAllBytes(
    "Path/To/Save/Translation.ext",
    Encoding.UTF8.GetBytes(translation));
```
To find your API keys please go to [OneSky Support](https://support.oneskyapp.com/hc/en-us/articles/206887797-How-to-find-your-API-keys-) page.

For more information go to [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Home) *(Soon)*

### Documentation ###
* [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Home) *(Soon)*
* C# XML Documentation
* Official [Platform](https://github.com/onesky/api-documentation-platform) and [Plugin](https://github.com/onesky/api-documentation-plugin) API Documentations
* [Roadmap](https://github.com/QuadRatNewBy/OneSky.CSharp/wiki/Roadmap)

### Credits ###
* [OneSkyApp](http://www.oneskyapp.com/) Team - Thanks for translation platform itself  
* Felix Deimel ([lemonmojo](https://github.com/lemonmojo)) - Alternative implementation ([Here on GitHub](https://github.com/lemonmojo/OneSkyAppSharp))
 
## Repository ##

### Repository Structure ###

* **OneSky.CSharp**: Main library project.
* **OneSky.CSharp.Tests**: Tests for main library [Depends on **xUnit** and **FluentAssertions**].

### Contribution ###
* Pull requests are very welcome! Don't forget to use separate branch for each separate pull request.
* If you have an idea, found bug or have a question - feel free to create new [Issue](https://github.com/QuadRatNewBy/OneSky.CSharp/issues) 

### Tests ###
This lib is covered by tests (partially) located in **OneSky.CSharp.Tests**. 

To run this tests in VS - build solution, open *Test Explorer* window (Alt, S, W, T), click 'Run All..'. Or use any test runner you're familiar with.

## License ##
[MIT](LICENSE.md)
