using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Grade
    {
        public string? Grade1 { get; set; }
        public string? Setor { get; set; }
        public string? Nome { get; set; }
        public double? Tamtotal { get; set; }
        public bool Cabfixo { get; set; }
        public string? ImpGrade { get; set; }
        public double? Tamcols { get; set; }
        public int Codigo { get; set; }
        public Guid Rowguid { get; set; }
    }
}
