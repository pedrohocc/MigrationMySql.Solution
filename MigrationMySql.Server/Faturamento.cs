using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Faturamento
    {
        public Faturamento()
        {
            FaturamentoPagas = new HashSet<FaturamentoPaga>();
        }

        public int Codigo { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? Vencimento { get; set; }
        public string? Convenio { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public decimal? Cobrado { get; set; }
        public decimal? Glosado { get; set; }
        public decimal? Pago { get; set; }
        public DateTime? DataPg { get; set; }
        public int? Status { get; set; }
        public int? Fatura { get; set; }
        public string? Mesref { get; set; }
        public string? Obs { get; set; }
        public string? Nf { get; set; }
        public decimal? Vlimpostos { get; set; }
        public DateTime? Dtcobranca { get; set; }
        public DateTime? DataNf { get; set; }
        public decimal ValorRecursado { get; set; }
        public decimal ValorRecursadoPago { get; set; }

        public virtual ICollection<FaturamentoPaga> FaturamentoPagas { get; set; }
    }
}
