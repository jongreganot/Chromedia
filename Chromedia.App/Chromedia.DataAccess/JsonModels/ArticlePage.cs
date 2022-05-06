using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromedia.DataAccess.JsonModels
{
    public class ArticlePage : ArticleHeader
    {
        public ArticleData[] Data { get; set; }
    }
}
