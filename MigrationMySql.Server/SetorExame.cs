using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class SetorExame
    {
        public int Codigo { get; set; }
        public string? Sigla { get; set; }
        public string? Nome { get; set; }
        public Guid Rowguid { get; set; }
    }
}
