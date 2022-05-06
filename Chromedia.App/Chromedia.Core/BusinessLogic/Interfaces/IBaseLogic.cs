using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromedia.Business.BusinessLogic.Interfaces
{
    public interface IBaseLogic<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
    }
}
