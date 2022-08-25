using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Anamnese
    {
        public int Codigo { get; set; }
        public DateTime? Data { get; set; }
        public string? Historico { get; set; }
        public int? Medico { get; set; }
        public int? Paciente { get; set; }
        public int? Statusnet { get; set; }
        public int? Unidadeorigem { get; set; }
        public decimal? Codigonet { get; set; }
        public string? ResultExames { get; set; }
        public string? Cid10 { get; set; }
        public bool? FlagSigiloso { get; set; }
    }
}
