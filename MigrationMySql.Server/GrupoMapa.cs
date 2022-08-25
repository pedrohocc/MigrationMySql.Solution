using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class GrupoMapa
    {
        public string? Codigo { get; set; }
        public string? Grupo { get; set; }
        public double? Porcent { get; set; }
        public string? ImpGab { get; set; }
        public string? ImpUrg { get; set; }
        public string? ImpSpc { get; set; }
        public string? ImpExm { get; set; }
        public string? ImpEtqd { get; set; }
        public string? Setor01 { get; set; }
        public string? Setor02 { get; set; }
        public string? Setor03 { get; set; }
        public double? Rotina1 { get; set; }
        public double? Rotina2 { get; set; }
        public string? Apelido { get; set; }
        public string? SaidaN { get; set; }
        public string? ImpressN { get; set; }
        public string? SaidaU { get; set; }
        public string? ImpressU { get; set; }
        public string? Cor01 { get; set; }
        public string? Cor02 { get; set; }
        public string? MedRealiz { get; set; }
        public string? TipoFat { get; set; }
        public string? Titan { get; set; }
        public Guid Rowguid { get; set; }
    }
}
