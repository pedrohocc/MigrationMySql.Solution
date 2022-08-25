using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwRepasseInter
    {
        public string? Codtiss { get; set; }
        public string? Siglamed { get; set; }
        public int Codmedsolici { get; set; }
        public string Medsolici { get; set; } = null!;
        public decimal? Qtdutilizada { get; set; }
        public int PrCusto { get; set; }
        public string? Nf { get; set; }
        public DateTime? Datapg { get; set; }
        public decimal? Conta { get; set; }
        public DateTime Dtdeta { get; set; }
        public int? Fatura { get; set; }
        public string Profissional { get; set; } = null!;
        public decimal Tipo { get; set; }
        public string? Descricao { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? Vlunit { get; set; }
        public decimal? Vltotal { get; set; }
        public decimal? Totalpago { get; set; }
        public decimal? Vlglosa { get; set; }
        public int? TipoAtend { get; set; }
        public string Paciente { get; set; } = null!;
        public string Nomeconv { get; set; } = null!;
        public int Custototal { get; set; }
        public decimal? LucroBruto { get; set; }
        public decimal? LucroLiquido { get; set; }
        public decimal? Repasse { get; set; }
        public decimal? Precounit { get; set; }
        public int? Custounitario { get; set; }
        public int? CodigoRepasse { get; set; }
        public int Registro { get; set; }
        public string? Mesref { get; set; }
        public decimal Codconv { get; set; }
    }
}
