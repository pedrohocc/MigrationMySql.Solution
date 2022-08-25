using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbaplicaPlanTerapIten
    {
        public decimal? IdaplicaPlanTerap { get; set; }
        public decimal? Codproduto { get; set; }
        public int? Qtdproduto { get; set; }
        public int? Qtdplaneja { get; set; }
        public int? Qtddose { get; set; }
        public string? UnidadeDose { get; set; }
        public int? Via { get; set; }
        public int? UnidadePlaneja { get; set; }
        public string? UnidadeAplica { get; set; }
        public decimal IdaplicaPlanTerapItens { get; set; }
    }
}
