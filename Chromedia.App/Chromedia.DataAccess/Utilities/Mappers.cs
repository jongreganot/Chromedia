using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.DataAccess.Dtos;
using Chromedia.DataAccess.JsonModels;

namespace Chromedia.DataAccess.Utilities
{
    public static class Mapper
    {
        public static IEnumerable<T1> Map<T1, T2>(IEnumerable<T2> tList2)
        {
            if (typeof(T1) == typeof(ArticleReadDto) && typeof(T2) == typeof(ArticleData))
            {
                var returnList = new List<ArticleReadDto>();
                foreach (var t2 in tList2 as IEnumerable<ArticleData>)
                {
                    var article = new ArticleReadDto
                    {
                        Title = t2.Title,
                        Url = t2.Url,
                        Author = t2.Author,
                        NumberOfComments = t2.Num_Comments,
                        StoryId = t2.Story_Id,
                        StoryTitle = t2.Story_Title,
                        StoryUrl = t2.Story_Url,
                        ParentId = t2.Parent_Id,
                        CreatedOn = t2.Created_At
                    };

                    returnList.Add(article);
                }

                return returnList as IEnumerable<T1>;
            }

            throw new NotImplementedException();
        }
    }
}
