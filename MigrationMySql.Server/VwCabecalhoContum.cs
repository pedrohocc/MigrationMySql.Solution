using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwCabecalhoContum
    {
        public int? Codmedsolici { get; set; }
        public string? Siglamed { get; set; }
        public string? RegProfisSolici { get; set; }
        public string? ConsProfSolici { get; set; }
        public string? UfConselhoSolici { get; set; }
        public string Medsolici { get; set; } = null!;
        public DateTime? DtAut { get; set; }
        public int? TipoAtend { get; set; }
        public string? Sigla { get; set; }
        public decimal Codigop { get; set; }
        public string? Cpf { get; set; }
        public string? Autorizacao { get; set; }
        public decimal? Conta { get; set; }
        public DateTime Data { get; set; }
        public string Paciente { get; set; } = null!;
        public string? Guia { get; set; }
        public string? Matricula { get; set; }
        public string Nomeconv { get; set; } = null!;
        public decimal Codconv { get; set; }
        public decimal? Fatura { get; set; }
        public decimal Registro { get; set; }
        public string? Guiaprincipal { get; set; }
    }
}
