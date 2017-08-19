using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        MvcMusicStore.Models.MusicStoreDBContext _storDB = new Models.MusicStoreDBContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            
            return View();
        }
        
        public ActionResult DailyDeal()
        {
            var album = GetDailyDeal();
            return PartialView("_DailyDeal", album);
        }

        private Album GetDailyDeal()
        {
            var album = _storDB.Albums.OrderBy(a => System.Guid.NewGuid()).First();
            album.Price *= 0.5m;
            string p = Url.Content(album.AlbumArtUrl);
            return album;
        }
    }
}