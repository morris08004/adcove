using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Datos
{
    public abstract class BaseService<T> : IService<T> where T : class
    {
        public string Error { get; set; }
        public IRepository<T> repo;
        public IValidation validacion;
        public BaseService(IValidation validation, IRepository<T> repository)
        {
            repo = repository;
            validacion = validation;
        }

        public List<T> GetAll()
        {            
            return repo.GetAll();
        }

        public List<T> GetAll(List<Expression<Func<T, object>>> includes)
        {
            return repo.GetAll(includes);
        }


        public T Single(Expression<Func<T, bool>> predicate)
        {
            return repo.Single(predicate);
        }

        public T Single(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes)
        {
            return repo.Single(predicate, includes);
        }


        public List<T> Filter(Expression<Func<T, bool>> predicate)
        {
           
            return repo.Filter(predicate);
        }

        public List<T> Filter(Expression<Func<T, bool>> predicate, List<Expression<Func<T, object>>> includes)
        {
            return repo.Filter(predicate, includes);
        }

       
        public Boolean Create(T entity)
        {
          return repo.Create(entity);
        }

        public Boolean Update(T entity)
        {
            return repo.Update(entity);

        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            repo.Delete(predicate);
        }
    }
}
