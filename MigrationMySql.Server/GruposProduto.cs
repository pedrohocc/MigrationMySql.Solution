using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class GruposProduto
    {
        public GruposProduto()
        {
            Produtos = new HashSet<Produto>();
        }

        public int IdGrupo { get; set; }
        public string? DescricaoGrupo { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
