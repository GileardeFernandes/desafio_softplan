using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;
using API1.Domain.Services;

namespace API1TESTE.Service
{
    public class TaxaJurosServiceFake : ITaxaJurosService
    {
        private readonly List<TaxaJuros> _taxaJuros;

        public TaxaJurosServiceFake(){
            _taxaJuros = new List<TaxaJuros>(){
                new TaxaJuros(){Id =1 ,Valor = 0.01}
            };
        }
        public Task<List<TaxaJuros>> ListAsync()
        {
     
            return Task.FromResult(_taxaJuros);
        }
    }
}