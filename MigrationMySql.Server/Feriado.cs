using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Feriado
    {
        public string? Data { get; set; }
        public string? Descrição { get; set; }
        public string? Dia { get; set; }
        public Guid Rowguid { get; set; }
    }
}
