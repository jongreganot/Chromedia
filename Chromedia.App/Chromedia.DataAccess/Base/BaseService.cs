using Chromedia.DataAccess.Dtos;
using Chromedia.DataAccess.JsonModels;
using Chromedia.DataAccess.Utilities;
using Newtonsoft.Json;

namespace Chromedia.DataAccess.Base
{
    public abstract class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly string _url;
        public BaseService(string url)
        {
            _url = url;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var content = await GetContent();

            ArticlePage jObject = JsonConvert.DeserializeObject<ArticlePage>(content);

            var list = Mapper.Map<ArticleReadDto, ArticleData>(jObject.Data);

            return (IEnumerable<T>)list;
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
