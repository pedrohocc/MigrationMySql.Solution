using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProdConvenio
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descri { get; set; } = null!;
        public string? Mascara { get; set; }
        public decimal? Revenda { get; set; }
    }
}
