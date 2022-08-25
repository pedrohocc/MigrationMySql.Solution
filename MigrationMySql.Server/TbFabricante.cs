using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbFabricante
    {
        public TbFabricante()
        {
            TbEntSaiProdItens = new HashSet<TbEntSaiProdIten>();
        }

        public int IdFabricante { get; set; }
        public string DescFabricante { get; set; } = null!;

        public virtual ICollection<TbEntSaiProdIten> TbEntSaiProdItens { get; set; }
    }
}
