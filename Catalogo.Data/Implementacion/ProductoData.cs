using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Data.Interfaz;
using Catalogo.Entities.Dto;

namespace Catalogo.Data.Implementacion
{
    public class ProductoData : IProducto
    {
        public ProductoDto Create(ProductoDto entityDto)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductoDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<ProductoDto> GetAllBy(Expression<Func<ProductoDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public ProductoDto GetBy(Expression<Func<ProductoDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public ProductoDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductoDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
