using System.Threading.Tasks;
using API2.Domain.Dtos;
using API2.Domain.Models;
using API2.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
   [ApiController]
   [Route("[controller]")]

   public class CalculaJurosController : Controller {
       
       private readonly ICalculaJurosService _calculaJurosService;

       public CalculaJurosController(ICalculaJurosService calculaJurosService){
           _calculaJurosService = calculaJurosService;
       }


       [HttpGet]
        public async Task<ResultadoCalculoJuros> GetResultadoCalculoJuros([FromQuery]decimal valorInicial,[FromQuery]int meses){

            DadosCalculoJurosDTO dadosDTO = new DadosCalculoJurosDTO(meses, valorInicial);

            var resultadoCaluloJuros = await _calculaJurosService.CalularJurosComposto(dadosDTO);
            return resultadoCaluloJuros;
        }   

   }
}