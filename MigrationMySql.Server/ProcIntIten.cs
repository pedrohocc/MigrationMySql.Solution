using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProcIntIten
    {
        public decimal Recnum { get; set; }
        public decimal Registro { get; set; }
        public decimal Item { get; set; }
        public decimal Tipo { get; set; }
        public decimal? Profissional { get; set; }
        public decimal? Convenio { get; set; }
        public decimal? VlUnit { get; set; }
        public decimal? Percentual { get; set; }
        public int? Atualiza { get; set; }
        public int? Material { get; set; }
        public int? Via { get; set; }
    }
}
