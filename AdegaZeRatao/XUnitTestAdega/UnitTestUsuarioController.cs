using System.Collections.Generic;
using AdegaZeRatao.Dominio;
using AdegaZeRataoWebApi.Controllers;
using FluentAssertions;
using Xunit;
using XUnitTestAdega.TestsData;

namespace XUnitTestAdega
{
    public class UnitTestUsuarioController
    {

        UsuarioController _controller;

        public UnitTestUsuarioController()
        {
            _controller = new UsuarioController();
        }

        #region Ativos
        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(UsuarioControllerModelsTheoryAtivos))]
        public void UsuarioControllerGetListaUsuarios(Usuario input1)
        {
            Assert.IsType<List<Usuario>>(_controller.Ativos());
        }
        #endregion

        #region Atualizar
        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheoryAtivos.GetTestsModelsTheorySuccess), MemberType = typeof(UsuarioControllerModelsTheoryAtualizar))]
        public void UsuarioControllerPostAtualizarUsuariosSuccess(Usuario input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheoryAtualizar.GetTestsModelsTheoryNoContent), MemberType = typeof(UsuarioControllerModelsTheoryAtualizar))]
        public void UsuarioControllerPostAtualizarUsuariosNoContent(Usuario input1)
        {
            _controller.Atualizar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Salvar
        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheorySalvar.GetTestsModelsTheorySuccess), MemberType = typeof(UsuarioControllerModelsTheorySalvar))]
        public void UsuarioControllerPostSalvarUsuariosSuccess(Usuario input1)
        {
            _controller.Salvar(input1).Status.Should().Be(1, "Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheorySalvar.GetTestsModelsTheoryNoContent), MemberType = typeof(UsuarioControllerModelsTheorySalvar))]
        public void UsuarioControllerPostSalvarUsuariosNoContent(Usuario input1)
        {
            _controller.Salvar(input1).Status.Should().Be(0, "Retornou Secesso!!");
        }

        #endregion

        #region Excluir
        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheoryExcluir.GetTestsModelsTheorySuccess), MemberType = typeof(UsuarioControllerModelsTheoryExcluir))]
        public void UsuarioControllerPostExcluirUsuariosSuccess(Usuario input1)
        {
            _controller.Excluir(input1).Should().Be("Retornou Erro!!");
        }

        [Theory]
        [MemberData(nameof(UsuarioControllerModelsTheoryExcluir.GetTestsModelsTheoryNoContent), MemberType = typeof(UsuarioControllerModelsTheoryExcluir))]
        public void UsuarioControllerPostExcluirUsuariosNoContent(Usuario input1, Usuario input2)
        {
            _controller.Excluir(input1).Should().Be("Retornou Secesso!!");
            _controller.Excluir(input2).Should().Be("Retornou Secesso!!");
        }

        #endregion

    }
}
