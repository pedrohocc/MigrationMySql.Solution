using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class Paciente1
    {
        public Paciente1()
        {
            Prescricaos = new HashSet<Prescricao>();
            TbEntSaiProds = new HashSet<TbEntSaiProd>();
        }

        public decimal? Recnum { get; set; }
        public string Nome { get; set; } = null!;
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Sexo { get; set; }
        public string? Bairro { get; set; }
        public string? Convenio { get; set; }
        public string? Cep { get; set; }
        public string? Telefone { get; set; }
        public string? Rg { get; set; }
        public string? Ocupacao { get; set; }
        public string? ComplEnd { get; set; }
        public string? Responsavel { get; set; }
        public string? Pai { get; set; }
        public string? Mae { get; set; }
        public string? Endresp { get; set; }
        public string? Foneresp { get; set; }
        public string? Numero { get; set; }
        public decimal CodigoP { get; set; }
        public string? Dtnasc { get; set; }
        public decimal Codigo { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
        public string? Gsang { get; set; }
        public string? Fatorrh { get; set; }
        public string? Fatirdu { get; set; }
        public string? Email { get; set; }
        public string? Fatordu { get; set; }
        public int? Atualiza { get; set; }
        public int? Tipologradouro { get; set; }
        public string? Telefone2 { get; set; }
        public string? Codigolegado { get; set; }
        public int? Statuscarteira { get; set; }
        public DateTime? Dtobito { get; set; }
        public string? Cpf { get; set; }
        public int? Statusnet { get; set; }
        public int? FlImportado { get; set; }
        public int? Unidade { get; set; }

        public virtual ICollection<Prescricao> Prescricaos { get; set; }
        public virtual ICollection<TbEntSaiProd> TbEntSaiProds { get; set; }
    }
}
