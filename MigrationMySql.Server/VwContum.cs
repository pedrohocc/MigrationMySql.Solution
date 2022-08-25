using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwContum
    {
        public string? Guiaprincipal { get; set; }
        public int? Tipoconsulta { get; set; }
        public int? Tiposaida { get; set; }
        public string? Obs { get; set; }
        public string? Cid10 { get; set; }
        public string? Autorizacao { get; set; }
        public DateTime? DtAut { get; set; }
        public decimal Medcobra { get; set; }
        public string? Descatend { get; set; }
        public DateTime? Horacheg { get; set; }
        public DateTime? Horaatend { get; set; }
        public int? TipoAtend { get; set; }
        public decimal? Conta { get; set; }
        public decimal Registro { get; set; }
        public decimal Paciente { get; set; }
        public DateTime Data { get; set; }
        public int? Codmedico { get; set; }
        public decimal Codconv { get; set; }
        public string Status { get; set; } = null!;
        public string? Operador { get; set; }
        public decimal? Fatura { get; set; }
        public string Medico { get; set; } = null!;
        public string Convenio { get; set; } = null!;
        public string? Guia { get; set; }
        public string? Matricula { get; set; }
        public int? Contratado { get; set; }
    }
}
