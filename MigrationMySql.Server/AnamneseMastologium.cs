using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class AnamneseMastologium
    {
        public int Codigo { get; set; }
        public DateTime? Data { get; set; }
        public int? Profissional { get; set; }
        public string? Procedencia { get; set; }
        public string? QueixasPrincipais { get; set; }
        public string? Menarca { get; set; }
        public string? Ciclos { get; set; }
        public string? UltimaMenstruacao { get; set; }
        public string? Dismenorreia { get; set; }
        public string? Gestacoes { get; set; }
        public string? Para { get; set; }
        public string? Abortos { get; set; }
        public string? Cesareas { get; set; }
        public string? PartosNormais { get; set; }
        public string? UltimoParto { get; set; }
        public string? ApUrinario { get; set; }
        public string? Obesidade { get; set; }
        public string? Acne { get; set; }
        public string? Hirsutismo { get; set; }
        public string? PressaoArterial { get; set; }
        public string? Peso { get; set; }
        public string? MedicamentosUso { get; set; }
        public string? Amamentacoes { get; set; }
        public string? Tempo { get; set; }
        public string? ExameMamaDir { get; set; }
        public string? ExameMamaEsq { get; set; }
        public string? ExameGineco { get; set; }
        public decimal? Paciente { get; set; }
        public string? AntecePesEciru { get; set; }

        public virtual Profissionai? ProfissionalNavigation { get; set; }
    }
}
