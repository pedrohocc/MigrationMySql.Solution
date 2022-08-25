using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbplanTerap
    {
        public decimal IdplanTerap { get; set; }
        public int? Codprofissional { get; set; }
        public string? DtCriaPlan { get; set; }
        public decimal? Codpaciente { get; set; }
        public string? DescPlanTerap { get; set; }
        public string? HdaplanTerap { get; set; }
        public string? Histclin { get; set; }
        public string? Cid { get; set; }
        public string? Convenio { get; set; }
    }
}
