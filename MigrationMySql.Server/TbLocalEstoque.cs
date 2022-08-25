using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbLocalEstoque
    {
        public TbLocalEstoque()
        {
            TbEntSaiProdDestinoNavigations = new HashSet<TbEntSaiProd>();
            TbEntSaiProdOrigemNavigations = new HashSet<TbEntSaiProd>();
            TbEstoqueProdutos = new HashSet<TbEstoqueProduto>();
        }

        public int IdLocalEstoque { get; set; }
        public string Local { get; set; } = null!;

        public virtual ICollection<TbEntSaiProd> TbEntSaiProdDestinoNavigations { get; set; }
        public virtual ICollection<TbEntSaiProd> TbEntSaiProdOrigemNavigations { get; set; }
        public virtual ICollection<TbEstoqueProduto> TbEstoqueProdutos { get; set; }
    }
}
