using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019MG604.Models;

namespace _2019MG604.Controllers
{
    [ApiController]
    public class marcasController : ControllerBase
    {
        private readonly _2019MG604Context _contexto;

        public marcasController(_2019MG604Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/marcas")]
        public IActionResult Get(){
        var marcasList = _contexto.marcas;
        return Ok(marcasList);
        }
    }
}