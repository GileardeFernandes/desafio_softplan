using System.Collections.Generic;
using System.Threading.Tasks;
using API1.Domain.Models;

namespace  API1.Domain.Repositories {

  public interface ITaxaJurosRepository {
      Task<List<TaxaJuros>> ListAsync();
  }

}
