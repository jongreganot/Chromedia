using System.Reflection;
using Chromedia.DataAccess.Dtos;
using Chromedia.DataAccess.JsonModels;
using Chromedia.DataAccess.Utilities;
using Newtonsoft.Json;

namespace Chromedia.DataAccess.Base
{
    public abstract class BaseService<T, T1, T2> : IBaseService<T> where T : class
    {
        private readonly string _url;
        public BaseService(string url)
        {
            _url = url;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var content = await GetContent();

            T1 jObject = JsonConvert.DeserializeObject<T1>(content);


            var data = jObject.GetMyProperty<T1>("Data");

            var list = Mapper.Map<T, T2>(data as IEnumerable<T2>);

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
