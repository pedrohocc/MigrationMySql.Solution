using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProdExtra
    {
        public decimal Recnum { get; set; }
        public string Tabela { get; set; } = null!;
        public decimal Produto { get; set; }
        public string? CodExt { get; set; }
        public decimal? Preco { get; set; }
        public DateTime? UltAlt { get; set; }
    }
}
