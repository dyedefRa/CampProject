using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CampContext _context;

        public ICategoryRepository Category { get; private set; }
        public IBlogRepository Blog { get; private set; }


        public UnitOfWork(CampContext context)
        {
            _context = context;
            Category = new CategoryRepository(_context);
            Blog = new BlogRepository(_context);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
