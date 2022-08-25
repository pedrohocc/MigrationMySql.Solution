using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ConveniosFaturado
    {
        public decimal Recnum { get; set; }
        public decimal Codigo { get; set; }
        public string Nome { get; set; } = null!;
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Contato { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Tabela { get; set; }
        public decimal? Percentual { get; set; }
        public decimal? Vias { get; set; }
        public string? Arredonda { get; set; }
        public string? Indice { get; set; }
        public int? CirBiLat { get; set; }
        public int? CirMesma { get; set; }
        public int? CirDif { get; set; }
        public int? Urgen { get; set; }
        public int? Dhe { get; set; }
        public int? Apart { get; set; }
        public int? Medico { get; set; }
        public int? Clinico { get; set; }
        public string? Codesm { get; set; }
        public string? Codesm2 { get; set; }
    }
}
