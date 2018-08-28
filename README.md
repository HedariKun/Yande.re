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
