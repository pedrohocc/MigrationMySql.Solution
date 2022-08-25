using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Posto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Endereço { get; set; }
        public bool Padrao { get; set; }
        public Guid Rowguid { get; set; }
    }
}
