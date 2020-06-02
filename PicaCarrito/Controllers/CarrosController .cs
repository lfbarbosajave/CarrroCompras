using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PicaCarrito.Models;
using PicaCarrito.Services;
using Microsoft.AspNetCore.Mvc;


namespace PicaCarrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrosController : ControllerBase
    {

        private readonly CarroService _carroService;

        public CarrosController(CarroService carroService)
        {
            _carroService = carroService;
        }

        [HttpGet]
        public ActionResult<List<Carro>> Get() =>
            _carroService.Get();

        [HttpGet("{id:length(200)}", Name = "GetCarro")]
        public ActionResult<Carro> Get(string id)
        {
            var carro = _carroService.Get(id);

            if (carro == null)
            {
                return NotFound();
            }

            return carro;
        }

        [HttpPost]
        public ActionResult<Carro> Create(Carro carro)
        {
            _carroService.Create(carro);

            return CreatedAtRoute("GetCarro", new { id = carro.Id.ToString() }, carro);
        }

        [HttpPut()]
        public IActionResult Update(string id, Carro carroIn)
        {
            var carro = _carroService.Get(id);

            if (carro == null)
            {
                return NotFound();
            }

            _carroService.Update(id, carroIn);

            return NoContent();
        }

        [HttpDelete()]
        public IActionResult Delete(string id)
        {
            var carro = _carroService.Get(id);

            if (carro == null)
            {
                return NotFound();
            }

            _carroService.Remove(carro.Id);

            return NoContent();
        }
    }
}
