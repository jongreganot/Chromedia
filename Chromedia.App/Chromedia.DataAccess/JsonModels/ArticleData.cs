using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromedia.DataAccess.JsonModels
{
    public class ArticleData
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
        public int? Num_Comments { get; set; }
        public int? Story_Id { get; set; }
        public string Story_Title { get; set; }
        public string Story_Url { get; set; }
        public int? Parent_Id { get; set; }
        public string Created_At { get; set; }
    }
}
