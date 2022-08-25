using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Mapa
    {
        public int? Codigo { get; set; }
        public string? Descricao { get; set; }
        public Guid Rowguid { get; set; }
    }
}
