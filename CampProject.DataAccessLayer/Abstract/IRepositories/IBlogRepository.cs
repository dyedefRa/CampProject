using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using CampProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CampProject.DataAccessLayer.Abstract.IRepositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetLast10Category();
    }
}
