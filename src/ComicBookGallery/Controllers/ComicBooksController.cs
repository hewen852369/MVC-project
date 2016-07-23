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
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan SlottScript", Role = "Script" },
                    new Artist() { Name = "Humberto RamosPencils", Role = "Pencils" },
                    new Artist() { Name = "Victor OlazabaInks", Role = "Inks" },
                    new Artist() { Name = "Edgar DelgadoColors", Role = "Colors" },
                    new Artist() { Name = "Chris EliopoulosLetters", Role = "Letters" },
                }

            };

            return View(comicBook);
        }
    }
}