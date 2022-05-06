using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.Business.BusinessLogic.Interfaces;
using Chromedia.Business.Models;
using Chromedia.Business.Utilities;
using Chromedia.DataAccess;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.Business.BusinessLogic
{
    public sealed class ArticleLogic : IArticleLogic
    {
        private readonly IArticleService _articleService;
        private List<Article> CachedArticles { get; set; }

        public List<Article> GetCachedArticles()
        {
            return CachedArticles;
        }

        public void SetCachedArticles(List<Article> articles)
        {
            CachedArticles = articles;
        }

        public List<Article> GetLimitArticles(int limit)
        {
            return CachedArticles.Take(limit).ToList();
        }

        public ArticleLogic(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public async Task<IEnumerable<Article>> GetAll()
        {
            var articleDtos = await _articleService.GetAll();
            var articles = Mapper.Map<Article, ArticleReadDto>(articleDtos);

            return articles.OrderByDescending(a => a.NumberOfComments).ThenByDescending(a => a.Title);
        }
    }
}
