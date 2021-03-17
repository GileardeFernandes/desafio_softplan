using System.Collections.Generic;
using API1.Controllers;
using API1.Domain.Models;
using API1.Domain.Services;
using API1TESTE.Service;
using Xunit;

namespace API1TESTE.Controller
{
    public class TaxaJurosControllerTest{

     TaxaJurosController _controller;
     ITaxaJurosService _service;


     public TaxaJurosControllerTest(){

         _service = new TaxaJurosServiceFake();
         _controller = new TaxaJurosController(_service);
     }
     
     [Fact]
     public async void Obter_taxadejuros_ReturnsOkResult(){
         var okResult = await _controller.GetAllAsync();

         Assert.IsType<List<TaxaJuros>>(okResult) ;

     }


    }
}