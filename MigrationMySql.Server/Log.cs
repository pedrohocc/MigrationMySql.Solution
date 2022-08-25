using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Log
    {
        public string? Usuario { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Hora { get; set; }
        public decimal? Conta { get; set; }
        public int Codigo { get; set; }
    }
}
