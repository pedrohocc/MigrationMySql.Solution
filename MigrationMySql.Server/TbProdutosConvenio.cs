using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbProdutosConvenio
    {
        public int ProdutoConvenio { get; set; }
        public int ProdutoEstoque { get; set; }

        public virtual Produto ProdutoConvenioNavigation { get; set; } = null!;
        public virtual Produto ProdutoEstoqueNavigation { get; set; } = null!;
    }
}
