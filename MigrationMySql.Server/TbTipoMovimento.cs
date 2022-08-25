using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbTipoMovimento
    {
        public TbTipoMovimento()
        {
            TbEntSaiProds = new HashSet<TbEntSaiProd>();
        }

        public int IdTipoMovimento { get; set; }
        public string? DescTipoMovimento { get; set; }

        public virtual ICollection<TbEntSaiProd> TbEntSaiProds { get; set; }
    }
}
