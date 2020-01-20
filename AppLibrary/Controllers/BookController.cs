using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppLibrary.BusinessLayer;
using AppLibrary.DataLayer;
using AppLibrary.DtoModels;
using AppLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppLibrary.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepository;
        private IPublisherRepository _publisherRepository;
        public BookController(IBookRepository bookRepository, IPublisherRepository publisherRepository)
        {
            _bookRepository = bookRepository;
            _publisherRepository = publisherRepository;
           
        }        

        public ActionResult Index()
        {
            var books = from book in _bookRepository.GetAllWithPublisher()
                        select book;
            return View(books);
        }
    
        [HttpGet]
        public IActionResult Create()
        {
            var bookVM = new BookViewModel()
            {

                Publishers = _publisherRepository.GetAll()
            };
         
            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Create(BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookViewModel.Publishers = _publisherRepository.GetAll();
                return View(bookViewModel);
            }

            _bookRepository.Create(bookViewModel.Book);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var bookVM = new BookViewModel()
            {
                Book = _bookRepository.GetById(id),
                Publishers = _publisherRepository.GetAll()

        };
            return View(bookVM);
        }

        [HttpPost]
        public IActionResult Update(BookViewModel bookViewModel)
        {
            if (!ModelState.IsValid)
            {
                bookViewModel.Publishers = _publisherRepository.GetAll();
                return View(bookViewModel);
            }

            _bookRepository.Update(bookViewModel.Book);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetById(id);
            return View(book);
        }

            
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _bookRepository.GetById(id);
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = _bookRepository.GetById(model.Id);
                _bookRepository.Delete(book);
            return RedirectToAction("index");
            }
            return View();
        }
    }
}