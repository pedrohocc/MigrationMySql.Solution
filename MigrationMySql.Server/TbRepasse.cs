using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbRepasse
    {
        public int CodRepasse { get; set; }
        public DateTime? DataRepasse { get; set; }
        public string? Usuario { get; set; }
        public decimal? CustoTotal { get; set; }
        public decimal? TotalPago { get; set; }
        public decimal? RepasseTotal { get; set; }
    }
}
