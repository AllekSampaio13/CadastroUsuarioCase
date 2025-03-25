using CadastroUsuarioCase.Models;

namespace CadastroUsuarioCase.Repositories;

// Repositório de usuários com métodos para cadastro, listagem e busca
public class UsuariosRepository : IUsuariosRepository
{
    // Lista de usuários
    private readonly List<Usuario> _usuarios;

    // Construtor
    public UsuariosRepository()
    {
        _usuarios = new List<Usuario>();
    }

    // Método para buscar um usuário pelo nome
    public Usuario? BuscarUsuario(string nome)
    {
        return _usuarios.FirstOrDefault(u => u.Nome == nome);
    }

    // Método para cadastrar um usuário
    public void CadastrarUsuario(Usuario usuario)
    {
        _usuarios.Add(usuario);
    }

    // Método para remover um usuário
    public void RemoverUsuario(Usuario usuario)
    {
        _usuarios.Remove(usuario);
    }

    // Método para listar todos os usuários
    public IEnumerable<Usuario> ListarUsuarios()
    {
        return _usuarios;
    }
}

