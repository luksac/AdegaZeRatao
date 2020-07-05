using System.Collections.Generic;
using AdegaZeRatao.Dominio;
using AdegaZeRataoWebApi.Controllers;
using FluentAssertions;
using Xunit;
using XUnitTestAdega.TestsData;

namespace XUnitTestAdega
{
    public class UnitTestRespostasController
    {

        RespostasController _controller;

        public UnitTestRespostasController()
        {
            _controller = new RespostasController();
        }

        #region Ativos
        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(RespostasControllerModelsTheoryAtivos))]
        public void RespostaControllerGetListaRespostas(Respostas input1)
        {
            Assert.IsType<List<Respostas>>(_controller.Ativos());
        }
        #endregion

        #region Atualizar
        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(RespostasControllerModelsTheoryAtualizar))]
        public void RespostaControllerPostAtualizarRespostasSuccess(Respostas input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheoryAtualizar.GetTestsModelsTheoryNoContent), MemberType = typeof(RespostasControllerModelsTheoryAtualizar))]
        public void RespostaControllerPostAtualizarRespostasNoContent(Respostas input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Salvar
        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheorySalvar.GetTestsModelsTheorySuccess), MemberType = typeof(RespostasControllerModelsTheorySalvar))]
        public void RespostaControllerPostSalvarRespostasSuccess(Respostas input1)
        {
            _controller.Salvar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheorySalvar.GetTestsModelsTheoryNoContent), MemberType = typeof(RespostasControllerModelsTheorySalvar))]
        public void RespostaControllerPostSalvarRespostasNoContent(Respostas input1, Respostas input2)
        {
            _controller.Salvar(input1).Status.Should().Be(0, "Retornou Secesso!!");
            _controller.Salvar(input2).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Excluir
        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheoryExcluir.GetTestsModelsTheorySuccess), MemberType = typeof(RespostasControllerModelsTheoryExcluir))]
        public void RespostaControllerPostExcluirRespostasSuccess(Respostas input1)
        {
            _controller.Excluir(input1).Should().Be("Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(RespostasControllerModelsTheoryExcluir.GetTestsModelsTheoryNoContent), MemberType = typeof(RespostasControllerModelsTheoryExcluir))]
        public void RespostaControllerPostExcluirRespostasNoContent(Respostas input1, Respostas input2)
        {
            _controller.Excluir(input1).Should().Be("Retornou Secesso!!");
            _controller.Excluir(input2).Should().Be("Retornou Secesso!!");
        }

        #endregion

    }
}
