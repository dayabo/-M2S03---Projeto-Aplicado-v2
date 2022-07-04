

using GeraEstoque.Repositories;
using GeraEstoque.Screens;

namespace GeraEstoqueNew// Note: actual namespace depends on the project name.
{
  internal class Program
  {

    static void Main(string[] args)
    {
      ProdutoRepository repository = new ProdutoRepository();

      MenuScreen.Iniciar(repository);
    }
  }
}