using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Encaminhamento
    {
        public int Codigo { get; set; }
        public DateTime? Data { get; set; }
        public string? Descricao { get; set; }
        public int? Medico { get; set; }
        public int? Paciente { get; set; }
        public string? Destino { get; set; }
    }
}
