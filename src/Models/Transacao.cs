namespace Rinha.Models;

public class Transacao
{
  public int Valor { get; }
  public char Tipo { get; }
  public string Descricao { get; }
  public string DataExtrato { get;}

  public Transacao(int valor, char tipo, string descricao, string data_extrato){
    this.Valor = valor;
    this.Tipo = tipo;
    this.Descricao = descricao;
    this.DataExtrato = data_extrato;
  }
}
