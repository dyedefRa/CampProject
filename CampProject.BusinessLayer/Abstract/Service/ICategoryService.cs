using CampProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampProject.BusinessLayer.Abstract.Service
{
   public interface ICategoryService
    {
        List<Category> GetCategories();
        List<Category> GetTopCategories(int count = 3);
    }
}
