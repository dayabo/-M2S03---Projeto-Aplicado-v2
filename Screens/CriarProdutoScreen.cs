using System.Text;
using GeraEstoque.Models;
using GeraEstoque.Repositories;


namespace GeraEstoque.Screens;
public static class CriarProdutoScreen{

public static void  Iniciar(ProdutoRepository repository){
     Console.Clear();

    Console.WriteLine("Nome do Produto:");
    string produto = Console.ReadLine();

    Console.WriteLine("Quantidade em Estoque");
    double quantidade = double.Parse(Console.ReadLine());

    Console.WriteLine("Valor Pago");
    float valorCompra = float.Parse(Console.ReadLine());

    Console.WriteLine("Valor da Venda");
    float valorVenda = float.Parse(Console.ReadLine());

    repository.Produtos.Add(new Produto(produto, quantidade, valorCompra, valorVenda));
    ShowProduto(repository, produto, quantidade, valorCompra, valorVenda);
 }
      public static void ShowProduto(ProdutoRepository repository, string produto, double quantidade,  float valorCompra,  float valorVenda)
    {
      StringBuilder buider = new StringBuilder("\n Produto cadastrado com sucesso !\n");
    buider.Append($"--------------------------------------");

    buider.Append($"\n  Produto:{produto.ToUpper()};");
    buider.Append($"\n  Qtd:{quantidade};");
    buider.Append($"\n  Valor da Compra {valorCompra.ToString("c")};");
    buider.Append($"\n  Valor da Venda {valorVenda.ToString("c")}.");
    Console.WriteLine(buider.ToString());
    Console.WriteLine($"\n Pressione qualquer tecla para retornar ao menu");
    if (Console.ReadKey().Key != ConsoleKey.Escape)
    {
      Console.Clear();
      MenuScreen.Iniciar(repository);
    }

  }}
