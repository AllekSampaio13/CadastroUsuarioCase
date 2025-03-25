using CadastroUsuarioCase.Models;
using CadastroUsuarioCase.Repositories;


namespace CadastroUsuarioCase.Service;

public class ServiceUsuario : IServiceUsuario
{
    // Variável para receber a interface do repositório
    private readonly IUsuariosRepository _repository;

    //Construtor para receber a interface do repositório
    public ServiceUsuario(IUsuariosRepository usuariosRepository)
    {
        _repository = usuariosRepository;
    }

    //Método para cadastrar usuários fazendo uma validação para caso o usuário informe um campo vazio 
    public void CadastrarUsuario()
    {
        Console.WriteLine("CADASTRANDO USUÁRIO: ");
        Console.WriteLine("");
        Console.WriteLine("Nome de usuário:");
        var nome = ValidaCampo(Console.ReadLine(),"Nome");
        Console.WriteLine("Email:");
        var email = ValidaCampo(Console.ReadLine(),"Email");
        Console.WriteLine("Idade:");
        var idade = ValidaCampo(Console.ReadLine(),"Idade");
        var usuario = new Usuario
        {
            Nome = nome,
            Email = email,
            Idade = int.Parse(idade)
        };
        _repository.CadastrarUsuario(usuario);
    }

    // Método para listar todos os usuários cadastrados com validação para caso não tenha nenhum usuário cadastrado
    public void ListarUsuarios()
    {
        var listaUsuarios = _repository.ListarUsuarios();
        if (!listaUsuarios.Any())
        {           
            Console.WriteLine("Nenhum usuário cadastrado");
        }
        else
        {
            Console.WriteLine("Informações do usuário:");
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine($"nome: {usuario.Nome}");
                Console.WriteLine($"email: {usuario.Email}");
                Console.WriteLine($"idade: {usuario.Idade}");
                Console.WriteLine("");
            }
        }


    }

    //Método para buscar um usuário pelo nome fazendo validação para o caso do usuário ser nulo
    public void BuscarUsuario()
    {
        Console.WriteLine("Nome de usuário:");
        var nome = ValidaCampo(Console.ReadLine(), "Nome");
        var usuario = _repository.BuscarUsuario(nome);
        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado");
            return;
        }
        else
        {
            Console.WriteLine("Informações do usuário:");
            Console.WriteLine($"nome: {usuario.Nome}");
            Console.WriteLine($"email: {usuario.Email}");
            Console.WriteLine($"idade: {usuario.Idade}");
        }

    }

    // Método para remover um usuário fazendo validação para o caso do usuário não ser encontrado
    public void RemoverUsuario()
    {
        Console.WriteLine("Nome de usuário:");
        var nome = ValidaCampo(Console.ReadLine(), "Nome");
        var usuario = _repository.BuscarUsuario(nome);
        if (usuario == null)
        {
            Console.WriteLine("Usuário não encontrado");
            return;
        }
        _repository.RemoverUsuario(usuario);

        Console.WriteLine("Usuário removido!");
    }

    // Método utilizado para validar se um campo está nulo ou vazio
    private string ValidaCampo(string? campo, string metodo)
    {
        while (string.IsNullOrEmpty(campo))
        {
            Console.WriteLine("Campo obrigatório");
            Console.WriteLine($"Informe {metodo}  do usuário:");
            campo = Console.ReadLine();
        }
        return campo;
    }
}
