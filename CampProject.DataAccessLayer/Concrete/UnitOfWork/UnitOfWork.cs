using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete.Repositories.EntityFramework;

namespace CampProject.DataAccessLayer.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CampContext _context;

        public ICategoryRepository Category { get; private set; }
        public IBlogRepository Blog { get; private set; }
        public ICommentRepository Comment { get; private set; }
        public IContactRepository Contact { get; private set; }
        public IWriterRepository Write { get; private set; }
        public IAboutRepository About { get; private set; }

        public UnitOfWork(CampContext context)
        {
            _context = context;
            Category = new EfCategoryRepository(_context);
            Blog = new EfBlogRepository(_context);
            Contact = new EfContactRepository(_context);
            Write = new EfWriterRepository(_context);
            About = new EfAboutRepository(_context);
            Comment = new EfCommentRepository(_context);

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
