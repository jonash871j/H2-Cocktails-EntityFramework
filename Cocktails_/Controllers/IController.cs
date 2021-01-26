using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Controllers
{
    public interface IController<T, PKEY>
    {
        public void Create(T key);
        public IEnumerable<T> GetAll();
        public IEnumerable<T> Get(PKEY id);
        public void DeleteAll();
    }
}
