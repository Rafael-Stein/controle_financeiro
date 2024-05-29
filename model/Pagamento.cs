using System;

namespace controle_financeiro.Model
{

  public class Pagamento
  {

    public int ID { get; set; }
    public int FornecedorID { get; set; }
    public string NotaFiscalNumero { get; set; }
    public float Valor { get; set; }
    public DateTime Vencimento { get; set; }
    public DateTime DataPagamento { get; set; }
    public string Situacao { get; set; }

  }

}
