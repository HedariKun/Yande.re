# Yande.re
Wrapper Around [Yande.re](https://www.yande.re) Images API 
to Get Image from [Yande.re](https:www.yande.re) follow this example

```cs
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Yande.re;

namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            YandereClient Client = new YandereClient();
            YandereTag Config = new YandereTag();
            Config.Tags.Add("Owari_no_Seraph");
            Config.Rating = YandereRating.Safe;
            List<YandereImage> Images = await Client.GetImagesAsync(Config);
            Console.WriteLine(Images[0].ImageUrl);
            Console.WriteLine(Images[0].Rating);
            await Task.Delay(-1);
        }
    }
}
```
the YandereTag Object is the Object that Handles the tags and rating 
you can set Raiting from 4 different categories 
```cs
YandereRating.Safe;
YandereRating.Questionable;
YandereRating.Explicit;
YandereRating.All;
```
the Limit Propery is to handle how many elements you get from the API and it maximize at 100 Element
you need to separate the Tag Using __UnderScores__ not **Spaces**
and to add a new Tag to the list of Tags do

```cs
YandereTag Config = new YandereTag();
Config.Tags.Add("Tage_Name");
```
To Download it from nuget [Click Here](https://www.nuget.org/packages/Yande.re/0.1.0)
