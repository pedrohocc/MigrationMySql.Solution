using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Tbitemprescricao
    {
        public int? Codigopres { get; set; }
        public int? Produto { get; set; }
        public decimal? Qtd { get; set; }
        public string? Obs { get; set; }
        public string? Unid { get; set; }
        public int? Numgrupo { get; set; }
        public int Codigo { get; set; }
        public int? Proddilu { get; set; }
        public decimal? Qtddilu { get; set; }
        public string? Uniddilu { get; set; }
    }
}
