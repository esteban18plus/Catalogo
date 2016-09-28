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
    public class CategoriaData :Base, ICategoriaData
    {
        public CategoriaDto Create(CategoriaDto categoriadto)
        {
            var entity = Mapper.Map<CategoriaDto, Categoria>(categoriadto);
            _context.Categoria.Add(entity);
            _context.SaveChanges();
            return Mapper.Map<Categoria, CategoriaDto>(entity);
        }

        public bool Delete(int id)
        {
            var entity = _context.Categoria.Find(id);
            if (entity != null)
            {
                _context.Categoria.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<CategoriaDto> GetAll()
        {
            return  _context.Categoria.ProjectTo<CategoriaDto>().ToList();
        }

        public List<CategoriaDto> GetAllBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            return _context.Categoria.ProjectTo<CategoriaDto>().Where(condition).ToList();
        }

        public CategoriaDto GetBy(Expression<Func<CategoriaDto, bool>> condition)
        {
            return _context.Categoria.ProjectTo<CategoriaDto>().FirstOrDefault(condition);
        }

        public CategoriaDto GetById(int id)
        {
            var entity =  _context.Categoria.Find(id);
            var result = Mapper.Map<Categoria, CategoriaDto>(entity);
            return result;
        }

        public bool Update(CategoriaDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
