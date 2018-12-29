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
    public class MemberController : Controller
    {
        private AllianceDbContext _context;
        MemberService _service;

        public MemberController (AllianceDbContext entities)
        {
            _context = entities;
            _service = new MemberService(_context);
        }
        public IActionResult Index()
        {
            //ViewData["Message"] = "Show members";
            var model = _service.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _service.Get(id);

            return PartialView("_EditMemberPartial", model);
        }

        [HttpPost]
        public IActionResult Edit(MemberModel model)
        {
            if (ModelState.IsValid)
            {

            }
            //var model = _service.Get(id);
            return PartialView("_ContactModalPartial", model);
        }
    }
}