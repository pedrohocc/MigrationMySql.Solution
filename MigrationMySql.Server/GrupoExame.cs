using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class GrupoExame
    {
        public int Codigo { get; set; }
        public int? Setor { get; set; }
        public string? Nome { get; set; }
        public Guid Rowguid { get; set; }
    }
}
