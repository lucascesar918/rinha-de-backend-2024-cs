namespace Rinha.Models;

public class Saldo
{
  public int Total { get; }
  public int Limite { get; }
  public string DataExtrato { get; }

  public Saldo(int total, int limite, string data_extrato){
    this.Total = total;
    this.Limite = limite;
    this.DataExtrato = data_extrato;
  }
}
