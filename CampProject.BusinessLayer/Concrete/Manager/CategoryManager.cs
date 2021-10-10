using CampProject.BusinessLayer.Abstract.Service;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryManager()
        {
            UnitOfWork UnitOfWork = new UnitOfWork(new CampContext());
            _categoryRepository = UnitOfWork.Category;
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.List();
        }

        public List<Category> GetTopCategories(int count = 3)
        {
            return _categoryRepository.GetTopCategories(count);
        }

    } 
}
