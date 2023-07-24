# ApiViaCep

Integração de sistema em C# com a api da ViaCep: https://viacep.com.br/

- Biblioteca Refit
- Swagger
- .NET 6.0

## Configs

 -> Na classe Program.cs deve-se injetar o serviço RefitClient:
  
  builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
            {
                c.BaseAddress = new Uri("https://viacep.com.br");
            }
            );

->  É necessário criar uma model com as propriedades dos dados da resposta da ViaCep:
  
 public class ViaCepResponse
    {
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Localidade { get; set; }
        public string? Uf { get; set; }
        public string? Ibge { get; set; }
        public string? Gia { get; set; }
        public string? Ddd { get; set; }
        public string? Siafi { get; set; }
    }


    
![image](https://github.com/365rafael/ApiViaCep/assets/97065934/23c75476-4616-4129-a82c-5aa03bfde0ec)
