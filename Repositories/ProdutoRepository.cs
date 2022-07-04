
using GeraEstoque.Models;

namespace GeraEstoque.Repositories;

public class ProdutoRepository :Produto
{
  public IList<Produto> Produtos;

  public ProdutoRepository()
  {
    Produtos = new List<Produto>();
  }
}