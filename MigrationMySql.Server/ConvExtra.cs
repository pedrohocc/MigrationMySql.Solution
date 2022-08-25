using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ConvExtra
    {
        public decimal Convenio { get; set; }
        public string? Tabela1 { get; set; }
        public string? Tabela2 { get; set; }
        public string? Tabela3 { get; set; }
        public string? Tabela4 { get; set; }
        public string? Indice1 { get; set; }
        public string? Indice2 { get; set; }
        public string? Indice3 { get; set; }
        public string? Indice4 { get; set; }
        public decimal? HorarioI { get; set; }
        public decimal? HorarioF { get; set; }
        public string? Planilha { get; set; }
        public decimal? DiasRetorno { get; set; }
        public decimal? IndiceP { get; set; }
        public decimal? IndiceF { get; set; }
        public decimal? IndiceS { get; set; }
        public string? Programa { get; set; }
        public string? Urgencia { get; set; }
        public string? C03s { get; set; }
        public string? Situacao { get; set; }
        public string? HrEmIni { get; set; }
        public string? HrEmFim { get; set; }
        public string? Matmed1 { get; set; }
        public int? Contasfatura { get; set; }
        public int? Recnum { get; set; }
        public int Cod { get; set; }
        public string? Nomeplano { get; set; }
        public string? RegAns { get; set; }
        public string? Cnes { get; set; }
        public decimal? Honorarios1 { get; set; }
        public decimal? Honorarios2 { get; set; }
        public int? FlTotmatmed { get; set; }
        public int? CodMat { get; set; }
        public int? CodMed { get; set; }
    }
}
