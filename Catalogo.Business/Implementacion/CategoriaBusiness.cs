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
    public class CategoriaBusiness : ICategoriaBusiness
    {
        public BusinessResult<CategoriaDto> Create(CategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<CategoriaDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public BusinessResult<List<CategoriaDto>> GetAllBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<CategoriaDto> GetBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<CategoriaDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessResult<bool> Update(CategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
