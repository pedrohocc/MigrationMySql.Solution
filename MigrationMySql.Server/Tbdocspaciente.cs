using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbdocspaciente
    {
        public int Coddoc { get; set; }
        public int? Codpaciente { get; set; }
        public int? Tipomodelo { get; set; }
        public DateTime? Dtdoc { get; set; }
        public string? Usuariodoc { get; set; }
        public string? Arqdoc { get; set; }
        public string? Descricao { get; set; }
    }
}
