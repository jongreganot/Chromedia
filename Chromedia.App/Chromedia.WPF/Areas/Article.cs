using System;
using System.Threading.Tasks;
using Chromedia.Business.BusinessLogic.Interfaces;

namespace Chromedia.WPF.Areas
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
