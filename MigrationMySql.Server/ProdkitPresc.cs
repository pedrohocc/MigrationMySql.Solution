using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProdkitPresc
    {
        public string? NumTiss { get; set; }
        public string? UnidCompra { get; set; }
        public decimal? Codigo { get; set; }
        public string? Descri { get; set; }
        public string? Apresentacao { get; set; }
        public decimal? PrVenda { get; set; }
        public int? Qtdpadrao { get; set; }
        public string? UnidConsumo { get; set; }
        public decimal? Conversao { get; set; }
        public string? Tabela { get; set; }
        public int? Flinativo { get; set; }
        public int? IdGrupo { get; set; }
    }
}
