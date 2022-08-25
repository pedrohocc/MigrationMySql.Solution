using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Profissionai
    {
        public Profissionai()
        {
            AnamneseMastologia = new HashSet<AnamneseMastologium>();
            Prescricaos = new HashSet<Prescricao>();
        }

        public int Codigo { get; set; }
        public string Nome { get; set; } = null!;
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? RegProfis { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public decimal? VlConsulta { get; set; }
        public decimal? Producaom { get; set; }
        public decimal? Producaov { get; set; }
        public decimal? Samed { get; set; }
        public decimal? Atividades { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Online { get; set; }
        public string? Telefone2 { get; set; }
        public string? Especialidade { get; set; }
        public string? Senha { get; set; }
        public string? Sigla { get; set; }
        public string? Siglaconselho { get; set; }
        public string? UfConselho { get; set; }
        public string? Cbos { get; set; }
        public int? FlSolicitante { get; set; }
        public int? ConsultaDia { get; set; }
        public int? ProcDia { get; set; }
        public string? Cbosantigo { get; set; }
        public string? Tratamento { get; set; }
        public string? DigitoRegProfis { get; set; }
        public int? FlLivrocaixa { get; set; }
        public int? IdWeb { get; set; }
        public string? Grupo { get; set; }
        public bool? FlagMedico { get; set; }

        public virtual ICollection<AnamneseMastologium> AnamneseMastologia { get; set; }
        public virtual ICollection<Prescricao> Prescricaos { get; set; }
    }
}
