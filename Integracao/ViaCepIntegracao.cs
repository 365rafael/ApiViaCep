using ApiViaCep.Integracao.Interfaces;
using ApiViaCep.Integracao.Refit;
using ApiViaCep.Integracao.Response;

namespace ApiViaCep.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;
        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }
        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);
            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null; 
        }
    }
}
