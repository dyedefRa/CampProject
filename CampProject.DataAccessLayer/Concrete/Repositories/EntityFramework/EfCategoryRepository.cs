using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete.Repositories;
using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.Repositories.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        //Burda sorun olabılır.
        public CampContext _campContext = new CampContext();

        public EfCategoryRepository(CampContext campContext) : base(campContext)
        {

        }

        public List<Category> GetLast10Category()
        {
            return _campContext.Categories.OrderByDescending(x => x.Id).Take(10).ToList();
        }
    }
}
