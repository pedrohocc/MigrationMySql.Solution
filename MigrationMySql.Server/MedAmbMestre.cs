using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class MedAmbMestre
    {
        public decimal? Recnum { get; set; }
        public decimal Registro { get; set; }
        public decimal Posto { get; set; }
        public DateTime DtMovim { get; set; }
        public decimal Prontuario { get; set; }
        public string? Observacao { get; set; }
        public decimal? QtdItens { get; set; }
        public decimal? RegistroP { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalPago { get; set; }
        public string? Operador { get; set; }
        public int? FlInteira { get; set; }
    }
}
