using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwRepasse
    {
        public int? Codexec { get; set; }
        public string? Medsolici2 { get; set; }
        public string? Codtiss { get; set; }
        public string? Siglamed { get; set; }
        public int? Codmedsolici { get; set; }
        public string Medsolici { get; set; } = null!;
        public decimal? Qtdutilizada { get; set; }
        public decimal? PrCusto { get; set; }
        public string? Nf { get; set; }
        public DateTime? Datapg { get; set; }
        public decimal? Conta { get; set; }
        public DateTime Dtdeta { get; set; }
        public decimal? Fatura { get; set; }
        public string Profissional { get; set; } = null!;
        public decimal Tipo { get; set; }
        public string? Descricao { get; set; }
        public float? Qtd { get; set; }
        public float? Vlunit { get; set; }
        public double? Vltotal { get; set; }
        public double? Totalpago { get; set; }
        public double? Vlglosa { get; set; }
        public int? TipoAtend { get; set; }
        public string Paciente { get; set; } = null!;
        public string Nomeconv { get; set; } = null!;
        public decimal? Custototal { get; set; }
        public double? LucroBruto { get; set; }
        public double? LucroLiquido { get; set; }
        public double? Repasse { get; set; }
        public decimal? Precounit { get; set; }
        public decimal? Custounitario { get; set; }
        public int? CodigoRepasse { get; set; }
        public int Registro { get; set; }
        public string? Mesref { get; set; }
        public decimal Codconv { get; set; }
        public int? Flrepasse { get; set; }
        public int? StatusFatura { get; set; }
    }
}
