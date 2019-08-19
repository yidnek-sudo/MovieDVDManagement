using DVDManagement.Data.model;  
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVDManagement.Data.InterfaceRepo;
using DVDManagement.ViewModel;

namespace DVDManagement.Controllers
{
    public class ActorController:Controller
    {
        private readonly IActorRepo _actorRepository;

        public ActorController(IActorRepo actorRepository)
        {
            _actorRepository = actorRepository;
        }
        [Route("Actor")]
        public IActionResult List()
        {
            var actors = _actorRepository.GetAllWithDvds(); 
            if (actors.Count() == 0) return View("Empty");

            return View(actors);
        }

        public IActionResult Update(int id)
        {
            var actor = _actorRepository.GetById(id);

            if (actor == null) return NotFound();

            return View(actor);
        }

        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            _actorRepository.Update(actor);

            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            var viewModel = new CreateActorViewModel
            { Referer = Request.Headers["Referer"].ToString() };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateActorViewModel actorVM)
        {
            if (!ModelState.IsValid)
            {
                return View(actorVM);
            }

            _actorRepository.Create(actorVM.Actor);

            if (!String.IsNullOrEmpty(actorVM.Referer))
            {
                return Redirect(actorVM.Referer);
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var actor = _actorRepository.GetById(id);

            _actorRepository.Delete(actor);

            return RedirectToAction("List");
        }
    }
}