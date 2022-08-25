using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbFornecedor
    {
        public TbFornecedor()
        {
            TbEntSaiProds = new HashSet<TbEntSaiProd>();
        }

        public int IdFornecedor { get; set; }
        public string? Cnpj { get; set; }
        public string? DescFornecedor { get; set; }
        public string? TelFornecedor { get; set; }
        public string? ContatoFornecedor { get; set; }
        public string? EmailFornecedor { get; set; }
        public int? CodigoTerceiro { get; set; }

        public virtual ICollection<TbEntSaiProd> TbEntSaiProds { get; set; }
    }
}
