using CadastroUsuarioCase.Repositories;
using CadastroUsuarioCase.Service;

// Criação do Serviço 
var serviceUsuario = new ServiceUsuario(new UsuariosRepository());

// Estrutura de repetição com menu de opções
while (true)
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Cadastrar usuário");
    Console.WriteLine("2 - Listar usuários");
    Console.WriteLine("3 - Buscar usuário por nome");
    Console.WriteLine("4 - Sair");

    var opcao = Console.ReadLine(); // Recebendo a opção do usuário

    // Executando a opção escolhida
    switch (opcao) 
    {
        // os metodos para cada caso estão implementados na pasta Service
        case "1":
            serviceUsuario.CadastrarUsuario();
            break;
        case "2":
            serviceUsuario.ListarUsuarios();
            break;
        case "3":
            serviceUsuario.BuscarUsuario();
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

}





