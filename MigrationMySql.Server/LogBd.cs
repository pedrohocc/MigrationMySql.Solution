using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class LogBd
    {
        public int Codigo { get; set; }
        public string? Bd { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public int? Status { get; set; }
        public Guid Rowguid { get; set; }
    }
}
