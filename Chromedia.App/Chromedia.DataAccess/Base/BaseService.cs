using Chromedia.DataAccess.JsonModels;
using Newtonsoft.Json;

namespace Chromedia.DataAccess.Base
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly string _url;
        public BaseService(string url)
        {
            _url = url;
        }

        public async Task<string> GetAll()
        {
            var content = await GetContent();

            ArticlePage jObject = JsonConvert.DeserializeObject<ArticlePage>(content);

            return jObject.ToString();
        }

        private async Task<string> GetContent()
        {
            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Get, _url);
            var res = await client.SendAsync(msg);

            var content = await res.Content.ReadAsStringAsync();

            return content;
        }
    }
}
