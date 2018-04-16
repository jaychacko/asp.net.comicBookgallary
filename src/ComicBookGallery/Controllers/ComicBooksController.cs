using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepo _comicBookRepo = null;

        public ComicBooksController ()
        {

            _comicBookRepo = new ComicBookRepo();
        }


        public  ActionResult Detail(int? id)
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            var comicBookModel = _comicBookRepo.GetComicBook((int)id);


            return View(comicBookModel);

        }

    }
}