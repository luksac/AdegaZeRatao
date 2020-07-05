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
    public class UnitTestQuestionarioController
    {

        QuestionarioController _controller;

        public UnitTestQuestionarioController()
        {
            _controller = new QuestionarioController();
        }

        #region Ativos
        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(QuestionarioControllerModelsTheoryAtivos))]
        public void QuestionarioControllerGetListaQuestionarios(Questionario input1)
        {
            Assert.IsType<List<Questionario>>(_controller.Ativos());
        }
        #endregion

        #region Atualizar
        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(QuestionarioControllerModelsTheoryAtualizar))]
        public void QuestionarioControllerPostAtualizarQuestionariosSuccess(Questionario input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheoryAtualizar.GetTestsModelsTheoryNoContent), MemberType = typeof(QuestionarioControllerModelsTheoryAtualizar))]
        public void QuestionarioControllerPostAtualizarQuestionariosNoContent(Questionario input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Salvar
        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheorySalvar.GetTestsModelsTheorySuccess), MemberType = typeof(QuestionarioControllerModelsTheorySalvar))]
        public void QuestionarioControllerPostSalvarQuestionariosSuccess(Questionario input1)
        {
            _controller.Salvar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheorySalvar.GetTestsModelsTheoryNoContent), MemberType = typeof(QuestionarioControllerModelsTheorySalvar))]
        public void QuestionarioControllerPostSalvarQuestionariosNoContent(Questionario input1)
        {
            _controller.Salvar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Excluir
        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheoryExcluir.GetTestsModelsTheorySuccess), MemberType = typeof(QuestionarioControllerModelsTheoryExcluir))]
        public void QuestionarioControllerPostExcluirQuestionariosSuccess(Questionario input1)
        {
            _controller.Excluir(input1).Should().Be("Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(QuestionarioControllerModelsTheoryExcluir.GetTestsModelsTheoryNoContent), MemberType = typeof(QuestionarioControllerModelsTheoryExcluir))]
        public void QuestionarioControllerPostExcluirQuestionariosNoContent(Questionario input1, Questionario input2)
        {
            _controller.Excluir(input1).Should().Be("Retornou Secesso!!");
            _controller.Excluir(input2).Should().Be("Retornou Secesso!!");
        }

        #endregion

    }
}
