# OneSky-DotNet #
.Net library to access OneSkyApp API.

Initially created for personal use. Since code has grown pretty big so I've decided to bundle everything up into separate lib.

## General Info ##

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
Well and me - [QuadRatNewBy](https://github.com/QuadRatNewBy).
 

## Roadmap ##

### Prerelease Phase (current)###
Aims to cover OneSky *Platform* and *Plugin* API to return strings as responses.  
(*JSON parsing will be done during release phase*)

1. Cover *Platform* endpoints
2. Cover *Plugin* endpoints

View full list on [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Roadmap#prerelease-phase).

### Release Phase ###
Aims to cover OneSky *Platform* and *Plugin* APIs and parse its JSON response to C# classes.  
After release there will be NuGet package available.

1. Cover *Platform* endpoints
2. Cover *Plugin* endpoints

View full list on [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Roadmap#release-phase).  

### Further Improvements ###
* Unit Tests for all endpoints (questionable).
* XML documentstion for public (and private?) classes/interfaces.
* Caching, Repositoryand and other fancy stuff.

## License ##
[MIT](LICENSE.md)
