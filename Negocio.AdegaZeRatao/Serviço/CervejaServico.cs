using System;
using AdegaZeRatao.Dominios;
using AdegaZeRatao.Dados;
using System.Collections.Generic;

namespace AdegaZeRatao.Servico
{
    public class CervejaServico
    {
        private readonly CervejaRepositorio _cervejaRepositorio;
        public CervejaServico()
        {
            _cervejaRepositorio = new CervejaRepositorio();
        }

        public IEnumerable<Cerveja> ListaCervejas()
        {
            return _cervejaRepositorio.ListaCerveja();
        }
        
        public string Salvar(Cerveja entidade)
        {
            if (entidade.Validar())
                return "Categoria Inválida.";
            return "ok";
        }

        public string Excluir(Cerveja entidade)
        {
            return "";
        }
    }
}
