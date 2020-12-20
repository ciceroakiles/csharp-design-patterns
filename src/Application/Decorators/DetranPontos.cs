using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    // Simulação de serviço: pontos na carteira, similar ao logger
    public class DetranPontos : IDetranVerificadorDebitosService
    {
        private readonly IDetranVerificadorDebitosService _Inner;

        public DetranPontos(IDetranVerificadorDebitosService inner)
        {
            _Inner = inner;
        }

        public async Task<IEnumerable<DebitoVeiculo>> ConsultarDebitos(Veiculo veiculo)
        {
            var result = await _Inner.ConsultarDebitos(veiculo);
            Console.WriteLine(">>> Mensagem de teste: X pontos na carteira");
            return result;
        }
    }
}
