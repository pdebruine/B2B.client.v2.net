![Build](https://snelstart-git.visualstudio.com/SnelStart.B2B.client.net/_apis/build/status/SnelStart.B2B.client.v2.net)
[![NuGet](https://img.shields.io/nuget/v/SnelStart.B2B.V2.Client.svg)](https://www.nuget.org/packages/SnelStart.B2B.V2.Client/)
[![NuGet](https://img.shields.io/nuget/dt/SnelStart.B2B.V2.Client.svg)](https://www.nuget.org/stats/packages/SnelStart.B2B.V2.Client?groupby=Version)

# B2B.client.net Version 2
SnelStart B2B API .NET client version 2.

The SnelStart B2B API .NET client is an open source client library for the SnelStart B2B API version 2. 

For documentation of the API and also for registering a new appliction see https://b2bapi-developer.snelstart.nl/

Note: This client contains most definitions of the API, but is not complete. It is intended as a community effort.

# License
See the [LICENSE](./LICENSE.md) file for license rights and limitations (MIT).

TLDR: The source code in this repository is free for use by anyone. If you have changed anything in your own copy of this source that might be beneficial to others, we would appreciate it if you would share this back to us via a pull request.

# Example
```cs
var koppelSleutel = "";
var subscriptionKey = "";
var config = new Config(subscriptionKey, koppelSleutel);
var client = new B2BClient(config);

await client.AuthorizeAsync();

var kostenplaatsen = await client.Kostenplaatsen.GetAllAsync();
````

# NuGet
This library is available at NuGet:
https://www.nuget.org/packages/SnelStart.B2B.V2.Client/
