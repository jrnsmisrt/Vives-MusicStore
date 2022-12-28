using Microsoft.AspNetCore.Mvc;
using MusicStore.ViewModels;

namespace MusicStore
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            //Create a list of genres
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            // Create our view model
            var viewModel = new StoreIndexVM { 
                NumberOfGenres= genres.Count(),
                Genres = genres };
            return View();
        }
    }
}
