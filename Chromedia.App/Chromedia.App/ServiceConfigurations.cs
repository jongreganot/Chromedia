using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.Business.BusinessLogic;
using Chromedia.Business.BusinessLogic.Interfaces;
using Chromedia.DataAccess;
using Chromedia.DataAccess.Dtos;
using Microsoft.Extensions.DependencyInjection;

namespace Chromedia.App
{
    public static class ServiceConfigurations
    {
        public static void Configure(this ServiceCollection collection)
        {
            collection.AddTransient<IArticleService, ArticleService<ArticleReadDto>>();
            collection.AddTransient<IArticleLogic>(provider => new ArticleLogic(provider.GetRequiredService<IArticleService>()));
        }
    }
}
