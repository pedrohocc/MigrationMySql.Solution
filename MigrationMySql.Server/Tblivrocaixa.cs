using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tblivrocaixa
    {
        public int Idmov { get; set; }
        public DateTime? Dtmov { get; set; }
        public string? Historico { get; set; }
        public int? Idfornecedor { get; set; }
        public decimal? Vlmov { get; set; }
        public int? Tipomov { get; set; }
        public int? FlFechado { get; set; }
    }
}
