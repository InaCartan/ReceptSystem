using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.BLL;
using DTO.Model;


namespace ReceptSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaegehusController : ControllerBase
    {
        [HttpGet("{cprNr}")]
        public DTORecept getRecept(int cprNr)
        {
            return LaegehusBLL.getRecept(cprNr);
        }

        //[HttpPost]
        //public void AddOrdinationToRecept(DTOOrdination ordination)
        //{
        //    LaegehusBLL.AddOrdinationToRecept(ordination);
        //}

        //[Route("getRecept")]
        [HttpPost]
        public void AddRecept(DTORecept recept)
        {
            LaegehusBLL.AddReceptToLaegehus(recept);
        }
    }
    
}
