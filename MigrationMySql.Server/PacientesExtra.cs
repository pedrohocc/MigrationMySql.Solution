using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class PacientesExtra
    {
        public decimal Recnum { get; set; }
        public int Paciente { get; set; }
        public string? Ocupacao { get; set; }
        public string? Ecivil { get; set; }
        public string? Nacional { get; set; }
        public string? Natural { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? Responsavel { get; set; }
        public string? Endresp { get; set; }
        public string? Observacao { get; set; }
        public Guid Rowguid { get; set; }
    }
}
