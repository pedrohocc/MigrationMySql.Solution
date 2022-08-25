using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Planvisual
    {
        public double? Codigo { get; set; }
        public string? Convênio { get; set; }
        public double? Conta { get; set; }
        public string? Paciente { get; set; }
        public DateTime? Data { get; set; }
        public string? Matricula { get; set; }
        public string? Plano { get; set; }
        public string? Autorizacao { get; set; }
        public string? Principal { get; set; }
        public string? Guia { get; set; }
        public string? Procedimento { get; set; }
        public string? Valor { get; set; }
    }
}
