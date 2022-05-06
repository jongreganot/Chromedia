using Chromedia.DataAccess.Base;
using Chromedia.DataAccess.Dtos;
using Chromedia.DataAccess.JsonModels;

namespace Chromedia.DataAccess
{
    public sealed class ArticleService : BaseService<ArticleReadDto, ArticlePage, ArticleData>, IArticleService
    {
        public ArticleService() :
            base("https://jsonmock.hackerrank.com/api/articles?page=")
        {
            
        }
    }
}
