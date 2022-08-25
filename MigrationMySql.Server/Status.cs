using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Status
    {
        public decimal? Codigo { get; set; }
        public string? Descricao { get; set; }
        public string? Tipo { get; set; }
        public string? Interno { get; set; }
        public Guid Rowguid { get; set; }
    }
}
