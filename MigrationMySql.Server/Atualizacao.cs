using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Atualizacao
    {
        public int Codigo { get; set; }
        public string? Unidade { get; set; }
        public DateTime? Dataini { get; set; }
        public DateTime? Datafim { get; set; }
        public int? Segundos { get; set; }
    }
}
