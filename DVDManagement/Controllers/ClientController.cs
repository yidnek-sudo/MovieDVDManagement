using DVDManagement.Data.InterfaceRepo;
using DVDManagement.Data.model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVDManagement.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepo _clientRepo;
        private readonly IDvdRepo _dvdRepo;

        public ClientController(IClientRepo clientRepo, IDvdRepo dvdRepo)
        {
            _clientRepo = clientRepo;
            _dvdRepo = dvdRepo;
        }
        [Route("Client")]
        public IActionResult List()
        {
            var clientVM = new List<CientViewModel>();

            var cients = _clientRepo.GetAll();

            if (cients.Count() == 0)
            {
                return View("Empty");
            }

            foreach (var client in cients)
            {
                clientVM.Add(new CientViewModel
                {
                    Client = client,
                    DvdCount = _dvdRepo.Count(x => x.ClientId == client.ClientId)
                });
            }

            return View(clientVM);
        }

        public IActionResult Delete(int id)
        {
            var client = _clientRepo.GetById(id);

            _clientRepo.Delete(client);

            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }

            _clientRepo.Create(client);

            return RedirectToAction("List");
        }

        public IActionResult Update(int id)
        {
            var client = _clientRepo.GetById(id);

            return View(client);
        }

        [HttpPost]
        public IActionResult Update(Client client)
        {
            if (!ModelState.IsValid)
            {
                return View(client);
            }

            _clientRepo.Update(client);

            return RedirectToAction("List");
        }
    }
} 