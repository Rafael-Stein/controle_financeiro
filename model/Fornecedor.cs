﻿namespace controle_financeiro.Model
{

  public class Fornecedor
  {

    public int ID { get; set; }
    public string RazaoSocial { get; set; }
    public string CNPJ { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Cidade { get; set; }
    public string CEP { get; set; }
    public string UF { get; set; }
    public string ContatoNome { get; set; }
    public string ContatoEmail { get; set; }
    public string ContatoTelefone { get; set; }

  }

}
