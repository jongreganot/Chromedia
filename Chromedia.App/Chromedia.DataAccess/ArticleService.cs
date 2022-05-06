using Chromedia.DataAccess.Base;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.DataAccess
{
    public sealed class ArticleService : BaseService<ArticleReadDto>, IArticleService
    {
        public ArticleService() :
            base("https://jsonmock.hackerrank.com/api/articles?page=")
        {
            
        }
    }
}
