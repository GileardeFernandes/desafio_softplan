using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;
using API1.Domain.Repositories;
using API1.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace API1.Persistence.Repositories
{
    public class TaxaJurosRepository : BaseRepository, ITaxaJurosRepository
    {

        public  TaxaJurosRepository(AppDBContext context) : base(context){}
        public async Task<List<TaxaJuros>> ListAsync()
        {
              return await _context.TaxaJuros.ToListAsync();
        }
    }
}