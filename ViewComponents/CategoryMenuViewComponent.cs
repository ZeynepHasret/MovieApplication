using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MovieApp.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            CategoryRepository categoryRepository = new CategoryRepository();
            
            return View(categoryRepository.Categories);
        }
    }
}
