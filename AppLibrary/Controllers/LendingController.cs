using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AppLibrary.BusinessLayer;
using AppLibrary.DataLayer;
using AppLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppLibrary.Controllers
{
    public class LendingController : Controller
    {
        private readonly ILendingRepository _lendingRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IClientService _clientService;

        public LendingController(IBookRepository bookRepository, IClientService clientService,
            IClientRepository clientRepository, ILendingRepository lendingRepository)
        {
            _lendingRepository = lendingRepository;
            _bookRepository = bookRepository;
            _clientService = clientService;
            _clientRepository = clientRepository;
        }

        public ActionResult ListOfBooks()
        {
            var lendings = from lending in _lendingRepository.GetAllWithClientandBook()
                        select lending;
            return View(lendings);
        }

        [HttpGet]
        public IActionResult LendingBook()
        {
            var lendingVM = new LendingViewModel()
            {
                Books = _bookRepository.GetAll(),
                Clients = _clientRepository.GetAll()
            };

            return View(lendingVM);
        }

        [HttpPost]
        public IActionResult LendingBook(LendingViewModel lendingViewModel)
        {
            if (!ModelState.IsValid)
            {
                lendingViewModel.Books = _bookRepository.GetAll();
                lendingViewModel.Clients = _clientRepository.GetAll();
                return View(lendingViewModel);
            }

            _lendingRepository.Create(lendingViewModel.Lending);

            return RedirectToAction("ListOfBooks");
        }

        [HttpGet]
        public IActionResult ReturnBook(int id)
        {
            var lendVM = new LendingViewModel()
            {
                Lending = _lendingRepository.GetById(id),
                Books = _bookRepository.GetAll(),
                Clients = _clientRepository.GetAll()
            };
            return View(lendVM);
        }

        [HttpPost]
        public IActionResult ReturnBook(LendingViewModel lendingViewModel)
        {
            if (!ModelState.IsValid)
            {
                lendingViewModel.Books = _bookRepository.GetAll();
                lendingViewModel.Clients = _clientRepository.GetAll();
                return View(lendingViewModel);
            }

            _lendingRepository.Update(lendingViewModel.Lending);

            return RedirectToAction("ListOfBooks");
        }
               
        public IActionResult ReturnABook(int id)
        {
            // load the current book
            var lend = _lendingRepository.GetById(id);
            // remove borrower
            lend.Client = null;

            lend.ClientId = 0;
            // update database
            _lendingRepository.Update(lend);
            // redirect to list method
            return RedirectToAction("List");
        }
    }
 }