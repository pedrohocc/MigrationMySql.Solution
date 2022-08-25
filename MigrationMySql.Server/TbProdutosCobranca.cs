using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbProdutosCobranca
    {
        public int IdProdCobranca { get; set; }
        public int? IdPrescricao { get; set; }
        public int? IdProduto { get; set; }
        public int? IdUsuario { get; set; }
        public decimal? TotalUsado { get; set; }
        public DateTime? Data { get; set; }
        public int? Local { get; set; }
        public int? IdMovimentoItem { get; set; }

        public virtual Prescricao? IdPrescricaoNavigation { get; set; }
        public virtual Produto? IdProdutoNavigation { get; set; }
        public virtual Login? IdUsuarioNavigation { get; set; }
    }
}
