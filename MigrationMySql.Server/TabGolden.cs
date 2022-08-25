using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TabGolden
    {
        public decimal? Conta { get; set; }
        public string? Cnpj { get; set; }
        public string? Controle { get; set; }
        public int? Tipo { get; set; }
        public string? Urgencia { get; set; }
        public string? Natureza { get; set; }
        public string? CodAutor { get; set; }
    }
}
