using Chromedia.DataAccess.Base;

namespace Chromedia.DataAccess
{
    public sealed class ArticleService<ArticleReadDto> : BaseService<ArticleReadDto>, IArticleService
    {
        public ArticleService() :
            base("https://jsonmock.hackerrank.com/api/articles?page=")
        {
            
        }

        public async Task<string> GetAll()
        {
            return await base.GetAll();
        }
    }
}
