using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class UnidadesInternacao
    {
        public decimal Codigo { get; set; }
        public string Descri { get; set; } = null!;
        public decimal? Setor { get; set; }
    }
}
