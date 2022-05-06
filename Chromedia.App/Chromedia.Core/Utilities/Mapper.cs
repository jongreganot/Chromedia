using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Chromedia.Business.Models;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.Business.Utilities
{
    public static class Mapper<T1, T2> where T1 : Article
    {
        public static IEnumerable<T1> Map(IEnumerable<T1> tList1, IEnumerable<T2> tList2)
        {
            if (tList1.GetType() == typeof(Article) && tList2.GetType() == typeof(ArticleReadDto))
            {
                var returnList = new List<Article>();
                foreach (var t2 in tList2 as IEnumerable<ArticleReadDto>)
                {
                    var article = new Article
                    {
                        Title = t2.Title,
                        Url = t2.Url,
                        Author = t2.Author,
                        NumberOfComments = t2.NumberOfComments,
                        StoryId = t2.StoryId,
                        StoryTitle = t2.StoryTitle,
                        StoryUrl = t2.StoryUrl,
                        ParentId = t2.ParentId,
                        CreatedOn = t2.CreatedOn
                    };

                    returnList.Add(article);
                }

                return returnList as IEnumerable<T1>;
            }

            return tList1;
        }
    }
}
