using CampProject.DataAccessLayer.Abstract.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IBlogRepository Blog { get; }
        ICommentRepository Comment { get; }
        IContactRepository Contact { get; }
        IWriterRepository Write { get; }
        IAboutRepository About { get; }
        //int Complete();
    }
}
