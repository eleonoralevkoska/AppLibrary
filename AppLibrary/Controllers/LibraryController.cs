using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLibrary.DataLayer;
using AppLibrary.DtoModels;
using AppLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppLibrary.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryRepository _libraryRepository;
        
        public LibraryController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
           
        }

        public ActionResult Index()
        {
            var libraries = from library in _libraryRepository.GetAllLibrariesWithBooks()
                             select library;
            return View(libraries);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LibraryViewModel libraryViewModel)
        {
            _libraryRepository.Create(libraryViewModel.Library);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var libraryVM = new LibraryViewModel()
            {
                Library = _libraryRepository.GetById(id),

            };
            return View(libraryVM);
        }

        [HttpPost]
        public IActionResult Update(LibraryViewModel libraryViewModel)
        {
            
            _libraryRepository.Update(libraryViewModel.Library);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var library = _libraryRepository.GetById(id);
            return View(library);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _libraryRepository.GetById(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(LibraryViewModel libraryViewModel)
        {
            if (ModelState.IsValid)
            {
                var library = _libraryRepository.GetById(libraryViewModel.Id);
                _libraryRepository.Delete(library);
                return RedirectToAction("index");
            }
            return View();
        }



    }
}