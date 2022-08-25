using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Leito
    {
        public decimal Recnum { get; set; }
        public string Numero { get; set; } = null!;
        public decimal UnidInternacao { get; set; }
        public decimal Prontuario { get; set; }
    }
}
