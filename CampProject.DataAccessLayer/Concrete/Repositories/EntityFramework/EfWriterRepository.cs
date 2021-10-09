using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.DataAccessLayer.Concrete.Repositories.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        public EfWriterRepository(CampContext campContext) : base(campContext)
        {

        }
    }
}
