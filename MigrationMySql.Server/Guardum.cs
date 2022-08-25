using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Guardum
    {
        public string? Codigo { get; set; }
        public DateTime? Data { get; set; }
        public string? Nome { get; set; }
        public string? Trace { get; set; }
        public Guid Rowguid { get; set; }
    }
}
