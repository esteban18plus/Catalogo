using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Business.Interfaz;
using Catalogo.Data.Interfaz;
using Catalogo.Data.Implementacion;
using Catalogo.Entities.Dto;
using Strategee.Business;

namespace Catalogo.Business.Implementacion
{
    public class ProductoBusiness : IProductoBusiness
    {
        IProductoData _productoData;

        public ProductoBusiness()
        {
            _productoData = new ProductoData();
        }


        public BusinessResult<ProductoDto> Create(ProductoDto entityDto)
        {
            try
            {
                var result = _productoData.Create(entityDto);
                return BusinessResult<ProductoDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<ProductoDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<bool> Delete(int id)
        {
            try
            {
                var result = _productoData.Delete(id);
                return BusinessResult<bool>.Success(true, "Operación correcta");
            }
            catch (Exception ex)
            {
                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<ProductoDto>> GetAll()
        {
            try
            {
                var result = _productoData.GetAll();
                return BusinessResult<List<ProductoDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<List<ProductoDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<List<ProductoDto>> GetAllBy(Expression<Func<ProductoDto, bool>> condition)
        {
            try
            {
                var result = _productoData.GetAllBy(condition);
                return BusinessResult<List<ProductoDto>>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<List<ProductoDto>>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<ProductoDto> GetBy(Expression<Func<ProductoDto, bool>> condition)
        {
            try
            {
                var result = _productoData.GetBy(condition);
                return BusinessResult<ProductoDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<ProductoDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<ProductoDto> GetById(int id)
        {
            try
            {
                var result = _productoData.GetById(id);
                return BusinessResult<ProductoDto>.Success(result, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<ProductoDto>.Issue(null, "Operación incorrecta", ex);
            }
        }

        public BusinessResult<bool> Update(ProductoDto entityDto)
        {
            try
            {
                _productoData.Update(entityDto);
                return BusinessResult<bool>.Success(true, "Operación correcta");
            }
            catch (Exception ex)
            {

                return BusinessResult<bool>.Issue(false, "Operación incorrecta", ex);
            }
        }
    }
}
