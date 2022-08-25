using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwProcContum
    {
        public string? Descri { get; set; }
        public DateTime? HrInicio { get; set; }
        public DateTime? HrFim { get; set; }
        public string? Descato { get; set; }
        public int? Via { get; set; }
        public int? Tecnica { get; set; }
        public int? FlSit { get; set; }
        public int? Contratado { get; set; }
        public decimal? Totalpago { get; set; }
        public string? Tabela { get; set; }
        public string? CodExt { get; set; }
        public int CodAmb { get; set; }
        public decimal? Registrop { get; set; }
        public decimal Registropm { get; set; }
        public decimal Prontuario { get; set; }
        public DateTime Data { get; set; }
        public decimal Procedimento { get; set; }
        public decimal Qtd { get; set; }
        public decimal Registropi { get; set; }
        public decimal TipoAto { get; set; }
        public decimal Profissional { get; set; }
        public decimal? Conveniopi { get; set; }
        public decimal? VlUnit { get; set; }
        public decimal? Total { get; set; }
        public string? Descricao { get; set; }
        public string Medico { get; set; } = null!;
        public string? Especialidade { get; set; }
        public string? RegProfis { get; set; }
        public string? UfConselho { get; set; }
        public string? Siglaconselho { get; set; }
        public string Convenio { get; set; } = null!;
        public bool Inativo { get; set; }
    }
}
