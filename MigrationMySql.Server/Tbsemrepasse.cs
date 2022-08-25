using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbsemrepasse
    {
        public int Idsemrepasse { get; set; }
        public string? Coditem { get; set; }
        public int? Codprof { get; set; }
    }
}
