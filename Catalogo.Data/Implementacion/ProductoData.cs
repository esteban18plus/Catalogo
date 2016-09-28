using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Catalogo.Entities;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Catalogo.Data.Interfaz;
using Catalogo.Entities.Dto;

namespace Catalogo.Data.Implementacion
{
    public class ProductoData :Base,IProductoData
    {
        protected CatalogoEntities _context = new CatalogoEntities();

        public ProductoData()
        {
            _context = new CatalogoEntities();
        }

        public ProductoDto Create(ProductoDto entityDto)
        {
            var entity = Mapper.Map<ProductoDto, Producto>(entityDto);
            _context.Producto.Add(entity);
            _context.SaveChanges();
            return Mapper.Map<Producto, ProductoDto>(entity);
        }

        public bool Delete(int id)
        {
            var entity = _context.Producto.Find(id);
            if (entity != null)
            {
                _context.Producto.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ProductoDto> GetAll()
        {
            return  _context.Producto.ProjectTo<ProductoDto>().ToList();
        }

        public List<ProductoDto> GetAllBy(Expression<Func<ProductoDto, bool>> condition)
        {
            return _context.Producto.ProjectTo<ProductoDto>().Where(condition).ToList();
        }

        public ProductoDto GetBy(Expression<Func<ProductoDto, bool>> condition)
        {
            return  _context.Producto.ProjectTo<ProductoDto>().FirstOrDefault(condition);
        }

        public ProductoDto GetById(int id)
        {
            var entity = _context.Producto.Find(id);
            var result = Mapper.Map<Producto, ProductoDto>(entity);
            return result;
        }

        public bool Update(ProductoDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
