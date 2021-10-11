using CampProject.BusinessLayer.Concrete.Manager;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProject.ViewComponents
{
    public class TopCategoriesVC:ViewComponent
    {
        private CategoryManager _categoryManager;
        public TopCategoriesVC()
        {
            _categoryManager = new CategoryManager();
        }

        public IViewComponentResult Invoke()
        {
            var model = _categoryManager.GetTopCategories();
            return View(model);
        }
    }
}
