using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.Repositories
{
    public class BlogRepository : Repository<Blog>,IBlogRepository
    {
        public BlogRepository(CampContext campContext):base(campContext)
        {

        }
    }
}
