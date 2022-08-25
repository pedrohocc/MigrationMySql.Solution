using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class RecepcaoLab
    {
        public decimal Registro { get; set; }
        public DateTime Data0 { get; set; }
        public decimal Convenio { get; set; }
        public string Status { get; set; } = null!;
        public decimal? Paciente { get; set; }
        public string? Operador0 { get; set; }
        public DateTime? Data1 { get; set; }
        public DateTime? Hora0 { get; set; }
        public decimal? Minuto0 { get; set; }
        public DateTime? Hora1 { get; set; }
        public decimal? Minuto1 { get; set; }
        public string? Observacao { get; set; }
        public string? Leito { get; set; }
        public string? Operador1 { get; set; }
        public string? Guia { get; set; }
        public decimal? Fatura { get; set; }
        public decimal? UnidInternacao { get; set; }
        public decimal? Conta { get; set; }
        public int? TipoAtend { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
        public string? Gsang { get; set; }
        public string? Fatorrh { get; set; }
        public string? Fatirdu { get; set; }
        public string? Email { get; set; }
        public string? Dadosclinicos { get; set; }
        public string? Observacoes { get; set; }
        public string? Medicamentos { get; set; }
        public string? Nota { get; set; }
        public bool? Urgente { get; set; }
        public bool? Docinc { get; set; }
        public bool? Prontos { get; set; }
        public int? Tipo { get; set; }
        public string? Senhaonline { get; set; }
        public bool? Medautor { get; set; }
        public string? Unidade { get; set; }
        public int? Atualiza { get; set; }
        public string? Posto { get; set; }
        public decimal? Codigo { get; set; }
        public int? Tiposaida { get; set; }
        public string? Cid10 { get; set; }
        public string? Obs { get; set; }
        public int? Contratado { get; set; }
        public string? Autorizacao { get; set; }
        public DateTime? DtAut { get; set; }
        public int? Tipointernacao { get; set; }
        public int? Carater { get; set; }
        public int? Regime { get; set; }
        public string? Diariassol { get; set; }
        public string? Diariasaut { get; set; }
        public int? Motivosaida { get; set; }
        public int? Medico { get; set; }
        public int? TipoAcomodacao { get; set; }
        public int? Localatend { get; set; }
        public int? CodigoRepasse { get; set; }
    }
}
