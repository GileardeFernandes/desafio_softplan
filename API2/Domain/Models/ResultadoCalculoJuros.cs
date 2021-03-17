using System.Globalization;

namespace API2.Domain.Models
{
    public class ResultadoCalculoJuros {

        public string Resultado { get; set; }

        public ResultadoCalculoJuros (decimal resultado){
            this.Resultado = resultado.ToString("N2", new CultureInfo("pt-BR")); 
        }
    }
}