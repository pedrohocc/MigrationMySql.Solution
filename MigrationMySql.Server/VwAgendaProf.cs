using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwAgendaProf
    {
        public string? Dtnasc { get; set; }
        public string? Sexo { get; set; }
        public int? Tipoatend { get; set; }
        public int? Statusnet { get; set; }
        public int? IdWeb { get; set; }
        public int? Enviousms { get; set; }
        public string? Telefone2 { get; set; }
        public string Convenio { get; set; } = null!;
        public decimal Codconv { get; set; }
        public string? Telefone { get; set; }
        public decimal CodigoP { get; set; }
        public int Codigo { get; set; }
        public DateTime? Hrmarcada { get; set; }
        public int? Paciente { get; set; }
        public DateTime? Data { get; set; }
        public DateTime? HrChega { get; set; }
        public DateTime? HrAtend { get; set; }
        public string Nome { get; set; } = null!;
        public string? Tipo { get; set; }
        public string? Obs { get; set; }
        public string? Nomeprof { get; set; }
    }
}
