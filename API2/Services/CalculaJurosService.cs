using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using API2.Domain.Dtos;
using API2.Domain.Models;
using API2.Domain.Services;
using Newtonsoft.Json;

namespace API2.Services
{
    public class CalculaJurosService : ICalculaJurosService
    {
        private ApiService api;
        private List<TaxaJurosDTO> taxaJurosDTO;
        public CalculaJurosService()
        {
            api = new ApiService();
        }
        public async Task<ResultadoCalculoJuros> CalularJurosComposto(DadosCalculoJurosDTO dados)
        {

            try
            {
                HttpResponseMessage response = await api.HttpClient.GetAsync("TaxaJuros");

                if (response.IsSuccessStatusCode)
                {

                    var res = await response.Content.ReadAsStringAsync();
                    taxaJurosDTO = JsonConvert.DeserializeObject<List<TaxaJurosDTO>>(res);
                }
            }
            catch (System.Exception e)
            {

                throw new Exception(e.Message);
            }




            double tempo = Math.Pow((1 + taxaJurosDTO[0].Valor), Convert.ToDouble(dados.Meses));
            decimal calculo = dados.ValorInicial * Convert.ToDecimal(tempo);
            ResultadoCalculoJuros resultado = new ResultadoCalculoJuros(calculo);

            return resultado;
        }
    }

}