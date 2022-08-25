using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class RepasseHonor
    {
        public int Codigo { get; set; }
        public int? Fatura { get; set; }
        public int? Profissional { get; set; }
        public decimal? Cobrado { get; set; }
        public decimal? Glosado { get; set; }
        public decimal? Repasse { get; set; }
        public int? Tipo { get; set; }
    }
}
