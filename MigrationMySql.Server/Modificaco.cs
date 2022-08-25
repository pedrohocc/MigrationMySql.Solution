using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Modificaco
    {
        public decimal Codigo { get; set; }
        public string? Tabela { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Data { get; set; }
        public Guid Rowguid { get; set; }
    }
}
