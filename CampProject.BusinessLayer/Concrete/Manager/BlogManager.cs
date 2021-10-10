using CampProject.DataAccessLayer.Abstract.IRepositories;
using CampProject.DataAccessLayer.Concrete;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.BusinessLayer.Concrete.Manager
{
    public class BlogManager
    {

        private IBlogRepository blogRepository;

        public BlogManager()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new CampContext());
            blogRepository = unitOfWork.Blog;
        }

        public List<Blog> GetList()
        {
            return blogRepository.List();
        }

        public Blog GetById(int Id)
        {
            return blogRepository.GetById(Id);
        }
    }
}
