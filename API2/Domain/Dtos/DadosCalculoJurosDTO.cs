namespace API2.Domain.Dtos
{
    public class DadosCalculoJurosDTO {
        
        public int Meses { get; set; }
        public decimal ValorInicial { get; set; }

         public DadosCalculoJurosDTO(int meses, decimal valorInicial){

            this.Meses  = meses;
            this.ValorInicial = valorInicial;
        }


    }
}