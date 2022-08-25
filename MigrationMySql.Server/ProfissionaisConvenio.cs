using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProfissionaisConvenio
    {
        public decimal Recnum { get; set; }
        public decimal Medico { get; set; }
        public decimal Convenio { get; set; }
        public string Tipo { get; set; } = null!;
        public Guid Rowguid { get; set; }
    }
}
