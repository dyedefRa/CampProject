using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using CampProject.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CampProject.DataAccessLayer.Abstract.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetLast10Category();
        List<Category> GetTopCategories(int count = 3);
    }
}
