using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbAnamnese
    {
        public decimal Codanamnese { get; set; }
        public decimal? Codpaciente { get; set; }
        public string? Identanam { get; set; }
        public string? Antpess { get; set; }
        public string? Antfamil { get; set; }
        public string? Histatual { get; set; }
        public string? Hipotdiag { get; set; }
        public string? Estadiam { get; set; }
        public string? Conduta { get; set; }
    }
}
