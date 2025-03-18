using CadastroUsuarioCase.Models;
using CadastroUsuarioCase.Repositories;

namespace CadastroUsuarioCase.Tests;

// Teste unitário para a classe UsuariosRepository 
public class UsuariosRepositoryTests
{
    [Fact]
    public void DeveCadastrarUsuario()
    {
        // Arrange: definindo o cenário de teste
        var usuario = new Usuario
        {
            Nome = "João",
            Email = "joao@gmail.com",
            Idade = 34
        };

        var repository = new UsuariosRepository();

        // Act: executando a ação que será testada
        repository.CadastrarUsuario(usuario);

        // Assert: verificando se o teste passou
        var usuarioCadastrado = repository.BuscarUsuario("João");
        Assert.NotNull(usuarioCadastrado);
        Assert.Equal(usuario.Nome, usuarioCadastrado.Nome);
        Assert.Equal(usuario.Email, usuarioCadastrado.Email);
        Assert.Equal(usuario.Idade, usuarioCadastrado.Idade);
    }

}
