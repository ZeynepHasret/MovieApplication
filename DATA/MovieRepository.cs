using MovieApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DATA

{
    public class MovieRepository
    {


        public  List<Movie> Movies { get; internal set; } = new List<Movie>();

        public MovieRepository()
        {

            var model1 = new Movie { Id = 1, Name = "Eltilerin Savaşı",ShortDescription= "Eltilerin Savaşı, iki elti olan Sultan ve Gizem arasında yaşanan tatlı çekişmelere, bitmek bilmeyen rekabete odaklanıyor.", Description = "Gizem ve Sultan elti olan iki genç kadındır. İkili arasında yaşanan ufak atışmalar bir süre sonra yerini tatlı bir rekabete bırakır. Birbirlerinin yaptıklarından geri kalmayan eltiler, kendilerini eğlenceli bir savaşın içinde bulur. ", ImageUrl = "img/eltilerin-savasi.jpg",CategoryId=1 };
            var model2 = new Movie { Id = 2, Name = "Tenet", ShortDescription= "Tenet: Nolan’ın Güç Zehirlenmesi", Description = "John David Washington'ın başrolünde yer aldığı Tenet, Christopher Nolan'ın alametifarikası zaman mefhumunun bozumunu, dünyanın geleceğine gizemli bir tehdidin ışığında bir başka seviyeye taşıyor.Filmin ana kahramanı, alacakaranlığın içinde, gerçek zamanın ötesinde açığa çıkarılabilecek, uluslararası bir casusluk görevindedir. Bütün dünyayı kurtarabilmek adına, çıktığı yolculukta tek sahip olduğu donanımı bir kelimeden oluşur: Tenet Christopher Nolan'ın büyük bütçeli yeni filmidir. Çekimlerinin bir kısmı Estonya'da gerçekleşen filmin kadrosunda Robert Pattinson, John David Washington, Elizabeth Debicki, Aaron Taylor-Johnson, Kenneth Branagh ve Michael Caine gibi ünlü isimler yer alıyor.", ImageUrl = "img/tenet.jpg", CategoryId = 2 };
            var model3 = new Movie { Id = 3, Name = "Kaptan Pengu ve Arkadaşları: M. Günlüğü",ShortDescription="Kaptan Pengu'nun kayıp olan yakın arkadaşını bulurken ki macerası",  Description = "Kaptan Pengu, sera gazları ve küresel ısınma etkisiyle eriyen buzullar için çalışırken biricik dostu Putuk’un, eriyen buzuldan düşerek denizde kaybolduğunu öğrenir. Hemen arkadaşını aramaya başlayan Kaptan Pengu’ya, bu yolculukta Misket, Pelik ve Mandalina da katılacaktır. Putuk’u bulmak için çıktıkları yolda onları heyecanlı, maceralı ve komik anlar beklemektedir.", ImageUrl = "img/kaptanpengu.jpg", CategoryId = 3 };

            Movies.Add(model1);
            Movies.Add(model2);
            Movies.Add(model3);
        }

        public List<Movie> GetAll()
        {
            return Movies;
        }

        public void AddMovie(Movie entity)    
        {
            Movies.Add(entity);
        }
        public  Movie GetById(int id)
        {
            return Movies.FirstOrDefault(i => i.Id == id);
        }   

    } 

}