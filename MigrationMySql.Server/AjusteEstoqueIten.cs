using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class AjusteEstoqueIten
    {
        public int Codigo { get; set; }
        public string? Lote { get; set; }
        public DateTime DataAjuste { get; set; }
        public int Usuario { get; set; }
        public string UsuarioNome { get; set; } = null!;
        public string TipoAjuste { get; set; } = null!;
        public string ValorAnterior { get; set; } = null!;
        public string ValorAlterado { get; set; } = null!;
        public int? AjusteEstoqueCodigo { get; set; }

        public virtual AjusteEstoque? AjusteEstoqueCodigoNavigation { get; set; }
    }
}
