using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Gradesel
    {
        public string? Estacao { get; set; }
        public string? Grade { get; set; }
        public bool Imprime { get; set; }
        public Guid Rowguid { get; set; }
    }
}
