using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ProfissionaisExtra
    {
        public decimal Medico { get; set; }
        public string? Atende { get; set; }
        public string? Tipoa { get; set; }
        public decimal? Taxaa { get; set; }
        public string? Tipoi { get; set; }
        public decimal? Taxai { get; set; }
        public decimal? C01n { get; set; }
        public decimal? C02n { get; set; }
        public decimal? C03n { get; set; }
        public string? C01s { get; set; }
        public string? C02s { get; set; }
        public decimal? C01i { get; set; }
        public decimal? Co2i { get; set; }
        public decimal? C03i { get; set; }
    }
}
