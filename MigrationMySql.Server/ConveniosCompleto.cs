using System;
using System.Collections.Generic;

namespace MigrationMySql.Server
{
    public partial class ConveniosCompleto
    {
        public string? Nome { get; set; }
        public string? RazãoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? NºRegistroAns { get; set; }
        public string? Cnpj { get; set; }
        public string? Logradouro { get; set; }
        public double? Número { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public double? Cep { get; set; }
        public double? Ddd { get; set; }
        public double? Telefone { get; set; }
        public double? Fax { get; set; }
        public string? EndereçoEletrônico { get; set; }
    }
}
