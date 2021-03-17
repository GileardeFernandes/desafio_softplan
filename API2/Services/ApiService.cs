using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace  API2.Services
{
    public class ApiService {

        public HttpClient HttpClient {get; set;}
        private HttpClientHandler ClientHandler ;

        public ApiService(){
            ClientHandler = new HttpClientHandler();
            ClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient = new HttpClient(ClientHandler);
            HttpClient.BaseAddress = new Uri("http://localhost:5000/");
            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        

    }
}