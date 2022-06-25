using System.Text;

namespace GeraEstoqueNew;
public static class Cadastrar
{
  public static void CadastrarProdutos()
  {


    var id = Guid.NewGuid().ToString();
    Console.WriteLine("Nome do Produto");
    string produto = Console.ReadLine();
    Console.WriteLine("Quantidade em Estoque");
    double quantidade = double.Parse(Console.ReadLine());
    Console.WriteLine("Valor Pago");
    float valorCompra = float.Parse(Console.ReadLine());
    Console.WriteLine("Valor da Venda");
    float valorVenda = float.Parse(Console.ReadLine());
    StringBuilder buider = new StringBuilder("\n Produto cadastrado com sucesso !\n");
    buider.Append($"\n  Id: {id};");
    buider.Append($"\n  Produto: {produto};");
    buider.Append($"\n  Qtd: {quantidade};");
    buider.Append($"\n  Valor da Compra R$ {valorCompra};");
    buider.Append($"\n  Valor da Venda R$ {valorVenda}.");
    Console.WriteLine(buider.ToString());
    Console.WriteLine($"\n Pressione qualquer tecla para retornar ao menu");
    if (Console.ReadKey().Key != ConsoleKey.Escape)
    {
      Console.Clear();
      Menu.Menus();
    }

  }
}