using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CampProject.DataAccessLayer.Concrete.UnitOfWork
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return SaveChanges();
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return SaveChanges();
        }

        public bool Delete(int Id)
        {
            _context.Set<T>().Remove(GetById(Id));
            return SaveChanges();
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return SaveChanges();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }
    }
}
