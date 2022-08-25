using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class LogInt
    {
        public string? Descricao { get; set; }
        public DateTime? Hora { get; set; }
        public decimal? Conta { get; set; }
    }
}
