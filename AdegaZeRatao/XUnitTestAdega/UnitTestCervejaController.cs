using AdegaZeRatao.Dominio;
using System.Collections.Generic;
using Xunit;
using XUnitTestAdega.TestsData;
using FluentAssertions;
using AdegaZeRataoWebApi.Controllers;

namespace XUnitTestAdega
{
    public class UnitTestCervejaController
    {
        CervejaController _controller;

        public UnitTestCervejaController()
        {
            _controller = new CervejaController();
        }

        #region Ativos
        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(CervejaControllerModelsTheoryAtivos))]
        public void CervejaControllerGetListaCervejas(Cerveja input1)
        {
            Assert.IsType<IEnumerable<Cerveja>>(_controller.Ativos());
        }
        #endregion

        #region Atualizar
        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheoryAtualizar.GetTestsModelsTheorySuccess), MemberType = typeof(CervejaControllerModelsTheoryAtualizar))]
        public void CervejaControllerPostAtualizarCervejasSuccess(Cerveja input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheoryAtualizar.GetTestsModelsTheoryNoContent), MemberType = typeof(CervejaControllerModelsTheoryAtualizar))]
        public void CervejaControllerPostAtualizarCervejasNoContent(Cerveja input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Salvar
        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheorySalvar.GetTestsModelsTheorySuccess), MemberType = typeof(CervejaControllerModelsTheorySalvar))]
        public void CervejaControllerPostSalvarCervejasSuccess(Cerveja input1)
        {
            _controller.Salvar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheorySalvar.GetTestsModelsTheoryNoContent), MemberType = typeof(CervejaControllerModelsTheorySalvar))]
        public void CervejaControllerPostSalvarCervejasNoContent(Cerveja input1, Cerveja input2)
        {
            _controller.Salvar(input1).Status.Should().Be(0, "Retornou Secesso!!");
            _controller.Salvar(input2).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Excluir
        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheoryExcluir.GetTestsModelsTheorySuccess), MemberType = typeof(CervejaControllerModelsTheoryExcluir))]
        public void CervejaControllerPostExcluirCervejasSuccess(Cerveja input1)
        {
            _controller.Excluir(input1).Should().Be("Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(CervejaControllerModelsTheoryExcluir.GetTestsModelsTheoryNoContent), MemberType = typeof(CervejaControllerModelsTheoryExcluir))]
        public void CervejaControllerPostExcluirCervejasNoContent(Cerveja input1, Cerveja input2)
        {
            _controller.Excluir(input1).Should().Be("Retornou Secesso!!");
            _controller.Excluir(input2).Should().Be("Retornou Secesso!!");
        }

        #endregion
    }
}
