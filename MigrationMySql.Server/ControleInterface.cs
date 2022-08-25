using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ControleInterface
    {
        public string? PSaida { get; set; }
        public string? PEntrada { get; set; }
        public DateTime? TAtua { get; set; }
        public Guid Rowguid { get; set; }
    }
}
