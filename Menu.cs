namespace GeraEstoqueNew;
public static class Menu
{
  public static void Menus()
  {
    char linha = '\n';
    Console.WriteLine(linha);
    Console.WriteLine("   Seja Bem Vindo ao GeraEstoque 1.0");
    Console.WriteLine(linha);
    Console.WriteLine("  1  Cadastrar produto");
    Console.WriteLine("  2  Consultar produto");
    Console.WriteLine("  3  Modificar produto");
    Console.WriteLine("  4  Excluir produto");
    Console.WriteLine("  0  Sair");
    Console.WriteLine(linha);
    Console.WriteLine(" Digite a opção: ");
    var opçãoEscolhida = Console.ReadLine();

    switch (opçãoEscolhida)
    {
      case "1":
        {
          Cadastrar.CadastrarProdutos();

          break;
        }
      case "2":
        {
          Console.Clear();
          Menus();

          break;
        }
      case "3":
        {
          Console.Clear();
          Menus();

          break;
        }
      case "4":
        {
          Console.Clear();
          Menus();

          break;
        }
      case "0":
        {
          Console.Clear();
          Environment.Exit(0);
          break;
        }

      default:
        {
          Console.Clear();
          Menus(); break;
        }
    }

  }

}