using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;
using API1.Domain.Services;
using Microsoft.AspNetCore.Mvc;


namespace API1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : Controller {
       
        private readonly  ITaxaJurosService  _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService  taxaJurosService){

            _taxaJurosService = taxaJurosService;
        }

        [HttpGet]
        public async Task<List<TaxaJuros>> GetAllAsync(){

            var taxaJuros = await _taxaJurosService.ListAsync();
            return taxaJuros;
        }        
    }
}