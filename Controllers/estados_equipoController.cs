using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019MG604.Models;

namespace _2019MG604.Controllers
{
    [ApiController]
    public class estados_equipoController : ControllerBase
    {
        private readonly _2019MG604Context _contexto;

        public estados_equipoController(_2019MG604Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/estados")]
        public IActionResult Get(){
            var estados_equipoList = _contexto.estados_equipo;
                return Ok(estados_equipoList);
        }
    }
}