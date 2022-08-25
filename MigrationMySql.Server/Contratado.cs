using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Contratado
    {
        public int? Convenio { get; set; }
        public string? Codigonoconvenio { get; set; }
        public string? Nome { get; set; }
        public string? Cnes { get; set; }
        public int Codigo { get; set; }
        public string? Unidade { get; set; }
        public int? Flinterno { get; set; }
        public int? Faturaclinica { get; set; }
    }
}
