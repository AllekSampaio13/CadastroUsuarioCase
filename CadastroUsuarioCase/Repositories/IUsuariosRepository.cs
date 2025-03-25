using CadastroUsuarioCase.Models;

namespace CadastroUsuarioCase.Repositories;

// Interface do repositório de usuários
public interface IUsuariosRepository
{
    // Contratos para os métodos de cadastro, listagem e busca de usuários
    void CadastrarUsuario(Usuario usuario);
    IEnumerable<Usuario> ListarUsuarios();
    Usuario? BuscarUsuario(string nome);
    void RemoverUsuario(Usuario usuario);
}
