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

        public async Task<List<T>> GetAll()
        {

            T1 jObjectHeader = JsonConvert.DeserializeObject<T1>(await GetContent(1));
            var totalPages = jObjectHeader.GetMyProperty<T1>("Total_Pages");

            var allList = new List<T>();
            for (int i = 0; i < (int)totalPages; i++)
            {
                var content = await GetContent(i + 1);
                T1 jObject = JsonConvert.DeserializeObject<T1>(content);
                var data = jObject.GetMyProperty<T1>("Data");
                var list = Mapper.Map<T, T2>(data as IEnumerable<T2>);

                allList.AddRange(list);
            }

            return allList;
        }

        private async Task<string> GetContent(int pageNumber)
        {
            using var client = new HttpClient();

            var msg = new HttpRequestMessage(HttpMethod.Get, _url + pageNumber);
            var res = await client.SendAsync(msg);

            var content = await res.Content.ReadAsStringAsync();

            return content;
        }
    }
}
