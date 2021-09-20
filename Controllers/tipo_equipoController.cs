using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2019MG604.Models;

namespace _2019MG604.Controllers
{
    [ApiController]
    public class tipo_equipoController : ControllerBase
    {
        private readonly _2019MG604Context _contexto;

        public tipo_equipoController(_2019MG604Context miContexto){
            this._contexto = miContexto;
        }

        [HttpGet]
        [Route("api/tipo")]
        public IActionResult Get(){
        var tipo_equipoList = _contexto.tipo_equipo;
        return Ok(tipo_equipoList);
        }
    }
}