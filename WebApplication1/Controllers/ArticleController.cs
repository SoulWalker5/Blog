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
    public class ArticleController : Controller
    {
        private readonly IArticleService _service;
        private readonly IMapper _mapper;
        public ArticleController(IArticleService article, IMapper mapper)
        {
            _service = article;
            _mapper = mapper;
        }

        // GET: Article
        public ActionResult Index()
        {
            var articleBL = _service.GetAll().ToList();
            var articleView = _mapper.Map<IEnumerable<ArticleModel>>(articleBL);

            return View(articleView);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            var articleBL = _service.FindById(id);
            var articleView = _mapper.Map<ArticleModel>(articleBL);

            return View(articleView);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(ArticleModel model)
        {
            try
            {
                // TODO: Add insert logic here

                var articleBL = _mapper.Map<ArticleBL>(model);
                _service.Create(articleBL);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ArticleModel model)
        {
            try
            {
                // TODO: Add update logic here

                var articleBL = _mapper.Map<ArticleBL>(model);
                _service.Update(articleBL);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
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
