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
    public class CategoriaData : ICategoria
    {
        public CategoriaDto Create(CategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoriaDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CategoriaDto> GetAllBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public CategoriaDto GetBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public CategoriaDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
