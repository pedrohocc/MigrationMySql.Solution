using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Login
    {
        public Login()
        {
            Prescricaos = new HashSet<Prescricao>();
            TbLogs = new HashSet<TbLog>();
            TbProdutosCobrancas = new HashSet<TbProdutosCobranca>();
        }

        public string? Login1 { get; set; }
        public string? Senha { get; set; }
        public string? Grupo { get; set; }
        public string? NomeCompleto { get; set; }
        public int? TipoUsuario { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public int Codigo { get; set; }
        public int? FlLivrocaixa { get; set; }
        public string? RegProfis { get; set; }
        public string? UfConselho { get; set; }
        public string? Siglaconselho { get; set; }

        public virtual ICollection<Prescricao> Prescricaos { get; set; }
        public virtual ICollection<TbLog> TbLogs { get; set; }
        public virtual ICollection<TbProdutosCobranca> TbProdutosCobrancas { get; set; }
    }
}
