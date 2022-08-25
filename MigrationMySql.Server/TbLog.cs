using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbLog
    {
        public int IdLog { get; set; }
        public int UsuarioLog { get; set; }
        public DateTime DataLog { get; set; }
        public string DescricaoLog { get; set; } = null!;

        public virtual Login UsuarioLogNavigation { get; set; } = null!;
    }
}
