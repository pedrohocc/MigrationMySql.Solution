using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Paciente
    {
        public string? CodPaciente { get; set; }
        public string? Nome { get; set; }
        public string? DtNascimento { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }
        public string? Endereco { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }
        public string? Fone { get; set; }
        public string? Naturalidade { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? FoneAdicional { get; set; }
        public int? Flimportado { get; set; }
    }
}
