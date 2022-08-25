using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ExamesBloqueado
    {
        public int Codigo { get; set; }
        public string? Exame { get; set; }
        public int? Tipo { get; set; }
    }
}
