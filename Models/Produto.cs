namespace GeraEstoque.Models;
 public class Produto
{
public Guid Id = Guid.NewGuid();
  public string Nome = string.Empty;
  public double Quantidade;
  public float Custo;
  public float Venda;

  public Produto(){}

  public Produto( string nome, double quantidade, float custo, float venda)
  {

    Nome = nome;
    Quantidade = quantidade;
    Custo = custo;
    Venda = venda;
  }

  public override string ToString()
  {
    return $"Produto:  Id: {Id} |  Nome: {Nome.ToUpper()} | Qtd: {Quantidade} | R$ Compra: {Custo.ToString("c")} | R$ Venda: {Venda.ToString("c")}";

  }
  }
