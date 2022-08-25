using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbPreProdRepasse
    {
        public int IdPreprodrepasse { get; set; }
        public int Codident { get; set; }
        public string? NumTiss { get; set; }
        public decimal? Precounit { get; set; }
        public DateTime? DtEntrega { get; set; }

        public virtual Produto CodidentNavigation { get; set; } = null!;
    }
}
