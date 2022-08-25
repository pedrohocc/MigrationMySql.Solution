using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Listagem
    {
        public int Codigo { get; set; }
        public int? Mapa { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Requisicao { get; set; }
        public string? Exame { get; set; }
        public int? Folha { get; set; }
        public bool? Impresso { get; set; }
        public int? Codmapa { get; set; }
        public Guid Rowguid { get; set; }
        public decimal? CodigoColunas { get; set; }
    }
}
