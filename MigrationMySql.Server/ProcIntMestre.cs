using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProcIntMestre
    {
        public decimal? Recnum { get; set; }
        public decimal Registro { get; set; }
        public decimal Prontuario { get; set; }
        public DateTime DtMovim { get; set; }
        public decimal Procedimento { get; set; }
        public decimal? Total { get; set; }
        public decimal? QtdItens { get; set; }
        public decimal? Qtd { get; set; }
        public decimal? RegistroP { get; set; }
        public string? Tabela { get; set; }
        public decimal? TotalPago { get; set; }
        public DateTime? DtColeta { get; set; }
        public DateTime? HrColeta { get; set; }
        public bool? Urgente { get; set; }
        public bool? Faltamat { get; set; }
        public string? Guia { get; set; }
        public string? Lamina { get; set; }
        public DateTime? Dataaut { get; set; }
        public string? Autori { get; set; }
        public string? Coletador { get; set; }
        public int? Atualiza { get; set; }
        public int? Impetiq { get; set; }
        public string? Registroporigem { get; set; }
        public int? Contratado { get; set; }
        public int? FlInteira { get; set; }
    }
}
