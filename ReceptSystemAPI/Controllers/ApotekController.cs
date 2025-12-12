using BusinessLogic.BLL;
using DTO.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReceptSystemAPI.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ApotekController : ControllerBase
    {
        //[Route("getRecept")]
        [HttpGet("{cprNr}")]
        public DTORecept getRecept(int cprNr)
        {

            return ApotekBLL.getRecept(cprNr);
        }
    }
}
