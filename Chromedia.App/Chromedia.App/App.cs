using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.App.Areas;
using Chromedia.Business.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Chromedia.App
{
    public class App
    {
        public IServiceProvider ServiceProvider { get; set; }

        public App()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.Configure();

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var article = new Article(ServiceProvider.GetRequiredService<IArticleLogic>());
        }
    }
}
