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
    public class PublisherController : Controller
    {
        private readonly IPublisherRepository _publisherRepository;
        private IBookRepository _bookRepository;
        public PublisherController(IPublisherRepository publisherRepository, IBookRepository bookRepository)
        {
            _publisherRepository = publisherRepository;
            _bookRepository = bookRepository;
    }

        public ActionResult Index()
        {
            var publishers = from publisher in _publisherRepository.GetAllWithBooks()
                        select publisher;
            return View(publishers);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PublisherViewModel publisherViewModel)
        {         
            _publisherRepository.Create(publisherViewModel.Publisher);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var publisherVM = new PublisherViewModel()
            {
                Publisher = _publisherRepository.GetById(id),
                
            };
            return View(publisherVM);
        }
        
        [HttpPost]
        public IActionResult Update(PublisherViewModel publisherViewModel)
        {
            if (!ModelState.IsValid)
            {
                publisherViewModel.Books = _bookRepository.GetAll();
                return View(publisherViewModel);
            }
            _publisherRepository.Update(publisherViewModel.Publisher);
            return RedirectToAction("Index");
        }
        

        [HttpGet]
        public IActionResult Details(int id)
        {
            var publisher = _publisherRepository.GetById(id);
            return View(publisher);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _publisherRepository.GetById(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(PublisherViewModel publisherViewModel)
        {
            if (ModelState.IsValid)
            {
                var publisher = _publisherRepository.GetById(publisherViewModel.Id);
                _publisherRepository.Delete(publisher);
                return RedirectToAction("index");
            }
            return View();
        }

        
    }
}