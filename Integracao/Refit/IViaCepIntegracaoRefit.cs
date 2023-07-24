using Refit;
using ApiViaCep.Integracao.Response;

namespace ApiViaCep.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep); 
    }
}
