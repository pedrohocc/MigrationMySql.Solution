using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class MedIntIten
    {
        public decimal? Recnum { get; set; }
        public int Registro { get; set; }
        public int? Item { get; set; }
        public int Produto { get; set; }
        public decimal? Qtd { get; set; }
        public float? PrUnit { get; set; }
        public string? Operador { get; set; }
    }
}
