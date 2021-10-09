using CampProject.BusinessLayer.Concrete.Manager;
using CampProject.DataAccessLayer.Concrete;
using CampProject.DataAccessLayer.Concrete.Repositories.EntityFramework;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProject.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager _categoryManager;

        public CategoryController()
        {
            _categoryManager = new CategoryManager();
        }

        public IActionResult Index()
        {
            return View(_categoryManager.GetCategories());
        }
    }
}
