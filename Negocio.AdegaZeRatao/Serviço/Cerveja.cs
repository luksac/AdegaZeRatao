using System;
using AdegaZeRatao.Dominios;
using AdegaZeRatao.Dados;

namespace Serviço
{
    public class CervejaServico
    {
        private readonly CervejaRepositorio _cervejaRepositorio;
        public CervejaServico()
        {
            _cervejaRepositorio = new CervejaRepositorio();
        }

        public string Salvar(Cerveja entidade)
        {
            if (entidade.Validar())
                return "Categoria Inválida.";
            return "ok";
        }
    }
}
