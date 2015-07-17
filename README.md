# OneSky.CSharp #
C# client for OneSkyApp API.

Initially created for personal use. Since code has grown pretty big so I've decided to bundle everything up into separate lib.

## General Info ##

### Repository Structure ###

* **OneSkyDotNet**: Main library project.
* *Will be more*

### Dependencies ###
* None (In not so far future there will probably be some NuGet package for JSON parsing)

### Installation ###
For now it's only "pull-and-compile". After release there will be NuGet package available (see **Roadmap** below).

### Help, Wiki and Examples ###
* Help (TODO)
* [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Home)
* Examples (TODO)

### Credits ###
[OneSkyApp](http://www.oneskyapp.com/) Team - Thanks for translation platform itself.  
Felix Deimel ([lemonmojo](https://github.com/lemonmojo)) - Alternative implementation ([Here on GitHub](https://github.com/lemonmojo/OneSkyAppSharp))  
Well and me - [QuadRatNewBy](https://github.com/QuadRatNewBy)
 
## Contribution ##

### Pull Requests ###
Pull requests are very welcome!
Don't forget to use separate branch for each separate pull request.

### Issues ###
If you have troubles using this lib, got ideas how to improve it or ran into any error - feel free to post new issue.

Only guideline here is to mark issue with appropriate label (i.e. `bug`, `enhancement`, `help wanted` or `question`)

## Roadmap ##

### Prerelease Phase ###
Aims to cover OneSky *Platform* and *Plugin* API to return strings as responses.  
(*JSON parsing will be done during release phase*)

1. Cover *Platform* endpoints.
2. Cover *Plugin* endpoints.

View full list on [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Roadmap#prerelease-phase).

### Release Phase (current) ###
Aims to cover OneSky *Platform* and *Plugin* APIs and parse its JSON response to C# classes.  
After release there will be NuGet package available.

1. Cover *Platform* endpoints.
2. Cover *Plugin* endpoints.
3. Unit Tests for all endpoints.
4. Code review.

View full list on [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Roadmap#release-phase).  

### Further Improvements ###
* Standard .NET or custom JSON parser (to minimize dependencies).
* XML documentation.
* Asynchronous methods.
* F# version.
* Caching, Repository and and other fancy stuff.


## License ##
[MIT](LICENSE.md) 
