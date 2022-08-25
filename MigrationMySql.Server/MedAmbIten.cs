using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class MedAmbIten
    {
        public decimal Recnum { get; set; }
        public int Registro { get; set; }
        public int Produto { get; set; }
        public float? Qtd { get; set; }
        public float? PrUnit { get; set; }
        public int? Item { get; set; }
        public string? Operador { get; set; }
        public int? QtdUtilizada { get; set; }
        public decimal? CustoUnitario { get; set; }
    }
}
