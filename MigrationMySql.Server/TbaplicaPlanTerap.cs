using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbaplicaPlanTerap
    {
        public decimal? IdplanTerap { get; set; }
        public decimal IdaplicaPlanTerap { get; set; }
        public int? SeqAplicacao { get; set; }
        public DateTime? DtAplicacao { get; set; }
        public string? DescAplicacao { get; set; }
        public string? Hdaaplicacao { get; set; }
        public decimal? PesoAplica { get; set; }
        public decimal? AlturaAplica { get; set; }
        public decimal? Bsaaplica { get; set; }
        public string? Sequencia { get; set; }
        public int? FlImportado { get; set; }
    }
}
