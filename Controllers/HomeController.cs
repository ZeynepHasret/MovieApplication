using Microsoft.AspNetCore.Mvc;
using MovieApp.DATA;
using MovieApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(int? id) //Home/index/ıd yazdığım için hata aldım.
        {
         
            //var dd =  new CategoryRepository();
            var ddd = new MovieRepository();
            var movies = ddd.Movies;
            if (id!=null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories =  dd.Categories;
            //model.Movies = ddd.Movies;

            //var d1 = ddd.Movies;

            //List<Movie> d2 = ddd.Movies;
    
            //return View(Repository.Movies);
            return View(movies);   //return View(MovieRepository.Movies);
            //CategoryRepository'deki categories ve MovieRepository'deki movies özelliklerini kazandırmak için ayrı bir model(movie+category) oluşturuyoruz
       
        
        }
        public IActionResult Details(int Id)
        {
            //var ddd = new MovieCategoryModel();
            //var dd = new CategoryRepository();
            var d = new MovieRepository();
            //ddd.Categories = dd.Categories;
            //ddd.Movie = d.GetById(Id);
            return View(d.GetById(Id)); // tek bir movie için(static şart)
        }

        public IActionResult Contact()
        {
            // TODO: Your code here
            return View();
        }
        
    }
}