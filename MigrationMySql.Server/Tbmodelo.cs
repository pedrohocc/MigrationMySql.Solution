using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbmodelo
    {
        public int Codmodelo { get; set; }
        public string? Descmodelo { get; set; }
        public string? Arqmodelo { get; set; }
        public string? Conteudomodelo { get; set; }
        public bool? Temp { get; set; }
    }
}
