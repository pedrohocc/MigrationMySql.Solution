using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Consult
    {
        public string? Nome { get; set; }
        public string? Fone { get; set; }
        public string? Cat { get; set; }
        public DateTime? Data { get; set; }
        public string? Hora { get; set; }
    }
}
