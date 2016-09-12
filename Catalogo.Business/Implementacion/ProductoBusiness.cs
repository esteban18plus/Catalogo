using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Business.Interfaz;
using Catalogo.Entities.Dto;
using Strategee.Business;

namespace Catalogo.Business.Implementacion
{
    public class ProductoBusiness : IProductoBusiness
    {
        public BusinessResult<ProductoDto> Create(ProductoDto entityDto)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<ProductoDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<ProductoDto>> GetAllBy(Expression<Func<ProductoDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<ProductoDto> GetBy(Expression<Func<ProductoDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<ProductoDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> Update(ProductoDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
