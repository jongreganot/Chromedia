using Chromedia.Business.Models;

namespace Chromedia.Business.BusinessLogic.Interfaces
{
    public interface IArticleLogic : IBaseLogic<Article>
    {
        public List<Article> GetCachedArticles();
        public void SetCachedArticles(List<Article> articles);
        public List<Article> GetLimitArticles(int limit);
    }
}
