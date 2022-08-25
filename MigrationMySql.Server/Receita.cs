using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Receita
    {
        public int Codigo { get; set; }
        public string Paciente { get; set; } = null!;
        public DateTime Data { get; set; }
        public string? Texto { get; set; }
        public int? Requisitante { get; set; }
        public int? Statusnet { get; set; }
        public int? Unidadeorigem { get; set; }
        public decimal? Codigonet { get; set; }
    }
}
