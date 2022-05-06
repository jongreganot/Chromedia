using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chromedia.DataAccess.Base;
using Chromedia.DataAccess.Dtos;

namespace Chromedia.DataAccess
{
    public interface IArticleService : IBaseService<ArticleReadDto>
    {
    }
}
