using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Entities;

namespace Catalogo.Data
{
    public class Base
    {
        protected CatalogoEntities _context;

        public Base()
        {
            _context = new CatalogoEntities();
            _context.Configuration.ProxyCreationEnabled = false;
        }
    }
}
