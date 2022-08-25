using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwDetalhesContum
    {
        public decimal? Qtdutilizada { get; set; }
        public int? Flrepasse { get; set; }
        public decimal? PrCusto { get; set; }
        public string? Siglaconselho { get; set; }
        public string? RegProfis { get; set; }
        public string? UfConselho { get; set; }
        public string Profissional { get; set; } = null!;
        public decimal Tipo { get; set; }
        public decimal? Conta { get; set; }
        public DateTime Data { get; set; }
        public string? Codtiss { get; set; }
        public string? Descricao { get; set; }
        public float? Qtd { get; set; }
        public float? Vlunit { get; set; }
        public double? Vltotal { get; set; }
        public decimal Coditem { get; set; }
        public double? Totalpago { get; set; }
        public decimal? Custounitario { get; set; }
        public int Registro { get; set; }
        public decimal? Divisor { get; set; }
        public int Inativo { get; set; }
        public decimal Codprof { get; set; }
    }
}
