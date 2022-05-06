using Chromedia.Business.BusinessLogic.Interfaces;
using Chromedia.Business.Models.Interfaces;

namespace Chromedia.Business.Models
{
    public class Article : IArticle
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
        public int NumberOfComments { get; set; }
        public int? StoryId { get; set; }
        public int? StoryTitle { get; set; }
        public int? StoryUrl { get; set; }
        public int? ParentId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
