using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Prescricao
    {
        public Prescricao()
        {
            ProdutosMovimentacaos = new HashSet<ProdutosMovimentacao>();
            TbEntSaiProds = new HashSet<TbEntSaiProd>();
            TbProdutosCobrancas = new HashSet<TbProdutosCobranca>();
        }

        public int Codigo { get; set; }
        public decimal? Paciente { get; set; }
        public DateTime Data { get; set; }
        public string? Descricao { get; set; }
        public int? Medico { get; set; }
        public string? Obs { get; set; }
        public int? Statusnet { get; set; }
        public int? Unidadeorigem { get; set; }
        public decimal? Codigonet { get; set; }
        public DateTime? Dtexcpres { get; set; }
        public DateTime? DtexcpresC { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Supcorp { get; set; }
        public string? Protocolo { get; set; }
        public int? Usufinal { get; set; }
        public DateTime? Datafinal { get; set; }
        public int? Presfinalizada { get; set; }
        public string? Ciclo { get; set; }
        public int? Convenio { get; set; }
        public string? Dia { get; set; }

        public virtual Profissionai? MedicoNavigation { get; set; }
        public virtual Paciente1? PacienteNavigation { get; set; }
        public virtual Login? UsufinalNavigation { get; set; }
        public virtual ICollection<ProdutosMovimentacao> ProdutosMovimentacaos { get; set; }
        public virtual ICollection<TbEntSaiProd> TbEntSaiProds { get; set; }
        public virtual ICollection<TbProdutosCobranca> TbProdutosCobrancas { get; set; }
    }
}
