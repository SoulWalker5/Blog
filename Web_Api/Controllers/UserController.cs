using AutoMapper;
using BL.BLModel;
using BL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_Api.Models;

namespace Web_Api.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _service;
        private IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: api/User

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var model = _service.GetAll();
            var apimodel = _mapper.Map<IEnumerable<UserApiModel>>(model);

            return Ok(apimodel);
        }

        // GET: api/User/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var model = _service.FindById(id);
            var apimodel = _mapper.Map<UserApiModel>(model);

            return Ok(apimodel);
        }

        // POST: api/User
        [HttpPost]
        public IHttpActionResult Post([FromBody] UserApiModel apiModel)
        {
            var userBL = _mapper.Map<UserBL>(apiModel);
            _service.Create(userBL);

            return Ok();
        }

        // PUT: api/User/5
        [HttpPut]
        public IHttpActionResult Put([FromBody] ArticleApiModel apiModel)
        {
            var userBL = _mapper.Map<UserBL>(apiModel);
            _service.Update(userBL);

            return Ok();
        }

        // DELETE: api/User/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.Remove(id);

            return Ok();
        }
    }
}
