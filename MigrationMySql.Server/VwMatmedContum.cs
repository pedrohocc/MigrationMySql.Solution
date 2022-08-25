using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwMatmedContum
    {
        public int? Qtdutilizada { get; set; }
        public int? Flrepasse { get; set; }
        public decimal? PrCusto { get; set; }
        public decimal? Conta { get; set; }
        public int Codident { get; set; }
        public string? NumTiss { get; set; }
        public int? FlInteira { get; set; }
        public string? UnidCompra { get; set; }
        public decimal Matmed { get; set; }
        public int Registro { get; set; }
        public int? Item { get; set; }
        public int Produto { get; set; }
        public float? Qtd { get; set; }
        public float? PrUnit { get; set; }
        public double? Total { get; set; }
        public string? Descri { get; set; }
        public string? UnidConsumo { get; set; }
        public DateTime DtMovim { get; set; }
        public double? Totalpago { get; set; }
        public decimal? Custounitario { get; set; }
        public decimal? Divisor { get; set; }
    }
}
