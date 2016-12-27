﻿using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult Detail(int? id)
        {
            if(id==null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(_comicBookRepository.GetComicBook((int)id));
            }
             
        }
        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }
    }
}