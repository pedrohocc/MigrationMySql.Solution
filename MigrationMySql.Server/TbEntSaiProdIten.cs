using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbEntSaiProdIten
    {
        public int IdMovimentoItem { get; set; }
        public int? IdMovimento { get; set; }
        public int? IdProduto { get; set; }
        public decimal? IdProdMov { get; set; }
        public string? Lote { get; set; }
        public DateTime? DtFabricacao { get; set; }
        public decimal? QtdProduto { get; set; }
        public decimal? PrecoUnit { get; set; }
        public DateTime? DtValidade { get; set; }
        public bool? FlExecutado { get; set; }
        public string? Obs { get; set; }
        public int? Fabricante { get; set; }
        public int? FlagBaixa { get; set; }

        public virtual TbFabricante? FabricanteNavigation { get; set; }
        public virtual TbEntSaiProd? IdMovimentoNavigation { get; set; }
        public virtual ProdutosMovimentacao? IdProdMovNavigation { get; set; }
        public virtual Produto? IdProdutoNavigation { get; set; }
    }
}
