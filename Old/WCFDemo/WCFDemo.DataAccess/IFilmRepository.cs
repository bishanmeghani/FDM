using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo.DataAccess
{
    public interface IFilmRepository
    {
        List<Films> GetAllFilms();
    }

    public class FilmRepository : IFilmRepository
    {
        Model context;

        public FilmRepository()
        {
            context = new Model();
        }

        public List<Films> GetAllFilms() 
        {
            return context.films.ToList();
        }
    }
}
