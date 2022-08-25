using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class TbAtendimento
    {
        public string NrAtendimento { get; set; } = null!;
        public string CdModoEvento { get; set; } = null!;
        public DateTime DtIniAtendimento { get; set; }
        public DateTime? DtFimAtendimento { get; set; }
        public string CdPaciente { get; set; } = null!;
        public string? DsSituacaoClinica { get; set; }
        public string? InAcidente { get; set; }
        public string? UnTempoEvolucaoDoenca { get; set; }
        public string? NrTempoEvolucaoDoenca { get; set; }
        public string? InCaraterInternado { get; set; }
        public string? InTipoInternacao { get; set; }
        public string? InTipoDoenca { get; set; }
        public string? NrDeclaracaoObito { get; set; }
        public string? NrCidObito { get; set; }
        public string? InCidNotificavel { get; set; }
        public string? NrCartaoSaude { get; set; }
        public string? CdMotivoSaida { get; set; }
        public string? CdPlano { get; set; }
        public string? NrContratoOperadora { get; set; }
        public DateTime? DtIniVigenciaContrato { get; set; }
        public string? CdOperadora { get; set; }
        public string? InFinalizado { get; set; }
        public DateTime? DtFinalizado { get; set; }
        public string? CdPadraoAcomodacao { get; set; }
        public string? InCaraterAtendimento { get; set; }
    }
}
