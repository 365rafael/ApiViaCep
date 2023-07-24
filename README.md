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
  
![image](https://github.com/365rafael/ApiViaCep/assets/97065934/e2a28c8d-056c-42b2-aab8-022cd61aad9b)


## Preview
    
![image](https://github.com/365rafael/ApiViaCep/assets/97065934/23c75476-4616-4129-a82c-5aa03bfde0ec)
