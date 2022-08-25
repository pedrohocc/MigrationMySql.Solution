using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Gradecol
    {
        public string? Grade { get; set; }
        public string? Exame { get; set; }
        public double? Ordem { get; set; }
        public double? Tamanho { get; set; }
        public int? Codgrade { get; set; }
        public Guid Rowguid { get; set; }
    }
}
