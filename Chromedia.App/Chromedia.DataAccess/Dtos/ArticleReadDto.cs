using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromedia.DataAccess.Dtos
{
    public class ArticleReadDto
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
        public int? NumberOfComments { get; set; }
        public int? StoryId { get; set; }
        public string StoryTitle { get; set; }
        public string StoryUrl { get; set; }
        public int? ParentId { get; set; }
        public string CreatedOn { get; set; }
    }
}
