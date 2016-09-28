using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Catalogo.Data.Interfaz;
using Catalogo.Entities.Dto;
using Catalogo.Entities;

namespace Catalogo.Data.Implementacion
{
    public class ProductoCategoriaData : Base, IProductoCategoria
    {
        public ProductoCategoriaDto Create(ProductoCategoriaDto productocategoriadto)
        {
            var entity = Mapper.Map<ProductoCategoriaDto, ProductoCategoria>(productocategoriadto);
            _context.ProductoCategoria.Add(entity);
            _context.SaveChangesAsync();
            return Mapper.Map<ProductoCategoria, ProductoCategoriaDto>(entity);
        }

        public bool Delete(int id)
        {
            var entity = _context.ProductoCategoria.Find(id);
            if (entity != null)
            {
                _context.ProductoCategoria.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ProductoCategoriaDto> GetAll()
        {
            return _context.ProductoCategoria.ProjectTo<ProductoCategoriaDto>().ToList();
        }

        public List<ProductoCategoriaDto> GetAllBy(Expression<Func<ProductoCategoriaDto, bool>> condition)
        {
            return _context.ProductoCategoria.ProjectTo<ProductoCategoriaDto>().Where(condition).ToList();
        }

        public ProductoCategoriaDto GetBy(Expression<Func<ProductoCategoriaDto, bool>> condition)
        {
            return  _context.ProductoCategoria.ProjectTo<ProductoCategoriaDto>().FirstOrDefault(condition);
        }

        public ProductoCategoriaDto GetById(int id)
        {
            var entity =  _context.ProductoCategoria.Find(id);
            var result = Mapper.Map<ProductoCategoria, ProductoCategoriaDto>(entity);
            return result;
        }

        public bool Update(ProductoCategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
