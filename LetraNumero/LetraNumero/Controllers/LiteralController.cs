using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetraNumero.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetraNumero.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string LiteralGet(int num)
        {
            return Conversores.NumeroALetras(num);
        }
        [HttpPost]
        public string LiteralPost([FromHeader]int num)
        {
            return Conversores.NumeroALetras(num);
        }
    }
}
