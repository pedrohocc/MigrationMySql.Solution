using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class RequisicaoInterface
    {
        public int? Requisicao { get; set; }
        public string? Exame { get; set; }
        public int? Status { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Hora { get; set; }
    }
}
