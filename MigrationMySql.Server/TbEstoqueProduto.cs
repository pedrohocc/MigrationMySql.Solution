using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbEstoqueProduto
    {
        public int IdProduto { get; set; }
        public int IdLocal { get; set; }
        public int? Qtd { get; set; }
        public string Lote { get; set; } = null!;

        public virtual TbLocalEstoque IdLocalNavigation { get; set; } = null!;
        public virtual Produto IdProdutoNavigation { get; set; } = null!;
    }
}
