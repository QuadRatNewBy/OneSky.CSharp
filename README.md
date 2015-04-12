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
* [Wiki](/wiki/Home.md)
* Examples (TODO)

### Credits ###
[OneSkyApp](http://www.oneskyapp.com/) Team - Thanks for translation platform itself.  
Felix Deimel ([lemonmojo](https://github.com/lemonmojo)) - Alternative implementation ([Here on GitHub](https://github.com/lemonmojo/OneSkyAppSharp))  
Well and me - [QuadRatNewBy](https://github.com/QuadRatNewBy).
 

## Roadmap ##

### Prerelease Phase ###
Aims to cover OneSky *Platform* and *Plugin* API to return strings as responses.  
(*JSON parsing will be done during phase TWO*)

[[Cut to WIKI]]
 
1. Cover *Platform* **Locale** endpoint(s) [Done: 0/1]
2. Cover *Platform* **Project Group** endpoint(s) [Done: 0/5]
3. Cover *Platform* **Project Type** endpoint(s) [Done: 0/1]
4. Cover *Platform* **Project** endpoint(s) [Done: 0/6]
5. Cover *Platform* **File** endpoint(s) [Done: 0/3]
6. Cover *Platform* **Import Task** endpoint(s) [Done: 0/2]
7. Cover *Platform* **Translation** endpoint(s) [Done: 0/4]
8. Cover *Platform* **Screenshot** endpoint(s) [Done: 0/1]
9. Cover *Platform* **Quotation** endpoint(s) [Done: 0/1]
10. Cover *Platform* **Order** endpoint(s) [Done: 0/3]
11. Cover *Plugin* **Account** endpoint(s) [Done: 0/3]
12. Cover *Plugin* **Locale** endpoint(s) [Done: 0/1]
13. Cover *Plugin* **Specialization** endpoint(s) [Done: 0/1]
14. Cover *Plugin* **Project** endpoint(s) [Done: 0/2]
15. Cover *Plugin* **Item** endpoint(s) [Done: 0/3]
16. Cover *Plugin* **Order** endpoint(s) [Done: 0/5]
17. Cover *Plugin* **Quotation** endpoint(s) [Done: 0/1]

### Release Phase ###
Aims to cover OneSky *Platform* and *Plugin* APIs and parse its JSON response to C# classes.  
After release there will be NuGet package available.  

### Further Improvements ###
* Tests for all endpoints.
* XML documentstion for public (and provate) classes/interfaces.
* Caching, Repositoryand other fancy stuff.

## License ##
[MIT](LICENSE.md)
