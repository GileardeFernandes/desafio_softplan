using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;
using API1.Domain.Repositories;
using API1.Domain.Services;

namespace API1.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepository;

        public TaxaJurosService(ITaxaJurosRepository taxaJurosRepository)
        {
            _taxaJurosRepository = taxaJurosRepository;
        }

        public async Task<List<TaxaJuros>> ListAsync()
        {
            return await _taxaJurosRepository.ListAsync();
        }
    }
}