using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookGallery.Controllers
{
    public class SeriesController : Controller
    {
        private SeriesRepository _seriesRepository;

        public SeriesController()
        {
            _seriesRepository = new SeriesRepository();
        }

        public ActionResult Index()
        {
            var series = _seriesRepository.GeSeries();
            return View(series);
        }
    }
}