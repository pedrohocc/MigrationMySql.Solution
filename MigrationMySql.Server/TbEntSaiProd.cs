using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbEntSaiProd
    {
        public TbEntSaiProd()
        {
            TbEntSaiProdItens = new HashSet<TbEntSaiProdIten>();
        }

        public int IdMovimento { get; set; }
        public int? IdFornecedor { get; set; }
        public DateTime? DtCompra { get; set; }
        public int? TipoMovimento { get; set; }
        public string? NotaFiscal { get; set; }
        public DateTime? DtEntrega { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? Descontos { get; set; }
        public decimal? Impostos { get; set; }
        public decimal? ValorFrete { get; set; }
        public int? Usumov { get; set; }
        public DateTime? DtMovimento { get; set; }
        public int? FlFinalizada { get; set; }
        public decimal? Paciente { get; set; }
        public int? Prescricao { get; set; }
        public int? Origem { get; set; }
        public int? Destino { get; set; }
        public string? Temperatura { get; set; }
        public string? Obs { get; set; }
        public DateTime? DtVencimento { get; set; }

        public virtual TbLocalEstoque? DestinoNavigation { get; set; }
        public virtual TbFornecedor? IdFornecedorNavigation { get; set; }
        public virtual TbLocalEstoque? OrigemNavigation { get; set; }
        public virtual Paciente1? PacienteNavigation { get; set; }
        public virtual Prescricao? PrescricaoNavigation { get; set; }
        public virtual TbTipoMovimento? TipoMovimentoNavigation { get; set; }
        public virtual ICollection<TbEntSaiProdIten> TbEntSaiProdItens { get; set; }
    }
}
