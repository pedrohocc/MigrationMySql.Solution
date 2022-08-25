using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbprofdium
    {
        public int Idprofdia { get; set; }
        public int? Codprof { get; set; }
        public DateTime? Dtagenda { get; set; }
        public string? Obsprofdia { get; set; }
        public int? Intervalo { get; set; }
        public string? Usuprofdia { get; set; }
        public int? Sematendimento { get; set; }
    }
}
