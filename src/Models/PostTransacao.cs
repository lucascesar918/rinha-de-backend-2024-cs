namespace Rinha.Models;

public class PostTransacao
{
  public int Valor { get; }
  public char Tipo { get; }
  public string Descricao { get; }

  public PostTransacao(int valor, char tipo, string descricao){
    this.Valor = valor;
    this.Tipo = tipo;
    this.Descricao = descricao;
  }
}
