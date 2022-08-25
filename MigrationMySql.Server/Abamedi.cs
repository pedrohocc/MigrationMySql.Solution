using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Abamedi
    {
        public string? MedCodi { get; set; }
        public string? MedDesc { get; set; }
        public bool MedFlag { get; set; }
        public bool MedSolu { get; set; }
    }
}
