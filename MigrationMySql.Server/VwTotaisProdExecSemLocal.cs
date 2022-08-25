using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwTotaisProdExecSemLocal
    {
        public int? IdPrescricao { get; set; }
        public int? IdProduto { get; set; }
        public string Descri { get; set; } = null!;
        public decimal? TotUsado { get; set; }
        public string? Apresentacao { get; set; }
        public decimal Matmed { get; set; }
    }
}
