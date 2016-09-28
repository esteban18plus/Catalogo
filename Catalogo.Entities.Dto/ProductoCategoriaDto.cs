using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Entities.Dto
{
    public class ProductoCategoriaDto
    {
        public long IdProductoCategoria { get; set; }
        public long? IdProducto { get; set; }
        public int? IdCategoria { get; set; }
    }
}
