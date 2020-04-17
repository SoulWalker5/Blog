using AutoMapper;
using BL.BLModel;
using BL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    public class ArticleController : ApiController
    {

        private readonly IArticleService _service;
        private readonly IMapper _mapper;
        public ArticleController(IArticleService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/Article
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = _service.GetAll();
            var apimodel = _mapper.Map<IEnumerable<ArticleApiModel>>(model);

            return Ok(apimodel);
        }

        // GET: api/Article/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var model = _service.FindById(id);
            var apimodel = _mapper.Map<ArticleApiModel>(model);

            return Ok(apimodel);
        }

        // POST: api/Article
        [HttpPost]
        public IHttpActionResult Post([FromBody] ArticleApiModel apiModel)
        {
            var articleBL = _mapper.Map<ArticleBL>(apiModel);
            _service.Create(articleBL);

            return Ok();
        }

        // PUT: api/Article/5
        [HttpPut]
        public IHttpActionResult Put([FromBody] ArticleApiModel apiModel)
        {
            var articleBL = _mapper.Map<ArticleBL>(apiModel);
            _service.Update(articleBL);

            return Ok();
        }

        // DELETE: api/Article/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.Remove(id);

            return Ok();
        }
    }
}
