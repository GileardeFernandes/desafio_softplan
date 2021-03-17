using System.Threading.Tasks;
using API2.Domain.Dtos;
using API2.Domain.Models;

namespace API2.Domain.Services
{
    public interface ICalculaJurosService {

        Task<ResultadoCalculoJuros> CalularJurosComposto(DadosCalculoJurosDTO dados);
    }
}