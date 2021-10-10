using CampProject.BusinessLayer.Concrete.Manager;
using CampProject.DataAccessLayer.Concrete;
using CampProject.DataAccessLayer.Concrete.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager();
        CategoryManager categoryManager = new CategoryManager();

        public IActionResult Index()
        {
            var model = blogManager.GetList();
            return View(model);
        }

        public IActionResult Detail(int Id)
        {
            return View(blogManager.GetById(Id));
        }


    }
}
