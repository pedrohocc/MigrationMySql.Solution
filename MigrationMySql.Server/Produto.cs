using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Produto
    {
        public Produto()
        {
            ProdutosMovimentacaos = new HashSet<ProdutosMovimentacao>();
            TbEntSaiProdItens = new HashSet<TbEntSaiProdIten>();
            TbEstoqueProdutos = new HashSet<TbEstoqueProduto>();
            TbPreProdRepasses = new HashSet<TbPreProdRepasse>();
            TbProdutosCobrancas = new HashSet<TbProdutosCobranca>();
        }

        public decimal? Recnum { get; set; }
        public string Descri { get; set; } = null!;
        public decimal? Minimo { get; set; }
        public decimal? PrCusto { get; set; }
        public decimal? Divisor { get; set; }
        public decimal? PrVenda { get; set; }
        public decimal? Saldo0Qtd { get; set; }
        public decimal? Saldo { get; set; }
        public string? Apresentacao { get; set; }
        public decimal Matmed { get; set; }
        public decimal? Multiplicador { get; set; }
        public string? Qtdpadrao { get; set; }
        public string? UnidCompra { get; set; }
        public string? UnidConsumo { get; set; }
        public decimal? Conversao { get; set; }
        public string? Brasindice { get; set; }
        public string? Livre { get; set; }
        public string? Tabela { get; set; }
        public int? Grupo { get; set; }
        public string? UnidCobranca { get; set; }
        public string? CodConv { get; set; }
        public int? Convant { get; set; }
        public int? Convbb { get; set; }
        public string? Localizacao { get; set; }
        public int? Tipodespesa { get; set; }
        public string? NumTiss { get; set; }
        public string? Codigotabelatiss { get; set; }
        public decimal? CodAmb { get; set; }
        public decimal? Codigo { get; set; }
        public decimal? PrVendaAnt { get; set; }
        public int? IdGrupo { get; set; }
        public int Codident { get; set; }
        public int? Flinativo { get; set; }
        public string? Codanvisa { get; set; }
        public int? Codfabricante { get; set; }
        public string? Codbarras { get; set; }
        public int? ProdRef { get; set; }
        public int? ProdBase { get; set; }
        public int? Flrepasse { get; set; }
        public string? DescriResumida { get; set; }
        public string? Dosagem { get; set; }

        public virtual GruposProduto? IdGrupoNavigation { get; set; }
        public virtual ICollection<ProdutosMovimentacao> ProdutosMovimentacaos { get; set; }
        public virtual ICollection<TbEntSaiProdIten> TbEntSaiProdItens { get; set; }
        public virtual ICollection<TbEstoqueProduto> TbEstoqueProdutos { get; set; }
        public virtual ICollection<TbPreProdRepasse> TbPreProdRepasses { get; set; }
        public virtual ICollection<TbProdutosCobranca> TbProdutosCobrancas { get; set; }
    }
}
