using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AppLibrary.BusinessLayer;
using AppLibrary.DataLayer;
using AppLibrary.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace AppLibrary.Controllers
{
    public class ClientController : Controller
    {
        private IClientRepository _clientRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IClientService _clientService;
        public ClientController(IClientRepository clientRepository,IBookRepository bookRepository, IClientService clientService)
        {
            _clientRepository = clientRepository;
            _bookRepository = bookRepository;
            _clientService = clientService;
        }
       

        public ActionResult Index()
        {
            var clients = from client in _clientRepository.GetAllWithLendings()
                        select client;
            return View(clients);
        }

        [HttpGet]
        public IActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientViewModel model)
        {           

            _clientRepository.Create(model.Client);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var clientVM = new ClientViewModel()
            {
                Client = _clientRepository.GetById(id),

            };
            return View(clientVM);
        }

        [HttpPost]
        public IActionResult Update(ClientViewModel model)
        {
            _clientRepository.Update(model.Client);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var client = _clientRepository.GetById(id);
            return View(client);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _clientRepository.GetById(id);

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                var client = _clientRepository.GetById(clientViewModel.Id);
                _clientRepository.Delete(client);
                return RedirectToAction("index");
            }
            return View();
        }

        //login
        public IActionResult Login()
        {
            if (HttpContext.User.FindFirst(ClaimTypes.Name) != null)
            {
                return RedirectToAction("Index", "Book");
            }

            return View(new LoginViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var client = _clientService.GetClient(model.Email, model.Password);

            if (client == null)
                RedirectToAction("Login");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, client.Email),
            };

            if (client.Name == "Eleonora")
            {
                claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            }

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            return RedirectToAction("Index", "Book");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public string GetName()
        {
            var name = HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;

            return string.IsNullOrEmpty(name) ? string.Empty : $"Hi {name}!";
        }

    }
}