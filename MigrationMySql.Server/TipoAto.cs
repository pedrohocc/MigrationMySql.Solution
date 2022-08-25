using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TipoAto
    {
        public decimal Recnum { get; set; }
        public string Codigo { get; set; } = null!;
        public string? Descri { get; set; }
        public string? Fator { get; set; }
        public string? Codtiss { get; set; }
    }
}
