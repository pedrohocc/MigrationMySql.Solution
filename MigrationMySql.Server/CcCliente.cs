using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class CcCliente
    {
        public DateTime? Data { get; set; }
        public decimal? Valor { get; set; }
        public int? Forma { get; set; }
        public string? Observacao { get; set; }
        public string? Operador { get; set; }
        public int Codigo { get; set; }
        public decimal? Conta { get; set; }
        public int? Atualiza { get; set; }
        public Guid Rowguid { get; set; }
    }
}
