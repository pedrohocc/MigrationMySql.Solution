using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class AjusteEstoque
    {
        public AjusteEstoque()
        {
            AjusteEstoqueItens = new HashSet<AjusteEstoqueIten>();
        }

        public int Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public string Observacao { get; set; } = null!;
        public bool Validado { get; set; }
        public string? CodigoValidacao { get; set; }

        public virtual ICollection<AjusteEstoqueIten> AjusteEstoqueItens { get; set; }
    }
}
