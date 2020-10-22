using MovieApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DATA
{
    public  class CategoryRepository
    {

         public List<Category> Categories { get; internal set; } = new List<Category>();

         public CategoryRepository()
        {
            
            var model1 = new Category { Id = 4, Name ="Korku" };
            var model2 = new Category { Id = 3, Name = "Bilim Kurgu" };
            var model3 = new Category { Id = 1, Name = "Komedi" };
            var model4 = new Category { Id = 2, Name = "Macera" };


            Categories.Add(model1);
            Categories.Add(model2);
            Categories.Add(model3);
            Categories.Add(model4);
        }


         public  List<Category> GetAll()
        {
            return Categories;
        }

        public  void AddCategory(Category entity)
        {
            Categories.Add(entity);
        }
        public  Category GetById(int id)
        {
            return Categories.FirstOrDefault(i => i.Id == id);
        }

    }

}