using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Datos
{
    public interface IService<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(List<Expression<Func<T, object>>> includes);

        T Single(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes);

        List<T> Filter(Expression<Func<T, bool>> predicate);
        List<T> Filter(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes);


        Boolean Create(T entity);
        Boolean Update(T entity);

        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> predicate);
    }
}
