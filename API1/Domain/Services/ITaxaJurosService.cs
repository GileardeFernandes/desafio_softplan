using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;

namespace API1.Domain.Services
{
    public interface ITaxaJurosService
    {
        Task<List<TaxaJuros>> ListAsync();
    }
}