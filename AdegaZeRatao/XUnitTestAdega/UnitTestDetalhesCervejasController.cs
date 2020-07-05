using AdegaZeRatao.Dominio;
using AdegaZeRataoWebApi.Controllers;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestAdega.TestsData;

namespace XUnitTestAdega
{
    public class UnitTestDetalhesCervejasController
    {
        DeatlhesCervejaController _controller;

        public UnitTestDetalhesCervejasController()
        {
            _controller = new DeatlhesCervejaController();
        }

        #region Ativos
        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(DetalhesCervejasControllerModelsTheoryAtivos))]
        public void DetalhesCervejasControllerGetListaCervejas(DetalhesCervejas input1)
        {
            Assert.IsType<IEnumerable<DetalhesCervejas>>(_controller.Ativos());
        }
        #endregion

        #region Atualizar
        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheoryAtualizar.GetTestsModelsTheorySuccess), MemberType = typeof(DetalhesCervejasControllerModelsTheoryAtualizar))]
        public void DetalhesCervejasControllerPostAtualizarDetalhesCervejassSuccess(DetalhesCervejas input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheoryAtualizar.GetTestsModelsTheoryNoContent), MemberType = typeof(DetalhesCervejasControllerModelsTheoryAtualizar))]
        public void DetalhesCervejasControllerPostAtualizarDetalhesCervejassNoContent(DetalhesCervejas input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Salvar
        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheorySalvar.GetTestsModelsTheorySuccess), MemberType = typeof(DetalhesCervejasControllerModelsTheorySalvar))]
        public void DetalhesCervejasControllerPostSalvarDetalhesCervejassSuccess(DetalhesCervejas input1)
        {
            _controller.Salvar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheorySalvar.GetTestsModelsTheoryNoContent), MemberType = typeof(DetalhesCervejasControllerModelsTheorySalvar))]
        public void DetalhesCervejasControllerPostSalvarDetalhesCervejassNoContent(DetalhesCervejas input1, DetalhesCervejas input2)
        {
            _controller.Salvar(input1).Status.Should().Be(0, "Retornou Secesso!!");
            _controller.Salvar(input2).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Excluir
        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheoryExcluir.GetTestsModelsTheorySuccess), MemberType = typeof(DetalhesCervejasControllerModelsTheoryExcluir))]
        public void DetalhesCervejasControllerPostExcluirDetalhesCervejassSuccess(DetalhesCervejas input1)
        {
            _controller.Excluir(input1).Should().Be("Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(DetalhesCervejasControllerModelsTheoryExcluir.GetTestsModelsTheoryNoContent), MemberType = typeof(DetalhesCervejasControllerModelsTheoryExcluir))]
        public void DetalhesCervejasControllerPostExcluirDetalhesCervejassNoContent(DetalhesCervejas input1, DetalhesCervejas input2)
        {
            _controller.Excluir(input1).Should().Be("Retornou Secesso!!");
            _controller.Excluir(input2).Should().Be("Retornou Secesso!!");
        }

        #endregion
    }
}
