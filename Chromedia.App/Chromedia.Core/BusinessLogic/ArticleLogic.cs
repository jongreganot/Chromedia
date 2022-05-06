using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.Business.BusinessLogic.Interfaces;
using Chromedia.Business.Models;
using Chromedia.DataAccess;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.Business.BusinessLogic
{
    public sealed class ArticleLogic : IArticleLogic
    {
        private readonly ArticleService<ArticleReadDto> _articleService;
        public ArticleLogic(IArticleService articleService)
        {
            _articleService = (ArticleService<ArticleReadDto>?)articleService;
        }
        public async Task<string> GetAll()
        {
            var articles = await _articleService.GetAll();
            return articles;
        }
    }
}
