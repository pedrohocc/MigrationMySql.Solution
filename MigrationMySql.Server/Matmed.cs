using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Matmed
    {
        public string Código { get; set; } = null!;
        public string Dv { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Descrição { get; set; }
        public string? NomeComercial { get; set; }
        public string? Fabricante { get; set; }
        public string? Compra { get; set; }
        public double? Quantidade { get; set; }
        public string? Embalagem { get; set; }
        public double? Fração { get; set; }
        public string? Especi { get; set; }
        public string? Fracionar { get; set; }
        public string? GrupodeEstoque { get; set; }
        public string? ReutilizaçãoGenérico { get; set; }
        public double? Quantidade1 { get; set; }
        public double? CódigodeBarra { get; set; }
        public string? MinistériodaSaúde { get; set; }
        public DateTime? Validade { get; set; }
        public double? Simpro { get; set; }
        public double? Preço { get; set; }
        public string? Unidade { get; set; }
        public DateTime? Data { get; set; }
        public string? Origem { get; set; }
        public string? TabUd { get; set; }
        public string? Situação { get; set; }
        public string? Motivo { get; set; }
        public DateTime? Data1 { get; set; }
        public DateTime? Inclusão { get; set; }
        public DateTime? Alteração { get; set; }
        public string? Nacional { get; set; }
    }
}
