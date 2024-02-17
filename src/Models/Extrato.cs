namespace Rinha.Models;

public class Extrato
{
  public Saldo Saldo { get; }
  public Transacao[] Transacoes { get; }

  public Extrato(Saldo saldo, Transacao[] transacoes){
    if (transacoes.Length > 10) throw new ArgumentException("Extrato não pode ter mais que 10 transações.");

    this.Saldo = saldo;
    this.Transacoes = transacoes;
  }
}
