using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Unidade
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public bool? Padrao { get; set; }
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
        public string? Endereco { get; set; }
        public int? Inicial { get; set; }
        public string? Ip { get; set; }
        public int? Status { get; set; }
        public int? Nivel { get; set; }
        public int? Local { get; set; }
        public string? Cidade { get; set; }
        public string? Caminhoxml { get; set; }
        public string? Cidpadrao { get; set; }
        public string? Logonet { get; set; }
        public string? Endnet { get; set; }
        public int? IdWeb { get; set; }
        public int? FlEnviasms { get; set; }
        public string? HrEnviosms { get; set; }
        public string? StMsgSms { get; set; }
        public DateTime? Datanivel { get; set; }
        public string? Caminhologo { get; set; }
        public string? Caminhomodelos { get; set; }
        public int? CodigoFinanceiro { get; set; }
        public string? ServerFinanceiro { get; set; }
        public string? BaseFinanceiro { get; set; }
        public string? UserFinanceiro { get; set; }
        public string? PassFinanceiro { get; set; }
        public int? AlertaProdutos { get; set; }
    }
}
