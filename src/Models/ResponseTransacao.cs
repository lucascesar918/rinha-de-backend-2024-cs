namespace Rinha.Models;

public class ResponseTransacao
{
  public int Limite { get; }
  public int Saldo { get; }

  public ResponseTransacao(int limite, int saldo){
    this.Limite = limite;
    this.Saldo = saldo;
  }
}
