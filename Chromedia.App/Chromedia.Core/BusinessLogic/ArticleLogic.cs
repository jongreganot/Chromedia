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
        public ArticleLogic(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public async Task<IEnumerable<Article>> GetAll()
        {
            var articles = await _articleService.GetAll();

            var article = Mapper.Map<Article, ArticleReadDto>(articles);

            return article;
        }
    }
}
