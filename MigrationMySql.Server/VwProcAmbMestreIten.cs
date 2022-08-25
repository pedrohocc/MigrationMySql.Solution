using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwProcAmbMestreIten
    {
        public decimal? Registrop { get; set; }
        public decimal Prontuario { get; set; }
        public DateTime DtMovim { get; set; }
        public decimal Procedimento { get; set; }
        public decimal? Total { get; set; }
        public decimal Qtd { get; set; }
        public string? Tabela { get; set; }
        public decimal? Totalpago { get; set; }
        public DateTime? HrInicio { get; set; }
        public DateTime? HrFim { get; set; }
        public int? Via { get; set; }
        public int? Tecnica { get; set; }
        public decimal? Reducaoacrescimo { get; set; }
        public int? FlSit { get; set; }
        public int? Contratado { get; set; }
        public int? FlInteira { get; set; }
        public decimal Tipo { get; set; }
        public decimal Profissional { get; set; }
        public decimal? Convenio { get; set; }
        public decimal? VlUnit { get; set; }
        public decimal? Percentual { get; set; }
    }
}
