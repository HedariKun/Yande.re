using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Yande.re
{
    public class YandereClient
    {
        private string BaseUrl = "https://yande.re/post.json?";
        public async Task<List<YandereImage>> GetImagesAsync(YandereTag Tag)
        {
            string URL = $"{BaseUrl}{Tag.GenerateTags()}";
            return await GetJsonData<YandereImage>(URL);
        }

        private async Task<List<T>> GetJsonData<T>(string URL) where T : new()
        {
            HttpClient Clinet = new HttpClient();
            string JsonData = string.Empty;
            try
            {
                JsonData = await Clinet.GetStringAsync(URL);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return !string.IsNullOrEmpty(JsonData) ? JsonConvert.DeserializeObject<List<T>>(JsonData) : new List<T>();
        }
    }
}
