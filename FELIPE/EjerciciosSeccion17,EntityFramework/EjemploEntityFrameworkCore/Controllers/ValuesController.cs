using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjemploEntityFrameworkCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEntityFrameworkCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ICancionService _cancionService;

        public ValuesController(ICancionService cancionService)
        {
            _cancionService = cancionService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _cancionService.AddCancion(new Models.Cancion 
            { 
                Descripcion = "Asereje Ja de Je",
                Duracion = new TimeSpan(0, 4, 25),
                Titulo = "Asereje"
            });

            var canciones = _cancionService.GetCanciones();

            var cancion = _cancionService.GetCancion(1);

            cancion.Descripcion = "Entidad cambiada";

            _cancionService.UpdateCancion(cancion);
            _cancionService.DeleteCancion(2);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}