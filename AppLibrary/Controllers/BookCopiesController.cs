using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLibrary.DataLayer;
using AppLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppLibrary.Controllers
{
    public class BookCopiesController : Controller
    {
        private IBookCopiesRepository _bookCopiesRepository;
        private readonly IBookRepository _bookRepository;
        private readonly ILibraryRepository _libraryRepository;

        public BookCopiesController(IBookCopiesRepository bookCopiesRepository,  IBookRepository bookRepository, ILibraryRepository libraryRepository)
        {
            _bookCopiesRepository = bookCopiesRepository;
            _bookRepository = bookRepository;
            _libraryRepository = libraryRepository;
        }
                     
        public IActionResult Index()
        {
            var bookC = from bookCopies in _bookCopiesRepository.GetAllBookCopiesWithBooks()
                        select bookCopies;
            return View(bookC);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var bookVM = new BookCopiesViewModel()
            {
                 Books = _bookRepository.GetAll(),
                 Libraries = _libraryRepository.GetAll()
            };

            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Create(BookCopiesViewModel bookCopiesViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookCopiesViewModel.Books = _bookRepository.GetAll();
                bookCopiesViewModel.Libraries = _libraryRepository.GetAll();
                return View(bookCopiesViewModel);
            }

           _bookCopiesRepository.Create(bookCopiesViewModel.BookCopies);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var bookVM = new BookCopiesViewModel()
            {
                BookCopies = _bookCopiesRepository.GetById(id),
                Libraries = _libraryRepository.GetAll(),
                Books = _bookRepository.GetAll()
            };
            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Update(BookCopiesViewModel bookCopiesViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookCopiesViewModel.Libraries = _libraryRepository.GetAll();
                bookCopiesViewModel.Books = _bookRepository.GetAll();
                return View(bookCopiesViewModel);
            }

            _bookCopiesRepository.Update(bookCopiesViewModel.BookCopies);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var bookCopies = _bookCopiesRepository.GetById(id);
            return View(bookCopies);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _bookCopiesRepository.GetById(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(BookCopiesViewModel model)
        {
            if (ModelState.IsValid)
            {
                var bookCopies = _bookCopiesRepository.GetById(model.Id);
                _bookCopiesRepository.Delete(bookCopies);
                return RedirectToAction("index");
            }
            return View();
        }



    }
}