using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class RecepcaoMestre
    {
        public decimal? Recnum { get; set; }
        public decimal Registro { get; set; }
        public decimal Paciente { get; set; }
        public DateTime Data { get; set; }
        public decimal Medico { get; set; }
        public decimal Convenio { get; set; }
        public string Status { get; set; } = null!;
        public string? Operador { get; set; }
        public string? Guia { get; set; }
        public decimal? Fatura { get; set; }
        public int? TipoAtend { get; set; }
        public DateTime? HoraCheg { get; set; }
        public DateTime? HoraAtend { get; set; }
        public decimal? Conta { get; set; }
        public int? Medatend { get; set; }
        public string? Autorizacao { get; set; }
        public DateTime? DtAut { get; set; }
        public string? PkLegada { get; set; }
        public int? Tempodoenca { get; set; }
        public string? Unidadetempo { get; set; }
        public int? Tipoconsulta { get; set; }
        public int? Tiposaida { get; set; }
        public string? Obs { get; set; }
        public string? Cid10 { get; set; }
        public string? Guiaprincipal { get; set; }
        public int? Contratado { get; set; }
        public DateTime? Dataok { get; set; }
        public int? Statusnet { get; set; }
        public string? Obsagenda { get; set; }
        public int? CodigoRepasse { get; set; }
        public bool FlOnline { get; set; }
        public int? Prescricao { get; set; }
        public int? Repasseprod { get; set; }
        public int? Repasseserv { get; set; }
        public int? TipoFat { get; set; }
    }
}
