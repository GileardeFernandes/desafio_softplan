using System.Threading.Tasks;
using API2.Domain.Dtos;
using API2.Domain.Models;
using API2.Domain.Services;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ShowMeTheCodeController : Controller
    {


        [HttpGet]
        public string GetURLTheCode()
        {
            string  urlGitHub = "https://github.com/GileardeFernandes/desafio_softplan";
          
            return  urlGitHub;
        }

    }
}