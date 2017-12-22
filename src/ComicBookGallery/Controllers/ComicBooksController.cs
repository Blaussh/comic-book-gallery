using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookGallery.Data;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return StatusCode(404);
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}
