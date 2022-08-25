using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Medico
    {
        public string Matricula { get; set; } = null!;
        public string? Nome { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Crm { get; set; }
        public int Codigo { get; set; }
        public int? Campainha { get; set; }
        public DateTime? Hrent1 { get; set; }
        public DateTime? Hrsai1 { get; set; }
        public DateTime? Hrent2 { get; set; }
        public DateTime? Hrsai2 { get; set; }
    }
}
