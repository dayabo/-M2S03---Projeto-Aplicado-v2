

using GeraEstoque.Repositories;

namespace GeraEstoque.Screens;
public static class MenuScreen{

  public static void  Iniciar(ProdutoRepository repository)
  {
    Console.Clear();
    char linha = '\n';
    Console.WriteLine(linha);
    Console.WriteLine("   Seja Bem Vindo ao GeraEstoque 1.0");
    Console.WriteLine(linha);
    Console.WriteLine("  1  Cadastrar produto");
    Console.WriteLine("  2  Consultar produto");
    Console.WriteLine("  3  Modificar produto");
    Console.WriteLine("  4  Excluir produto");
    Console.WriteLine("  5  Listar todos os produtos");
    Console.WriteLine("  0  Sair");
    Console.WriteLine(linha);
    Console.WriteLine(" Digite a opção: ");
    var opçãoEscolhida = Console.ReadLine();

    switch (opçãoEscolhida)
    {
      case "1":
        {
          CriarProdutoScreen.Iniciar(repository);
          Iniciar(repository);
          break;
        }
      case "2":
        {
          Console.Clear();
         Iniciar(repository);

          break;
        }
      case "3":
        {
          Console.Clear();
         Iniciar(repository);

          break;
        }
      case "4":
        {
          Console.Clear();
         Iniciar(repository);

          break;
        }
      case "5":
        {
          ListarProdutosScreen.Iniciar(repository);
          Iniciar(repository);
          break;


        }

      default:
        {
          Console.Clear();
          Environment.Exit(0);
         break;
        }
    }

  }

  }


