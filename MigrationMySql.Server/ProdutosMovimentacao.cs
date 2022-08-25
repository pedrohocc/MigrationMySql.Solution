using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProdutosMovimentacao
    {
        public ProdutosMovimentacao()
        {
            TbEntSaiProdItens = new HashSet<TbEntSaiProdIten>();
        }

        public decimal Idmov { get; set; }
        public int? Codigopres { get; set; }
        public int? Codproduto { get; set; }
        public string? Tabelaproduto { get; set; }
        public decimal? Qtdprod { get; set; }
        public int? Usumov { get; set; }
        public DateTime? Datamov { get; set; }
        public int? Flexecutado { get; set; }
        public string? Unidproduto { get; set; }
        public string? Obsmov { get; set; }
        public decimal? Coditempresc { get; set; }
        public decimal? Codkit { get; set; }
        public DateTime? Horaaplicacao { get; set; }
        public int? Usukitconfi { get; set; }

        public virtual Prescricao? CodigopresNavigation { get; set; }
        public virtual Produto? CodprodutoNavigation { get; set; }
        public virtual ICollection<TbEntSaiProdIten> TbEntSaiProdItens { get; set; }
    }
}
