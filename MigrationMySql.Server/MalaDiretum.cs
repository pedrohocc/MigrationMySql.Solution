using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class MalaDiretum
    {
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
        public string? Dtnasc { get; set; }
        public decimal Codigo { get; set; }
        public string? Email { get; set; }
        public int? Tipologradouro { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
    }
}
