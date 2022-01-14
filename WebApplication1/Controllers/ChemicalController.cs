using HectreMgmt.Domain.Model;
using HectreMgmt.Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HectreMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChemicalController : ControllerBase
    {
        private readonly ChemicalRepo _chemicalRepo;
        public ChemicalController(ChemicalRepo chemicalRepo)
        {
            _chemicalRepo = chemicalRepo;
        }

        [HttpGet(Name = "GetChemicals")]
        public IEnumerable<Chemical> Get()
        {
            return _chemicalRepo.Gets(20, 10);
        }
    }
}
