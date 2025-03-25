namespace CadastroUsuarioCase.Service;

public interface IServiceUsuario
{
    // Implementação dos contratos para os métodos de cadastro, listagem e busca de usuários
    void CadastrarUsuario();
    void ListarUsuarios();
    void BuscarUsuario();
    void RemoverUsuario();
}
