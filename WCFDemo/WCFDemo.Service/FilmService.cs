using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFDemo.DataAccess;

namespace WCFDemo.Service
{
    [ServiceContract]
    public interface IFilmService
    {
        [OperationContract] //Access Modifier from outside our program
        List<Films> GetAllFilms();
    }

    public class FilmService : IFilmService
    {
        FilmRepository filmRepo;
        public FilmService()
        {
            filmRepo = new FilmRepository();
        }

        public List<Films> GetAllFilms()
        {
            return filmRepo.GetAllFilms();
        }
    }
}
