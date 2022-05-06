using System.Collections;
using System.ComponentModel;
using System.Reflection;
using Chromedia.Business.Models;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.Business.Utilities
{
    public static class Mapper
    {
        public static IEnumerable<T1> Map<T1, T2>(IEnumerable<T2> tList2)
        {
            if (typeof(T1) == typeof(Article) && typeof(T2) == typeof(ArticleReadDto))
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

            throw new NotImplementedException();
        }
    }
}
