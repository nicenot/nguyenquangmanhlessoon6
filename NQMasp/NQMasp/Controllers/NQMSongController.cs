using NQMasp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NQMasp.Controllers
{
    public class NQMSongController : Controller
    {
        private static List<NQMSong> NQMSongs = new List<NQMSong>()
        {
            new NQMSong{nqmid=221,nqmTitle="Nguyễn Quang Mạnh",nqmAuthor="k22cntt1",nqmArtist="đẹp zai",nqmYaerRelease=2024 },
            new NQMSong{nqmid=222,nqmTitle="lovesong",nqmAuthor="k22cntt1",nqmArtist="đẹp zai",nqmYaerRelease=2025}
        };
        // GET: NQMSong
        public ActionResult Index()
        {
            return View(NQMSongs);
        }
        public ActionResult NqmCreate()
        {
            var NQMSong = new NQMSong();
            return View(NQMSong);
        }
        [HttpPost]
        public ActionResult NqmCreat(NQMSong nqmSong)
        {
            if (!ModelState.IsValid)
            {
                return View(nqmSong);
            }
            NQMSongs.Add(nqmSong);
            return RedirectToAction("Index");
        }
    }
}