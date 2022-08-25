using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwKitIten
    {
        public string? Descricao { get; set; }
        public string? Obskit { get; set; }
        public decimal Iditem { get; set; }
        public int? Kit { get; set; }
        public int? Produto { get; set; }
        public int? Qtd { get; set; }
        public string Descri { get; set; } = null!;
        public int? Qtddilu { get; set; }
        public string? Obs { get; set; }
        public string? Unid { get; set; }
        public decimal Matmed { get; set; }
        public int? Ordem { get; set; }
    }
}
