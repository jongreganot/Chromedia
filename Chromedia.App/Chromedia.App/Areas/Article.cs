using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.Business.BusinessLogic.Interfaces;

namespace Chromedia.App.Areas
{
    public class Article
    {
        public Article(IArticleLogic articleLogic)
        {
            Task.Run(() => articleLogic.GetAll())
                .ContinueWith(task => Console.WriteLine(task.Result));
        }
    }
}
