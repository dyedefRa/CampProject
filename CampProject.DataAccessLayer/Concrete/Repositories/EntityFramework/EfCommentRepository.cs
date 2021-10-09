using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.Repositories.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public EfCommentRepository(CampContext campContext) : base(campContext)
        {

        }
    }
}
