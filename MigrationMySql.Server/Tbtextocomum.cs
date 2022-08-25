using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbtextocomum
    {
        public decimal Idtexto { get; set; }
        public string? Textocomum { get; set; }
        public decimal? Nrrepet { get; set; }
        public decimal? Nrrepcontagem { get; set; }
        public int? Codprof { get; set; }
    }
}
