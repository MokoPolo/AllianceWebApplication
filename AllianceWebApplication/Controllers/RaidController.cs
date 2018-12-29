using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllianceWebApplication.Context;
using AllianceWebApplication.Models;
using AllianceWebApplication.Service;
using Microsoft.AspNetCore.Mvc;

namespace AllianceWebApplication.Controllers
{
    public class RaidController : Controller
    {
        private AllianceDbContext _context;
        RaidService _service;
        public RaidController(AllianceDbContext entities)
        {
            _context = entities;
            _service = new RaidService(_context);
        }
        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _service.Get(id);

            return PartialView("_EditRaidPartial", model);
        }

        [HttpPost]
        public IActionResult Edit(RaidModel model)
        {
            if (ModelState.IsValid)
            {
                _service.Save(model);
            }
            return PartialView("_EditRaidPartial", model);

        }
    }
}