using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Data.Interfaz
{
    public interface IBaseData<T>
    {
        #region Queries

        /// <summary>
        /// Obtener todos los registros
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// Obtener toos los registros por expresion Linq
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        List<T> GetAllBy(Expression<Func<T, bool>> condition);

        /// <summary>
        /// Obtener un registros por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Obtener un registro por expesion Linq
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        T GetBy(Expression<Func<T, bool>> condition);
        #endregion

        #region Insert
        /// <summary>
        /// Insertar un registro
        /// </summary>
        /// <param name="entityDto"></param>
        /// <returns></returns>
        T Create(T entityDto);
        #endregion

        #region Update
        /// <summary>
        /// Actualizar el registro
        /// </summary>
        /// <param name="entityDto"></param>
        /// <returns></returns>
        bool Update(T entityDto);
        #endregion

        #region Delete
        /// <summary>
        /// Eliminar el registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        #endregion
    }
}
