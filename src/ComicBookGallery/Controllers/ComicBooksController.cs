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
        public  ActionResult Detail()
        {
            var comicBookModel = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists(){Name="Script",Value="Dan Slott"},
                    new Artists(){Name="Pencils",Value="Humberto Ramos"},
                    new Artists(){Name="Inks",Value="Victor Olazaba"},
                    new Artists(){Name="Colors",Value="Edgar Delgado"},
                    new Artists(){Name="Letters",Value="Chris Eliopoulos"}
                }

            };

    
            return View(comicBookModel);

        }

    }
}