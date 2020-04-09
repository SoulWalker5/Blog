using AutoMapper;
using BL.BLModel;
using BL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {

        private IUserService _service;

        private IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: User
        public ActionResult Index()
        {
            var userBL = _service.GetAll().ToList();
            var userView = _mapper.Map<IEnumerable<UserModel>>(userBL);
            return View(userView);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var userBL = _service.FindById(id);
            var userView = _mapper.Map<UserModel>(userBL);
            return View(userView);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            try
            {
                // TODO: Add insert logic here

                var userBL = _mapper.Map<UserBL>(model);
                _service.Create(userBL);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            var userBL = _service.FindById(id);
            var userView = _mapper.Map<UserModel>(userBL);


            return View(userView);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,UserModel model)
        {
            try
            {
                // TODO: Add update logic here
                var userBL = _mapper.Map<UserBL>(model);

                _service.Update(userBL);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var userBL = _service.FindById(id);
            var userView = _mapper.Map<UserModel>(userBL);
            return View(userView);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _service.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
