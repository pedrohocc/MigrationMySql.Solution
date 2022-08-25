using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Movimentacao
    {
        public int? Banco { get; set; }
        public int? Tipo { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Valor { get; set; }
    }
}
