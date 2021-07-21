using api.net.core.ejemplo.Models;
using api.net.core.ejemplo.Repository;
using api.net.core.ejemplo.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.core.ejemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelItemRepository _modelRepository;

        public ModelController(IModelItemRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }


        // GET api/model/5
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var entity = await _modelRepository.Get(id);

            return Ok();
        }

        // GET api/model/5
        [HttpGet("where/{id}")]
        public ActionResult GetWhere(int id)
        {
            var entity = _modelRepository.Get(id);

            return Ok();
        }
        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ModelRequest request)
        {
            var entity = new ModelItem
            {
                EsCliente = true,
                Nombre = request.Nombre
            };
            await _modelRepository.AddModelItem(entity);

            return Ok();
        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody] ModelItem model)
        {
            _modelRepository.UpdateModelItem(model);
        }

        [HttpPatch]
        public void Patch([FromBody] ModelItem model)
        {
            _modelRepository.UpdateModelItem(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _modelRepository.Delete(id);
        }
    }
}
    
    
