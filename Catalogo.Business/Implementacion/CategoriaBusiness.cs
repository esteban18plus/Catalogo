using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Business.Interfaz;
using Catalogo.Entities.Dto;
using Catalogo.Data.Interfaz;
using Catalogo.Data.Implementacion;
using Strategee.Business;

namespace Catalogo.Business.Implementacion
{
    public class CategoriaBusiness : ICategoriaBusiness
    {

        ICategoriaData _icategoriadata;

        public CategoriaBusiness()
        {
            _icategoriadata = new CategoriaData();
        }


        public BusinessResult<CategoriaDto> Create(CategoriaDto entityDto)
        {
            try
            {
                var result = _icategoriadata.Create(entityDto);
                return BusinessResult<CategoriaDto>.Success(result,"Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<CategoriaDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<bool> Delete(int id)
        {
            try
            {
                var result = _icategoriadata.Delete(id);
                return BusinessResult<bool>.Success(true, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<CategoriaDto>> GetAll()
        {
            try
            {
                var result = _icategoriadata.GetAll();
                return BusinessResult<List<CategoriaDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<List<CategoriaDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<CategoriaDto>> GetAllBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            try
            {
                var result = _icategoriadata.GetAllBy(condition);
                return BusinessResult<List<CategoriaDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<List<CategoriaDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<CategoriaDto> GetBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            try
            {
                var result = _icategoriadata.GetBy(condition);
                return BusinessResult<CategoriaDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<CategoriaDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<CategoriaDto> GetById(int id)
        {
            try
            {
                var result = _icategoriadata.GetById(id);
                return BusinessResult<CategoriaDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<CategoriaDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<bool> Update(CategoriaDto entityDto)
        {
            try
            {
                _icategoriadata.Update(entityDto);
                return BusinessResult<bool>.Success(true, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }
    }
}
