using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CampProject.DataAccessLayer.Abstract.IRepositories
{
    public interface IGenericRepository<T> where T:class
    {
        T GetById(int Id);
        List<T> List();
        bool Add(T entity);
        bool Delete(T entity);
        bool Delete(int Id);
        bool Update(T entity);
        bool SaveChanges();
        List<T> Find(Expression<Func<T, bool>> predicate);
    }
}
