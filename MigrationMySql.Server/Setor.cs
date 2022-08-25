using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Setor
    {
        public int Codigo { get; set; }
        public string? Setor1 { get; set; }
        public Guid Rowguid { get; set; }
    }
}
