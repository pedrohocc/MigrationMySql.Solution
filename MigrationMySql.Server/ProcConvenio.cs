using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProcConvenio
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descri { get; set; } = null!;
        public string? Indice { get; set; }
        public string? Mascara { get; set; }
        public Guid Rowguid { get; set; }
    }
}
