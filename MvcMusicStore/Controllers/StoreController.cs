using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {

            return "Hello from Store.Index()";
        }
        // GET:/Store/Details/a
        public string Details(int ID)
        {
            return "Hello from Store.Details." + ID.ToString();

        }
        // Get:/Store/Browse/s
        public ActionResult Browse()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 100; i++)
            {
                albums.Add(new Album { Title = "Album " + i + 100 });
            }
            
            return View(albums);
        }

        // 
        public string WeiChartUrl(string id)
        {
            return "this is a wei chart url " + id;
        }

        [HttpPost]
        public string PostTest(string sd)
        {
            var qs = HttpContext.Request.QueryString;
            var ss = qs.AllKeys;
            var sss = qs.GetValues("sd");
            var str = qs["sd"];
            
            return "this is post test method, and id is " + sd;
        }
    }
}