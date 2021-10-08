using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using CampProject.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace CampProject.DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        //Burda sorun olabılır.
        public CampContext _campContext = new CampContext();

        public CategoryRepository(CampContext campContext) : base(campContext)
        {

        }

        public List<Category> GetLast10Category()
        {
            return _campContext.Categories.OrderByDescending(x => x.Id).Take(10).ToList();
        }
    }
}
