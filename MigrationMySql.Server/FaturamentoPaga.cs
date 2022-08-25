using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class FaturamentoPaga
    {
        public int Codigo { get; set; }
        public int CodigoFatura { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal? ValorPagamento { get; set; }
        public decimal? ValorImposto { get; set; }
        public string? Observacao { get; set; }
        public decimal? ValorGlosa { get; set; }
        public int? NumeroNota { get; set; }
        public DateTime? DataNota { get; set; }

        public virtual Faturamento CodigoFaturaNavigation { get; set; } = null!;
    }
}
