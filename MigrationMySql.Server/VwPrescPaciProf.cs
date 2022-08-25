using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class VwPrescPaciProf
    {
        public int Codigo { get; set; }
        public string? Protocolo { get; set; }
        public DateTime? DtexcpresC { get; set; }
        public string Nome { get; set; } = null!;
        public string? Sexo { get; set; }
        public string? Dtnasc { get; set; }
        public string? Obs { get; set; }
        public string NomeProf { get; set; } = null!;
        public string? RegProfis { get; set; }
        public string? Siglaconselho { get; set; }
        public string? UfConselho { get; set; }
        public int? IdWeb { get; set; }
        public int? Presfinalizada { get; set; }
    }
}
