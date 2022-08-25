using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Prodkit
    {
        public string? NumTiss { get; set; }
        public string? UnidCompra { get; set; }
        public decimal? Codigo { get; set; }
        public string Descri { get; set; } = null!;
        public string? Apresentacao { get; set; }
        public decimal? PrVenda { get; set; }
        public string? Qtdpadrao { get; set; }
        public string? UnidConsumo { get; set; }
        public decimal? Conversao { get; set; }
        public string? Tabela { get; set; }
        public int? Flinativo { get; set; }
        public int? IdGrupo { get; set; }
    }
}
