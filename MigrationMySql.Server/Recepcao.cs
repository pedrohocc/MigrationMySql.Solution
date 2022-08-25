using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Recepcao
    {
        public int Codigo { get; set; }
        public int? Paciente { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? HrChega { get; set; }
        public DateTime? HrAtend { get; set; }
        public int? Tipo { get; set; }
        public int? Medico { get; set; }
        public string? Obs { get; set; }
        public DateTime? Hrmarcada { get; set; }
        public decimal? Registrop { get; set; }
        public int? Enviousms { get; set; }
        public int? Statusnet { get; set; }
        public int? Unidadeorigem { get; set; }
        public decimal? Codigonet { get; set; }
        public int? Agendaunidade { get; set; }
        public int? FlImportado { get; set; }
        public int? Status { get; set; }
        public int? Convenio { get; set; }
    }
}
