using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbProfConvRepasse
    {
        public int IdProfConvRepasse { get; set; }
        public int Codprof { get; set; }
        public int Convenio { get; set; }
        public decimal? Vlrepasse { get; set; }
    }
}
