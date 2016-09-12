using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategee.Business;
using System.Linq.Expressions;

namespace Catalogo.Business.Interfaz
{
    public interface IBaseBusiness<T>
    {
        #region Queries
        /// <summary>
        /// Obtener todos los registros
        /// </summary>
        /// <returns></returns>
        BusinessResult<List<T>> GetAll();

        /// <summary>
        /// Obtener toos los registros por expresion Linq
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        BusinessResult<List<T>> GetAllBy(Expression<Func<T, bool>> condition);

        /// <summary>
        /// Obtener un registros por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BusinessResult<T> GetById(int id);

        /// <summary>
        /// Obtener un registro por expesion Linq
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        BusinessResult<T> GetBy(Expression<Func<T, bool>> condition);
        #endregion

        #region Insert
        /// <summary>
        /// Insertar un registro
        /// </summary>
        /// <param name="entityDto"></param>
        /// <returns></returns>
        BusinessResult<T> Create(T entityDto);
        #endregion

        #region Update
        /// <summary>
        /// Actualizar el registro
        /// </summary>
        /// <param name="entityDto"></param>
        /// <returns></returns>
        BusinessResult<bool> Update(T entityDto);
        #endregion

        #region Delete
        /// <summary>
        /// Eliminar el registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BusinessResult<bool> Delete(int id);
        #endregion
    }
}
