using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class PacientesConvenio
    {
        public decimal Recnum { get; set; }
        public int Paciente { get; set; }
        public string Convenio { get; set; } = null!;
        public string? Titular { get; set; }
        public string? Matricula { get; set; }
        public string? Dependencia { get; set; }
        public string? Validade { get; set; }
        public string? Ultimo { get; set; }
        public string? Empresa { get; set; }
        public string? Guia { get; set; }
        public int? Atualiza { get; set; }
        public string? Pacientenomeplano { get; set; }
        public int? Statusnet { get; set; }
    }
}
