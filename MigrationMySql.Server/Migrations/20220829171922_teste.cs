using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationMySql.Server.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "874_medicamentos",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col006 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col007 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col008 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col009 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col010 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col011 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col012 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col013 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col014 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col015 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col016 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "874_medicamentos_PF",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col006 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col007 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col008 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col009 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col010 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col011 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col012 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col013 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col014 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col015 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col016 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "874_medicamentos_RH",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col006 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col007 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col008 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col009 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col010 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col011 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col012 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col013 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col014 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col015 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col016 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABAAPRE",
                columns: table => new
                {
                    APR_CODI = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    APR_DESC = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    APR_FLAG = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    APR_QTDE = table.Column<double>(type: "double", nullable: true),
                    APR_IPI = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABAMEDI",
                columns: table => new
                {
                    MED_CODI = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MED_DESC = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MED_FLAG = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MED_SOLU = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABAPREC",
                columns: table => new
                {
                    PRE_MEDI = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_LABO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_APRE = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_PREC = table.Column<double>(type: "double", nullable: true),
                    PRE_IPI = table.Column<double>(type: "double", nullable: true),
                    PRE_FLAG = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PRE_DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRE_EDIS = table.Column<double>(type: "double", nullable: true),
                    PRE_PORT = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_GENE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_EXCE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_EX1 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PRE_EX3 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX4 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX5 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX6 = table.Column<double>(type: "double", nullable: true),
                    PRE_TIPO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_REV1 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV2 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV3 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV4 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV5 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV6 = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABAPREM",
                columns: table => new
                {
                    PRE_MEDI = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_LABO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_APRE = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_PREC = table.Column<double>(type: "double", nullable: true),
                    PRE_IPI = table.Column<double>(type: "double", nullable: true),
                    PRE_FLAG = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PRE_DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    PRE_EDIS = table.Column<double>(type: "double", nullable: true),
                    PRE_PORT = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_GENE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_EXCE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_EX1 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX2 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX3 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX4 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX5 = table.Column<double>(type: "double", nullable: true),
                    PRE_EX6 = table.Column<double>(type: "double", nullable: true),
                    PRE_TIPO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRE_REV1 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV2 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV3 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV4 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV5 = table.Column<double>(type: "double", nullable: true),
                    PRE_REV6 = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AjusteEstoque",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataFinalizacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Validado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CodigoValidacao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AjusteEs__06370DAD0969FB88", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AnaDin",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "atualizacao",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    unidade = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataini = table.Column<DateTime>(type: "datetime", nullable: true),
                    datafim = table.Column<DateTime>(type: "datetime", nullable: true),
                    segundos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CADMED",
                columns: table => new
                {
                    NUMUNIM = table.Column<string>(name: "NUM UNIM", type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIGLAMED = table.Column<string>(name: "SIGLA MED", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODMED = table.Column<string>(name: "COD MED", type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MEDIC = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MÉDICO = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MÉDRELATUNIMED = table.Column<string>(name: "MÉD RELAT UNIMED", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CRM = table.Column<int>(type: "int", nullable: true),
                    COBRANESTVL = table.Column<int>(name: "COBR ANEST VL", type: "int", nullable: true),
                    FATORRELAT = table.Column<int>(name: "FATOR RELAT", type: "int", nullable: true),
                    IMPUNIMEDXXX = table.Column<float>(name: "IMP UNIMEDXXX", type: "float", nullable: true),
                    LIOAUX = table.Column<float>(name: "LIO AUX", type: "float", nullable: true),
                    DESCPARTIC = table.Column<float>(name: "DESC PARTIC", type: "float", nullable: true),
                    DESCONTO = table.Column<float>(type: "float", nullable: true),
                    FONERES = table.Column<string>(name: "FONE(RES)", type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FONECEL = table.Column<string>(name: "FONE (CEL)", type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    END = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PGLIO = table.Column<float>(name: "PG LIO", type: "float", nullable: true),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    desc_prod = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Picture = table.Column<byte[]>(type: "blob", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cc_clientes",
                columns: table => new
                {
                    data = table.Column<DateTime>(type: "datetime", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    forma = table.Column<int>(type: "int", nullable: true),
                    observacao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    operador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    conta = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    atualiza = table.Column<int>(type: "int", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cid10",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flativo = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CONSULT",
                columns: table => new
                {
                    NOME = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FONE = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CAT = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contratados",
                columns: table => new
                {
                    convenio = table.Column<int>(type: "int", nullable: true),
                    codigonoconvenio = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnes = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    unidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flinterno = table.Column<int>(type: "int", nullable: true),
                    faturaclinica = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CONTROLE CONSULTORIO",
                columns: table => new
                {
                    VALIDCART = table.Column<string>(name: "VALID CART", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DTEMISSGUIA = table.Column<string>(name: "DT EMISS GUIA", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GUIAPRINCIPAL = table.Column<string>(name: "GUIA PRINCIPAL", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PLANO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NGUIA = table.Column<string>(name: "N GUIA", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DTAUTORIZ = table.Column<DateTime>(name: "DT AUTORIZ", type: "datetime", nullable: true),
                    AUTORIZ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    PACIENTE = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MES = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATALANÇAM = table.Column<DateTime>(name: "DATA LANÇAM", type: "datetime", nullable: true),
                    SIGLAPROCED = table.Column<string>(name: "SIGLA PROCED", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OLHO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QTDE = table.Column<int>(type: "int", nullable: true),
                    QTDEUCO = table.Column<float>(name: "QTDE UCO", type: "float", nullable: true),
                    SIGLAMÉD = table.Column<string>(name: "SIGLA MÉD", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONVENIO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ANESTESISTA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALORANEST = table.Column<float>(name: "VALOR ANEST", type: "float", nullable: true),
                    NUM = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NTITULAR = table.Column<string>(name: "N TITULAR", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UNIMPAC = table.Column<string>(name: "UNIM PAC", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CÓDPROCED = table.Column<string>(name: "CÓD PROCED", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MÉDSOLICITANTE = table.Column<string>(name: "MÉD SOLICITANTE", type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IDADE = table.Column<float>(type: "float", nullable: true),
                    VALORPT = table.Column<float>(name: "VALOR PT", type: "float", nullable: true),
                    FORMAPGTO = table.Column<string>(name: "FORMA PGTO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODJUSTIF = table.Column<string>(name: "COD JUSTIF", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OBS = table.Column<string>(name: "OBS:", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INTERC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LOTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UNIMEDMAT = table.Column<float>(name: "UNIMED MAT", type: "float", nullable: true),
                    UNIMEDFILME = table.Column<float>(name: "UNIMED FILME", type: "float", nullable: true),
                    CODUSUDEP = table.Column<string>(name: "COD USU DEP", type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODUSUDIG = table.Column<string>(name: "COD USU DIG", type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    N_REC = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATAUNIMED = table.Column<string>(name: "DATA UNIMED", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Controle_Interface",
                columns: table => new
                {
                    P_Saida = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    P_Entrada = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    T_Atua = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Conv_Extra",
                columns: table => new
                {
                    CONVENIO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    TABELA1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HORARIO_I = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    HORARIO_F = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    PLANILHA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DIAS_RETORNO = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    INDICE_P = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    INDICE_F = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    INDICE_S = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    PROGRAMA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URGENCIA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C03S = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SITUACAO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmIni = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmFim = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Matmed1 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contasfatura = table.Column<int>(type: "int", nullable: true),
                    recnum = table.Column<int>(type: "int", nullable: true),
                    cod = table.Column<int>(type: "int", nullable: false),
                    nomeplano = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    reg_ans = table.Column<string>(type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnes = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    honorarios1 = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    honorarios2 = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    fl_totmatmed = table.Column<int>(type: "int", nullable: true),
                    cod_mat = table.Column<int>(type: "int", nullable: true),
                    cod_med = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "conv_extra_faturados",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    TABELA1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HORARIO_I = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    HORARIO_F = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    PLANILHA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DIAS_RETORNO = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    INDICE_P = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    INDICE_F = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    INDICE_S = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    PROGRAMA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C03S = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SITUACAO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmIni = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmFim = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Matmed1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "conv_extra_ultimo",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    TABELA1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE4 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HORARIO_I = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    HORARIO_F = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    PLANILHA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DIAS_RETORNO = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    INDICE_P = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    INDICE_F = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    INDICE_S = table.Column<decimal>(type: "numeric(10,4)", nullable: true),
                    PROGRAMA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URGENCIA = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C03S = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SITUACAO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmIni = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HrEmFim = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Matmed1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "convenios",
                columns: table => new
                {
                    CODIGO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTATO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ESTADO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PERCENTUAL = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    VIAS = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    ARREDONDA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CirBiLat = table.Column<int>(type: "int", nullable: true),
                    CirMesma = table.Column<int>(type: "int", nullable: true),
                    CirDif = table.Column<int>(type: "int", nullable: true),
                    Urgen = table.Column<int>(type: "int", nullable: true),
                    DHE = table.Column<int>(type: "int", nullable: true),
                    Apart = table.Column<int>(type: "int", nullable: true),
                    Medico = table.Column<int>(type: "int", nullable: true),
                    Clinico = table.Column<int>(type: "int", nullable: true),
                    codesm = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RAZAOSOCIAL = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OBS = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_compmatricula = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigoTerceiro = table.Column<int>(type: "int", nullable: true),
                    taxaImposto = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "convenios_completo",
                columns: table => new
                {
                    NOME = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RAZÃOSOCIAL = table.Column<string>(name: "RAZÃO SOCIAL", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NOMEFANTASIA = table.Column<string>(name: "NOME FANTASIA", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NºREGISTROANS = table.Column<string>(name: "Nº REGISTRO ANS", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LOGRADOURO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NÚMERO = table.Column<double>(type: "double", nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<double>(type: "double", nullable: true),
                    DDD = table.Column<double>(type: "double", nullable: true),
                    TELEFONE = table.Column<double>(type: "double", nullable: true),
                    FAX = table.Column<double>(type: "double", nullable: true),
                    ENDEREÇOELETRÔNICO = table.Column<string>(name: "ENDEREÇO ELETRÔNICO", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "convenios_faturados",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: false),
                    CODIGO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTATO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ESTADO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PERCENTUAL = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    VIAS = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    ARREDONDA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CirBiLat = table.Column<int>(type: "int", nullable: true),
                    CirMesma = table.Column<int>(type: "int", nullable: true),
                    CirDif = table.Column<int>(type: "int", nullable: true),
                    Urgen = table.Column<int>(type: "int", nullable: true),
                    DHE = table.Column<int>(type: "int", nullable: true),
                    Apart = table.Column<int>(type: "int", nullable: true),
                    Medico = table.Column<int>(type: "int", nullable: true),
                    Clinico = table.Column<int>(type: "int", nullable: true),
                    codesm = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codesm2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "convenios_ultimo",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: false),
                    CODIGO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    NOME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTATO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ESTADO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TABELA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PERCENTUAL = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    VIAS = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    ARREDONDA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CirBiLat = table.Column<int>(type: "int", nullable: true),
                    CirMesma = table.Column<int>(type: "int", nullable: true),
                    CirDif = table.Column<int>(type: "int", nullable: true),
                    Urgen = table.Column<int>(type: "int", nullable: true),
                    DHE = table.Column<int>(type: "int", nullable: true),
                    Apart = table.Column<int>(type: "int", nullable: true),
                    Medico = table.Column<int>(type: "int", nullable: true),
                    Clinico = table.Column<int>(type: "int", nullable: true),
                    codesm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactTitle = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fax = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitleOfCourtesy = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Address = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HomePhone = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Extension = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<byte[]>(type: "blob", nullable: true),
                    Notes = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReportsTo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Encaminhamento",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Medico = table.Column<int>(type: "int", nullable: true),
                    Paciente = table.Column<int>(type: "int", nullable: true),
                    Destino = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "entrada_e_saida",
                columns: table => new
                {
                    cod = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "exames_bloqueados",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    exame = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Faturamento",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Vencimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    Convenio = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    Fim = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cobrado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Glosado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pago = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DataPg = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Fatura = table.Column<int>(type: "int", nullable: true),
                    mesref = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obs = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nf = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    vlimpostos = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    dtcobranca = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataNF = table.Column<DateTime>(type: "datetime", nullable: true),
                    ValorRecursado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorRecursadoPago = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faturamento", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Feriados",
                columns: table => new
                {
                    Data = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descrição = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formas",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GRADE",
                columns: table => new
                {
                    GRADE = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SETOR = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NOME = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TAMTOTAL = table.Column<double>(type: "double", nullable: true),
                    CABFIXO = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IMP_GRADE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TAMCOLS = table.Column<double>(type: "double", nullable: true),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GRADECOL",
                columns: table => new
                {
                    GRADE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EXAME = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ORDEM = table.Column<double>(type: "double", nullable: true),
                    TAMANHO = table.Column<double>(type: "double", nullable: true),
                    CODGRADE = table.Column<int>(type: "int", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GRADESEL",
                columns: table => new
                {
                    ESTACAO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GRADE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMPRIME = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "grupo_exame",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    setor = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "grupo_mapa",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GRUPO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PORCENT = table.Column<double>(type: "double", nullable: true),
                    IMP_GAB = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMP_URG = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMP_SPC = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMP_EXM = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMP_ETQD = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SETOR01 = table.Column<string>(type: "varchar(130)", unicode: false, maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SETOR02 = table.Column<string>(type: "varchar(130)", unicode: false, maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SETOR03 = table.Column<string>(type: "varchar(130)", unicode: false, maxLength: 130, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ROTINA1 = table.Column<double>(type: "double", nullable: true),
                    ROTINA2 = table.Column<double>(type: "double", nullable: true),
                    APELIDO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SAIDA_N = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMPRESS_N = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SAIDA_U = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMPRESS_U = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COR01 = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COR02 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MED_REALIZ = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPO_FAT = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TITAN = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "grupos_produtos",
                columns: table => new
                {
                    id_grupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descricao_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grupos_produtos", x => x.id_grupo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GUARDA",
                columns: table => new
                {
                    CODIGO = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOME = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TRACE = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "histdoctors0",
                columns: table => new
                {
                    CodPaciente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataConsulta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atributo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodMedico = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Historico = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "histdoctors2",
                columns: table => new
                {
                    CodPaciente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataConsulta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atributo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodMedico = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Historico = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HISTORIC",
                columns: table => new
                {
                    CodPaciente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataConsulta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atributo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodMedico = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Historico = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kits",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obskit = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Flag = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kits_Itens",
                columns: table => new
                {
                    Kit = table.Column<int>(type: "int", nullable: true),
                    Qtd = table.Column<int>(type: "int", nullable: true),
                    PROCEDIMENTO = table.Column<int>(type: "int", nullable: true),
                    PRODUTO = table.Column<int>(type: "int", nullable: true),
                    proddilu = table.Column<int>(type: "int", nullable: true),
                    qtddilu = table.Column<int>(type: "int", nullable: true),
                    obs = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iditem = table.Column<decimal>(type: "decimal(12,0)", nullable: false),
                    unid = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordem = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kits_Proc",
                columns: table => new
                {
                    codkitproc = table.Column<int>(type: "int", nullable: false),
                    Desckitproc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    histclinkit = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidkit = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tabelakit = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Leitos",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UNID_INTERNACAO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    PRONTUARIO = table.Column<decimal>(type: "decimal(6,0)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "listagem",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    mapa = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime", nullable: true),
                    requisicao = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    exame = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folha = table.Column<int>(type: "int", nullable: true),
                    impresso = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    codmapa = table.Column<int>(type: "int", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CODIGO_COLUNAS = table.Column<decimal>(type: "decimal(12,0)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "log",
                columns: table => new
                {
                    usuario = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hora = table.Column<DateTime>(type: "datetime", nullable: true),
                    CONTA = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    codigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "logBD",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    BD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    inicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    fim = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Grupo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeCompleto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo_Usuario = table.Column<int>(type: "int", nullable: true),
                    Ultimo_Acesso = table.Column<DateTime>(type: "datetime", nullable: true),
                    fl_livrocaixa = table.Column<int>(type: "int", nullable: true),
                    reg_profis = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF_conselho = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    siglaconselho = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "logINT",
                columns: table => new
                {
                    descricao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hora = table.Column<DateTime>(type: "datetime", nullable: true),
                    CONTA = table.Column<decimal>(type: "decimal(12,0)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MalaDireta",
                columns: table => new
                {
                    NOME = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SEXO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONVENIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OCUPACAO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COMPL_END = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RESPONSAVEL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PAI = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MAE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDRESP = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FONERESP = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DTNASC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODIGO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipologradouro = table.Column<int>(type: "int", nullable: true),
                    tel1 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tel2 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tel3 = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MAPA_ESPEC",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mapaadm",
                columns: table => new
                {
                    requisicao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idade = table.Column<int>(type: "int", nullable: true),
                    dtcoleta = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hrcoleta = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result3 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result4 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result5 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    result6 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mapas",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: true),
                    descricao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mat_Med_Unimed",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col006 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col007 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "materiais",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    descricao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "matmed",
                columns: table => new
                {
                    Código = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DV = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descrição = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeComercial = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fabricante = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compra = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantidade = table.Column<double>(type: "double", nullable: true),
                    Embalagem = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fração = table.Column<double>(type: "double", nullable: true),
                    Especi = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fracionar = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrupodeEstoque = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReutilizaçãoGenérico = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantidade1 = table.Column<double>(type: "double", nullable: true),
                    CódigodeBarra = table.Column<double>(type: "double", nullable: true),
                    MinistériodaSaúde = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Validade = table.Column<DateTime>(type: "datetime", nullable: true),
                    Simpro = table.Column<double>(type: "double", nullable: true),
                    Preço = table.Column<double>(type: "double", nullable: true),
                    Unidade = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Origem = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TabUd = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Situação = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Motivo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    Inclusão = table.Column<DateTime>(type: "datetime", nullable: true),
                    Alteração = table.Column<DateTime>(type: "datetime", nullable: true),
                    Nacional = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "matmedunimed",
                columns: table => new
                {
                    Código = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NomeComercial = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preço = table.Column<decimal>(type: "numeric(18,2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Med_Amb_Itens",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    REGISTRO = table.Column<int>(type: "int", nullable: false),
                    PRODUTO = table.Column<int>(type: "int", nullable: false),
                    QTD = table.Column<float>(type: "float", nullable: true),
                    PR_UNIT = table.Column<float>(type: "float", nullable: true),
                    item = table.Column<int>(type: "int", nullable: true),
                    operador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qtdUtilizada = table.Column<int>(type: "int", nullable: true),
                    custoUnitario = table.Column<decimal>(type: "decimal(14,2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Med_Amb_Mestre",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    POSTO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    DT_MOVIM = table.Column<DateTime>(type: "datetime", nullable: false),
                    PRONTUARIO = table.Column<decimal>(type: "decimal(12,0)", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QTD_ITENS = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    RegistroP = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Total = table.Column<float>(type: "float(10, 2)", nullable: true),
                    TotalPago = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    operador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_inteira = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Med_Int_Itens",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<int>(type: "int", nullable: false),
                    ITEM = table.Column<int>(type: "int", nullable: true),
                    PRODUTO = table.Column<int>(type: "int", nullable: false),
                    QTD = table.Column<decimal>(type: "numeric(9,2)", nullable: true),
                    PR_UNIT = table.Column<float>(type: "float", nullable: true),
                    operador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Med_Int_Mestre",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    POSTO = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    DT_MOVIM = table.Column<DateTime>(type: "datetime", nullable: false),
                    PRONTUARIO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    OBSERVACAO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QTD_ITENS = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    RegistroP = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Requisicao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Total = table.Column<float>(type: "float(10, 2)", nullable: true),
                    TotalPago = table.Column<float>(type: "float(10, 2)", nullable: true),
                    operador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_inteira = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MEDIC",
                columns: table => new
                {
                    Col001 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col003 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005 = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Matricula = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeCompleto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CRM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    CAMPAINHA = table.Column<int>(type: "int", nullable: true),
                    hrent1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    hrsai1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    hrent2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    hrsai2 = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modificacoes",
                columns: table => new
                {
                    Codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    Tabela = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usuario = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "movimentacao",
                columns: table => new
                {
                    banco = table.Column<int>(type: "int", nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime", nullable: true),
                    valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order Details",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    Quantity = table.Column<short>(type: "smallint", nullable: false),
                    Discount = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => new { x.OrderID, x.ProductID });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployeeID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RequiredDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShippedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShipVia = table.Column<int>(type: "int", nullable: true),
                    Freight = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    ShipName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipAddress = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipCity = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipRegion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipPostalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShipCountry = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PACIENTE",
                columns: table => new
                {
                    CodPaciente = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DtNascimento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCivil = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Naturalidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pai = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mae = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FoneAdicional = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flimportado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    CodigoP = table.Column<float>(type: "float(10, 2)", nullable: false),
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    NOME = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SEXO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONVENIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OCUPACAO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COMPL_END = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RESPONSAVEL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PAI = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MAE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDRESP = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FONERESP = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NUMERO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DTNASC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODIGO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    peso = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    altura = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    gsang = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fatorrh = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fatirdu = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fatordu = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualiza = table.Column<int>(type: "int", nullable: true),
                    tipologradouro = table.Column<int>(type: "int", nullable: true),
                    telefone2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigolegado = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statuscarteira = table.Column<int>(type: "int", nullable: true),
                    dtobito = table.Column<DateTime>(type: "datetime", nullable: true),
                    cpf = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statusnet = table.Column<int>(type: "int", nullable: true),
                    fl_importado = table.Column<int>(type: "int", nullable: true),
                    UNIDADE = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paciente__86EBD4961BDF3B0D", x => x.CodigoP);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pacientes_Convenios",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    PACIENTE = table.Column<int>(type: "int", nullable: false),
                    CONVENIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TITULAR = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MATRICULA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DEPENDENCIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALIDADE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ULTIMO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EMPRESA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GUIA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    atualiza = table.Column<int>(type: "int", nullable: true),
                    pacientenomeplano = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statusnet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pacientes_Extra",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    PACIENTE = table.Column<int>(type: "int", nullable: false),
                    OCUPACAO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ECIVIL = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NACIONAL = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NATURAL = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PAI = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MAE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RESPONSAVEL = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDRESP = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OBSERVACAO = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plan1$",
                columns: table => new
                {
                    CODIGO = table.Column<double>(type: "double", nullable: true),
                    CONVÊNIO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTA = table.Column<double>(type: "double", nullable: true),
                    PACIENTE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA = table.Column<double>(type: "double", nullable: true),
                    PLANO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AUTORIZACAO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRINCIPAL = table.Column<double>(type: "double", nullable: true),
                    GUIA = table.Column<double>(type: "double", nullable: true),
                    PROCEDIMENTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "planvisual",
                columns: table => new
                {
                    CODIGO = table.Column<double>(type: "double", nullable: true),
                    CONVÊNIO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONTA = table.Column<double>(type: "double", nullable: true),
                    PACIENTE = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: true),
                    MATRICULA = table.Column<string>(type: "varchar(53)", unicode: false, maxLength: 53, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PLANO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AUTORIZACAO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRINCIPAL = table.Column<string>(type: "varchar(53)", unicode: false, maxLength: 53, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GUIA = table.Column<string>(type: "varchar(53)", unicode: false, maxLength: 53, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PROCEDIMENTO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VALOR = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Postos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeCompleto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereço = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Padrao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proc_Amb_Itens",
                columns: table => new
                {
                    RECNUM = table.Column<float>(type: "float(10, 2)", nullable: false),
                    REGISTRO = table.Column<float>(type: "float(10, 2)", nullable: false),
                    ITEM = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    TIPO = table.Column<decimal>(type: "decimal(2,0)", nullable: false),
                    PROFISSIONAL = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    VL_UNIT = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    PERCENTUAL = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    statusnet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proc_Amb_Mestre",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<float>(type: "float(10, 2)", nullable: false),
                    PRONTUARIO = table.Column<float>(type: "float(10, 2)", nullable: false),
                    DT_MOVIM = table.Column<DateTime>(type: "datetime", nullable: false),
                    PROCEDIMENTO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    QTD_ITENS = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    QTD = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    TABELA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistroP = table.Column<float>(type: "float(10, 2)", nullable: true),
                    TotalPago = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    hr_inicio = table.Column<DateTime>(type: "datetime", nullable: true),
                    hr_fim = table.Column<DateTime>(type: "datetime", nullable: true),
                    via = table.Column<int>(type: "int", nullable: true),
                    tecnica = table.Column<int>(type: "int", nullable: true),
                    reducaoacrescimo = table.Column<float>(type: "float(10, 2)", nullable: true),
                    fl_sit = table.Column<int>(type: "int", nullable: true),
                    contratado = table.Column<int>(type: "int", nullable: true),
                    fl_inteira = table.Column<int>(type: "int", nullable: true),
                    statusnet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proc_Convenios",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MASCARA = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proc_Int_Itens",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    ITEM = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    TIPO = table.Column<decimal>(type: "decimal(2,0)", nullable: false),
                    PROFISSIONAL = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    VL_UNIT = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    PERCENTUAL = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    Atualiza = table.Column<int>(type: "int", nullable: true),
                    material = table.Column<int>(type: "int", nullable: true),
                    via = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proc_Int_Mestre",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    PRONTUARIO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    DT_MOVIM = table.Column<DateTime>(type: "datetime", nullable: false),
                    PROCEDIMENTO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    QTD_ITENS = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    QTD = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    RegistroP = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Tabela = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalPago = table.Column<float>(type: "float(10, 2)", nullable: true),
                    dt_coleta = table.Column<DateTime>(type: "datetime", nullable: true),
                    hr_coleta = table.Column<DateTime>(type: "datetime", nullable: true),
                    urgente = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    faltamat = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    guia = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lamina = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataaut = table.Column<DateTime>(type: "datetime", nullable: true),
                    autori = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coletador = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atualiza = table.Column<int>(type: "int", nullable: true),
                    IMPETIQ = table.Column<int>(type: "int", nullable: true),
                    REGISTROPORIGEM = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contratado = table.Column<int>(type: "int", nullable: true),
                    fl_inteira = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "procedimentosfulllab",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: true),
                    TABELA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COD_EXT = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COD_AMB = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    DESCRI1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI2 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI3 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FILME = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    OPERACIONAL = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    HONORARIOS = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    AUXILIARES = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    LAUDO = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    VALOR = table.Column<decimal>(name: "VALOR$", type: "numeric(16,2)", nullable: true),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sigla = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    urgencia = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    dias = table.Column<int>(type: "int", nullable: true),
                    sinonimia = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preparo = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    material = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obs = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    autorizacao = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    exafatu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_amb2 = table.Column<int>(type: "int", nullable: false),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prod_Convenios",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MASCARA = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    REVENDA = table.Column<decimal>(type: "decimal(8,4)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prod_Extra",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    TABELA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRODUTO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    COD_EXT = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PRECO = table.Column<decimal>(type: "decimal(16,4)", nullable: true),
                    ULT_ALT = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    QuantityPerUnit = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnitPrice = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: true),
                    UnitsOnOrder = table.Column<short>(type: "smallint", nullable: true),
                    ReorderLevel = table.Column<short>(type: "smallint", nullable: true),
                    Discontinued = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "profissionais",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    REG_PROFIS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDERECO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BAIRRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VL_CONSULTA = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    PRODUCAOM = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    PRODUCAOV = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    SAMED = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    ATIVIDADES = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CIDADE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ESTADO = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ONLINE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TELEFONE2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ESPECIALIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sigla = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    siglaconselho = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UF_conselho = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cbos = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_solicitante = table.Column<int>(type: "int", nullable: true),
                    consulta_dia = table.Column<int>(type: "int", nullable: true),
                    proc_dia = table.Column<int>(type: "int", nullable: true),
                    cbosantigo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tratamento = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    digito_reg_profis = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_livrocaixa = table.Column<int>(type: "int", nullable: true),
                    id_web = table.Column<int>(type: "int", nullable: true),
                    grupo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    flag_medico = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profissionais", x => x.codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Profissionais_Convenios",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    MEDICO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    TIPO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "profissionais_extra",
                columns: table => new
                {
                    MEDICO = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    ATENDE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TIPOA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TAXAA = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    TIPOI = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TAXAI = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    C01N = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    C02N = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    C03N = table.Column<decimal>(type: "numeric(6,2)", nullable: true),
                    C01S = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C02S = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    C01I = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    CO2I = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    C03I = table.Column<decimal>(type: "numeric(6,0)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Qual",
                columns: table => new
                {
                    Mne = table.Column<string>(name: " Mne", type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Exame = table.Column<string>(type: "char(27)", unicode: false, fixedLength: true, maxLength: 27, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(name: "Co'digo", type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col005AGGEr = table.Column<string>(name: "Col005?,A?G??????????G?Er", type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GEr = table.Column<string>(name: "???????G?Er", type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GEr0 = table.Column<string>(name: "????G?Er", type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CoE29 = table.Column<string>(name: "Co?E29", type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RotinaACUACIDO = table.Column<string>(name: " Rotina\r\n ACU ACIDO", type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Paciente = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    Texto = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Requisitante = table.Column<int>(type: "int", nullable: true),
                    statusnet = table.Column<int>(type: "int", nullable: true),
                    unidadeorigem = table.Column<int>(type: "int", nullable: true),
                    codigonet = table.Column<float>(type: "float(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recepcao",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Paciente = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    HrChega = table.Column<DateTime>(type: "datetime", nullable: true),
                    HrAtend = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: true),
                    Medico = table.Column<int>(type: "int", nullable: true),
                    obs = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hrmarcada = table.Column<DateTime>(type: "datetime", nullable: true),
                    registrop = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    enviousms = table.Column<int>(type: "int", nullable: true),
                    statusnet = table.Column<int>(type: "int", nullable: true),
                    unidadeorigem = table.Column<int>(type: "int", nullable: true),
                    codigonet = table.Column<float>(type: "float(10, 2)", nullable: true),
                    agendaunidade = table.Column<int>(type: "int", nullable: true),
                    fl_importado = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    convenio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Recepcao__06370DAD2B8DA8C7", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recepcao_lab",
                columns: table => new
                {
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    DATA0 = table.Column<DateTime>(type: "datetime", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PACIENTE = table.Column<decimal>(type: "decimal(22,0)", nullable: true),
                    OPERADOR0 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DATA1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    HORA0 = table.Column<DateTime>(type: "datetime", nullable: true),
                    MINUTO0 = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    HORA1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    MINUTO1 = table.Column<decimal>(type: "decimal(2,0)", nullable: true),
                    OBSERVACAO = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LEITO = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OPERADOR1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GUIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FATURA = table.Column<decimal>(type: "decimal(6,0)", nullable: true),
                    UNID_INTERNACAO = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    Conta = table.Column<decimal>(type: "decimal(22,0)", nullable: true),
                    Tipo_Atend = table.Column<int>(type: "int", nullable: true),
                    peso = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    altura = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    gsang = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fatorrh = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fatirdu = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dadosclinicos = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observacoes = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    medicamentos = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nota = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    urgente = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    docinc = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    prontos = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    tipo = table.Column<int>(type: "int", nullable: true),
                    senhaonline = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    medautor = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    unidade = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Atualiza = table.Column<int>(type: "int", nullable: true),
                    posto = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    tiposaida = table.Column<int>(type: "int", nullable: true),
                    cid10 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contratado = table.Column<int>(type: "int", nullable: true),
                    autorizacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dt_aut = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipointernacao = table.Column<int>(type: "int", nullable: true),
                    carater = table.Column<int>(type: "int", nullable: true),
                    regime = table.Column<int>(type: "int", nullable: true),
                    diariassol = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    diariasaut = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    motivosaida = table.Column<int>(type: "int", nullable: true),
                    medico = table.Column<int>(type: "int", nullable: true),
                    tipo_acomodacao = table.Column<int>(type: "int", nullable: true),
                    localatend = table.Column<int>(type: "int", nullable: true),
                    codigo_repasse = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Recepcao_Mestre",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    REGISTRO = table.Column<decimal>(type: "decimal(6,0)", nullable: false),
                    PACIENTE = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    DATA = table.Column<DateTime>(type: "datetime", nullable: false),
                    MEDICO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    CONVENIO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    STATUS = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OPERADOR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GUIA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FATURA = table.Column<decimal>(type: "decimal(6,0)", nullable: true),
                    Tipo_Atend = table.Column<int>(type: "int", nullable: true),
                    HoraCheg = table.Column<DateTime>(type: "datetime", nullable: true),
                    HoraAtend = table.Column<DateTime>(type: "datetime", nullable: true),
                    Conta = table.Column<float>(type: "float(10, 2)", nullable: true),
                    medatend = table.Column<int>(type: "int", nullable: true),
                    autorizacao = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dt_aut = table.Column<DateTime>(type: "datetime", nullable: true),
                    pk_legada = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tempodoenca = table.Column<int>(type: "int", nullable: true),
                    unidadetempo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipoconsulta = table.Column<int>(type: "int", nullable: true),
                    tiposaida = table.Column<int>(type: "int", nullable: true),
                    obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cid10 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guiaprincipal = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contratado = table.Column<int>(type: "int", nullable: true),
                    dataok = table.Column<DateTime>(type: "datetime", nullable: true),
                    statusnet = table.Column<int>(type: "int", nullable: true),
                    obsagenda = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo_repasse = table.Column<int>(type: "int", nullable: true),
                    fl_online = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    prescricao = table.Column<int>(type: "int", nullable: true),
                    repasseprod = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    repasseserv = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((1))"),
                    tipo_fat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Repasse_Honor",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    fatura = table.Column<int>(type: "int", nullable: true),
                    profissional = table.Column<int>(type: "int", nullable: true),
                    Cobrado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Glosado = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Repasse = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Requisicao_Interface",
                columns: table => new
                {
                    Requisicao = table.Column<int>(type: "int", nullable: true),
                    exame = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime", nullable: true),
                    hora = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    codigo = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exame = table.Column<string>(type: "varchar(27)", unicode: false, maxLength: 27, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codimp = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordimp = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordetq = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ordetq_t = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codgrp = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codset = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codlst = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sexo = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dd = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hst1 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hst2 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hst3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fltr = table.Column<string>(type: "varchar(45)", unicode: false, maxLength: 45, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_00 = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    val_00 = table.Column<double>(type: "double", nullable: true),
                    fatmed_00 = table.Column<double>(type: "double", nullable: true),
                    mtfilm_00 = table.Column<double>(type: "double", nullable: true),
                    exm0 = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exm1 = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    exm2 = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gab0 = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gab1 = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    colheita = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    impexm = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Setor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "setor_exame",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    sigla = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    ShipperID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShipperID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STATUS",
                columns: table => new
                {
                    codigo = table.Column<decimal>(type: "decimal(8,0)", nullable: true),
                    descricao = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    interno = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rowguid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Status_Fatura",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "statuscarteira",
                columns: table => new
                {
                    idstatuscart = table.Column<int>(type: "int", nullable: true),
                    descstatuscart = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactTitle = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fax = table.Column<string>(type: "varchar(24)", unicode: false, maxLength: 24, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HomePage = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tab_Golden",
                columns: table => new
                {
                    conta = table.Column<float>(type: "float(10, 2)", nullable: true),
                    cnpj = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    controle = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo = table.Column<int>(type: "int", nullable: true),
                    urgencia = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    natureza = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_autor = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tab_Hap",
                columns: table => new
                {
                    Conta = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tab_Unimed",
                columns: table => new
                {
                    conta = table.Column<float>(type: "float(10, 2)", nullable: true),
                    matricula = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rg = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    crm = table.Column<decimal>(type: "decimal(10,0)", nullable: true),
                    guia = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tablac",
                columns: table => new
                {
                    sigla = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col002 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Exame = table.Column<string>(type: "char(27)", unicode: false, fixedLength: true, maxLength: 27, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Col004 = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Honorarios = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resto1 = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resto2 = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    resto3 = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RotinaACUACIDO = table.Column<string>(name: " Rotina\r\n ACU ACIDO", type: "char(20)", unicode: false, fixedLength: true, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_ATENDIMENTO",
                columns: table => new
                {
                    NR_ATENDIMENTO = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_PACIENTE = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_MODO_EVENTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DT_INI_ATENDIMENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    DT_FIM_ATENDIMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DS_SITUACAO_CLINICA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_ACIDENTE = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UN_TEMPO_EVOLUCAO_DOENCA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NR_TEMPO_EVOLUCAO_DOENCA = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_CARATER_INTERNADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_TIPO_INTERNACAO = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_TIPO_DOENCA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NR_DECLARACAO_OBITO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NR_CID_OBITO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_CID_NOTIFICAVEL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NR_CARTAO_SAUDE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_MOTIVO_SAIDA = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_PLANO = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NR_CONTRATO_OPERADORA = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DT_INI_VIGENCIA_CONTRATO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CD_OPERADORA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_FINALIZADO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DT_FINALIZADO = table.Column<DateTime>(type: "datetime", nullable: true),
                    CD_PADRAO_ACOMODACAO = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IN_CARATER_ATENDIMENTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATENDIMENTO", x => new { x.CD_PACIENTE, x.NR_ATENDIMENTO });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TB_MOTIVO_SAIDA_INTERNACAO",
                columns: table => new
                {
                    CD_MOTIVO_SAIDA = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NM_MOTIVO_SAIDA = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CD_TIPO_MOTIVO = table.Column<string>(type: "varchar(1)", maxLength: 1, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbAnamnese",
                columns: table => new
                {
                    codanamnese = table.Column<float>(type: "float(10, 2)", nullable: false),
                    codpaciente = table.Column<float>(type: "float(10, 2)", nullable: true),
                    identanam = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    antpess = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    antfamil = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    histatual = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hipotdiag = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estadiam = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conduta = table.Column<string>(type: "text", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBAplicaPlanTerap",
                columns: table => new
                {
                    IDPlanTerap = table.Column<float>(type: "float(10, 2)", nullable: true),
                    IDAplicaPlanTerap = table.Column<float>(type: "float(10, 2)", nullable: false),
                    SeqAplicacao = table.Column<int>(type: "int", nullable: true),
                    DtAplicacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    DescAplicacao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HDAAplicacao = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PesoAplica = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AlturaAplica = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BSAAPlica = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    sequencia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_importado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBAplicaPlanTerapItens",
                columns: table => new
                {
                    IDAplicaPlanTerap = table.Column<float>(type: "float(10, 2)", nullable: true),
                    codproduto = table.Column<float>(type: "float(10, 2)", nullable: true),
                    qtdproduto = table.Column<int>(type: "int", nullable: true),
                    qtdplaneja = table.Column<int>(type: "int", nullable: true),
                    qtddose = table.Column<int>(type: "int", nullable: true),
                    UnidadeDose = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Via = table.Column<int>(type: "int", nullable: true),
                    UnidadePlaneja = table.Column<int>(type: "int", nullable: true),
                    UnidadeAplica = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IDAPlicaPlanTerapItens = table.Column<float>(type: "float(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbConsultaProfCon",
                columns: table => new
                {
                    codigo_prof = table.Column<int>(type: "int", nullable: true),
                    convenio = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    cod_ext = table.Column<string>(type: "char(20)", fixedLength: true, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbConsultaProfConv",
                columns: table => new
                {
                    codigo_prof = table.Column<int>(type: "int", nullable: true),
                    convenio = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    cod_ext = table.Column<string>(type: "char(40)", unicode: false, fixedLength: true, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbdocspaciente",
                columns: table => new
                {
                    coddoc = table.Column<int>(type: "int", nullable: false),
                    codpaciente = table.Column<int>(type: "int", nullable: true),
                    tipomodelo = table.Column<int>(type: "int", nullable: true),
                    dtdoc = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuariodoc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    arqdoc = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descricao = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBESPECIALIDADE",
                columns: table => new
                {
                    CDESP = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    NMESP = table.Column<string>(type: "varchar(51)", unicode: false, maxLength: 51, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCESP = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CDPRDCON = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COD = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbFabricante",
                columns: table => new
                {
                    idFabricante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descFabricante = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbFabric__6E91D599202D7450", x => x.idFabricante);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbFornecedor",
                columns: table => new
                {
                    idFornecedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescFornecedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelFornecedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContatoFornecedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailFornecedor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigoTerceiro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbFornecedor", x => x.idFornecedor);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbitemprescricao",
                columns: table => new
                {
                    codigopres = table.Column<int>(type: "int", nullable: true),
                    produto = table.Column<int>(type: "int", nullable: true),
                    qtd = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unid = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numgrupo = table.Column<int>(type: "int", nullable: true),
                    codigo = table.Column<int>(type: "int", nullable: false),
                    proddilu = table.Column<int>(type: "int", nullable: true),
                    qtddilu = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    uniddilu = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tblivrocaixa",
                columns: table => new
                {
                    idmov = table.Column<int>(type: "int", nullable: false),
                    dtmov = table.Column<DateTime>(type: "datetime", nullable: true),
                    historico = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idfornecedor = table.Column<int>(type: "int", nullable: true),
                    vlmov = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    tipomov = table.Column<int>(type: "int", nullable: true),
                    fl_fechado = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbLocalEstoque",
                columns: table => new
                {
                    idLocalEstoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    local = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLocalEstoque_1", x => x.idLocalEstoque);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbmodelos",
                columns: table => new
                {
                    codmodelo = table.Column<int>(type: "int", nullable: false),
                    descmodelo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    arqmodelo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    conteudomodelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    temp = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBPlanTerap",
                columns: table => new
                {
                    IDPlanTerap = table.Column<float>(type: "float(10, 2)", nullable: false),
                    codprofissional = table.Column<int>(type: "int", nullable: true),
                    DtCriaPlan = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codpaciente = table.Column<float>(type: "float(10, 2)", nullable: true),
                    DescPlanTerap = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HDAPlanTerap = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    histclin = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cid = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    convenio = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TBPROCEDCOMP",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: true),
                    TABELA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COD_EXT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI2 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI3 = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FILME = table.Column<decimal>(type: "numeric(8,4)", nullable: true),
                    OPERACIONAL = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    HONORARIOS = table.Column<decimal>(type: "numeric(14,2)", nullable: true),
                    AUXILIARES = table.Column<decimal>(type: "numeric(2,0)", nullable: true),
                    LAUDO = table.Column<decimal>(type: "numeric(4,0)", nullable: true),
                    VALOR = table.Column<decimal>(name: "VALOR$", type: "numeric(16,2)", nullable: true),
                    INDICE = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sigla = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    urgencia = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    dias = table.Column<int>(type: "int", nullable: true),
                    sinonimia = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    preparo = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    material = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obs = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    autorizacao = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    exafatu = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cod_amb2 = table.Column<int>(type: "int", nullable: true),
                    cod_amb = table.Column<int>(type: "int", nullable: false),
                    codigotabelatiss = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cdesp = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    cod_relacionado = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fl_textocomp = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    fatorqtd2 = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    inativo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    codtipoato = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbprofcontratado",
                columns: table => new
                {
                    idprof = table.Column<int>(type: "int", nullable: false),
                    idcontratado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbProfConvRepasse",
                columns: table => new
                {
                    idProfConvRepasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codprof = table.Column<int>(type: "int", nullable: false),
                    convenio = table.Column<int>(type: "int", nullable: false),
                    vlrepasse = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbProfCo__6E66719CC976522A", x => x.idProfConvRepasse);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbprofdia",
                columns: table => new
                {
                    idprofdia = table.Column<int>(type: "int", nullable: false),
                    codprof = table.Column<int>(type: "int", nullable: true),
                    dtagenda = table.Column<DateTime>(type: "datetime", nullable: true),
                    obsprofdia = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    intervalo = table.Column<int>(type: "int", nullable: true),
                    usuprofdia = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sematendimento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbprofrepasse",
                columns: table => new
                {
                    MEDICO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SIGLA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CODIGO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbRepasse",
                columns: table => new
                {
                    cod_repasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data_repasse = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    custo_total = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    total_pago = table.Column<decimal>(type: "decimal(14,2)", nullable: true),
                    repasse_total = table.Column<decimal>(type: "decimal(14,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbRepass__190EAF4C9C794153", x => x.cod_repasse);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbsemrepasse",
                columns: table => new
                {
                    idsemrepasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    coditem = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codprof = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbsemrep__A0464FC24BFFE5CB", x => x.idsemrepasse);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbtextocomum",
                columns: table => new
                {
                    idtexto = table.Column<float>(type: "float(10, 2)", nullable: false),
                    textocomum = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nrrepet = table.Column<float>(type: "float(10, 2)", nullable: true),
                    nrrepcontagem = table.Column<float>(type: "float(10, 2)", nullable: true),
                    codprof = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbTipoMovimento",
                columns: table => new
                {
                    idTipoMovimento = table.Column<int>(type: "int", nullable: false),
                    descTipoMovimento = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbTipoMovimento", x => x.idTipoMovimento);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo_Atendimento",
                columns: table => new
                {
                    Descricao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tipo_Ato",
                columns: table => new
                {
                    RECNUM = table.Column<decimal>(type: "decimal(8,0)", nullable: false),
                    CODIGO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRI = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FATOR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codtiss = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoSaida",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: true),
                    DescTipoAtend = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "trace",
                columns: table => new
                {
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    EventClass = table.Column<float>(type: "float(10, 2)", nullable: true),
                    TextData = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NTUserName = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientProcessID = table.Column<float>(type: "float(10, 2)", nullable: true),
                    ApplicationName = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SQLUserName = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SPID = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Duration = table.Column<float>(type: "float(10, 2)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Reads = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Writes = table.Column<float>(type: "float(10, 2)", nullable: true),
                    CPU = table.Column<float>(type: "float(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Padrao = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Inicial = table.Column<int>(type: "int", nullable: true),
                    IP = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<int>(type: "int", nullable: true),
                    nivel = table.Column<int>(type: "int", nullable: true),
                    local = table.Column<int>(type: "int", nullable: true),
                    cidade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    caminhoxml = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidpadrao = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logonet = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    endnet = table.Column<string>(type: "varchar(400)", unicode: false, maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    id_web = table.Column<int>(type: "int", nullable: true),
                    fl_enviasms = table.Column<int>(type: "int", nullable: true),
                    hr_enviosms = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    st_msg_sms = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    datanivel = table.Column<DateTime>(type: "datetime", nullable: true),
                    caminhologo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    caminhomodelos = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigoFinanceiro = table.Column<int>(type: "int", nullable: true),
                    serverFinanceiro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    baseFinanceiro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userFinanceiro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passFinanceiro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    alertaProdutos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Unidades_Internacao",
                columns: table => new
                {
                    CODIGO = table.Column<decimal>(type: "decimal(4,0)", nullable: false),
                    DESCRI = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SETOR = table.Column<decimal>(type: "decimal(4,0)", nullable: true)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AjusteEstoqueItens",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Lote = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataAjuste = table.Column<DateTime>(type: "datetime", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioNome = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoAjuste = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorAnterior = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorAlterado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AjusteEstoqueCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AjusteEs__06370DAD1FCF8646", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK__AjusteEst__Ajust__61E9B6FB",
                        column: x => x.AjusteEstoqueCodigo,
                        principalTable: "AjusteEstoque",
                        principalColumn: "Codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FaturamentoPaga",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codigo_fatura = table.Column<int>(type: "int", nullable: false),
                    data_pagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    valor_pagamento = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    valor_imposto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    observacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor_glosa = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    numero_nota = table.Column<int>(type: "int", nullable: true),
                    data_nota = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturamentoPaga", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_FaturamentoPaga_Faturamento",
                        column: x => x.codigo_fatura,
                        principalTable: "Faturamento",
                        principalColumn: "Codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    CODIDENT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RECNUM = table.Column<decimal>(type: "numeric(8,0)", nullable: true),
                    DESCRI = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MINIMO = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    PR_CUSTO = table.Column<decimal>(type: "numeric(14,4)", nullable: true),
                    DIVISOR = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    PR_VENDA = table.Column<decimal>(type: "numeric(16,4)", nullable: true),
                    SALDO0_QTD = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(8,2)", nullable: true),
                    APRESENTACAO = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MATMED = table.Column<decimal>(type: "numeric(4,0)", nullable: false),
                    MULTIPLICADOR = table.Column<decimal>(type: "numeric(6,0)", nullable: true),
                    QTDPADRAO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UNID_COMPRA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UNID_CONSUMO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONVERSAO = table.Column<decimal>(type: "numeric(10,2)", nullable: true),
                    BRASINDICE = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LIVRE = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tabela = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grupo = table.Column<int>(type: "int", nullable: true),
                    unid_cobranca = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodConv = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CONVANT = table.Column<int>(type: "int", nullable: true),
                    CONVBB = table.Column<int>(type: "int", nullable: true),
                    localizacao = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipodespesa = table.Column<int>(type: "int", nullable: true),
                    num_tiss = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codigotabelatiss = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COD_AMB = table.Column<float>(type: "float(10, 2)", nullable: true),
                    codigo = table.Column<float>(type: "float(10, 2)", nullable: true),
                    pr_venda_ant = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    id_grupo = table.Column<int>(type: "int", nullable: true),
                    flinativo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "(0)"),
                    codanvisa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codfabricante = table.Column<int>(type: "int", nullable: true),
                    codbarras = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prod_ref = table.Column<int>(type: "int", nullable: true),
                    prod_base = table.Column<int>(type: "int", nullable: true),
                    flrepasse = table.Column<int>(type: "int", nullable: true),
                    DESCRI_RESUMIDA = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dosagem = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.CODIDENT);
                    table.ForeignKey(
                        name: "FK_Produtos_grupos_produtos",
                        column: x => x.id_grupo,
                        principalTable: "grupos_produtos",
                        principalColumn: "id_grupo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbLog",
                columns: table => new
                {
                    idLog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    usuarioLog = table.Column<int>(type: "int", nullable: false),
                    dataLog = table.Column<DateTime>(type: "datetime", nullable: false),
                    descricaoLog = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbLog", x => x.idLog);
                    table.ForeignKey(
                        name: "FK_tbLog_Logins",
                        column: x => x.usuarioLog,
                        principalTable: "Logins",
                        principalColumn: "Codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AnamneseMastologia",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime", nullable: true),
                    Profissional = table.Column<int>(type: "int", nullable: true),
                    Procedencia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueixasPrincipais = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Menarca = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ciclos = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UltimaMenstruacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dismenorreia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gestacoes = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Para = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abortos = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cesareas = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PartosNormais = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UltimoParto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApUrinario = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Obesidade = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Acne = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Hirsutismo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PressaoArterial = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MedicamentosUso = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amamentacoes = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tempo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExameMamaDir = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExameMamaEsq = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExameGineco = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Paciente = table.Column<float>(type: "float(10, 2)", nullable: true),
                    AntecePesECiru = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_AnamneseMastologia", x => x.Codigo);
                    table.ForeignKey(
                        name: "fk_ProfissionaisAnamneseMastologia",
                        column: x => x.Profissional,
                        principalTable: "profissionais",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prescricao",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Paciente = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime", nullable: false),
                    descricao = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    medico = table.Column<int>(type: "int", nullable: true),
                    obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    statusnet = table.Column<int>(type: "int", nullable: true),
                    unidadeorigem = table.Column<int>(type: "int", nullable: true),
                    codigonet = table.Column<float>(type: "float(10, 2)", nullable: true),
                    dtexcpres = table.Column<DateTime>(type: "datetime", nullable: true),
                    dtexcpresC = table.Column<DateTime>(type: "datetime", nullable: true),
                    peso = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    altura = table.Column<decimal>(type: "decimal(4,0)", nullable: true),
                    supcorp = table.Column<decimal>(type: "decimal(4,2)", nullable: true),
                    protocolo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usufinal = table.Column<int>(type: "int", nullable: true),
                    datafinal = table.Column<DateTime>(type: "datetime", nullable: true),
                    presfinalizada = table.Column<int>(type: "int", nullable: true),
                    ciclo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    convenio = table.Column<int>(type: "int", nullable: true),
                    dia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prescricao_1", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_prescricao_Logins",
                        column: x => x.usufinal,
                        principalTable: "Logins",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_prescricao_Pacientes",
                        column: x => x.Paciente,
                        principalTable: "Pacientes",
                        principalColumn: "CodigoP");
                    table.ForeignKey(
                        name: "FK_prescricao_profissionais",
                        column: x => x.medico,
                        principalTable: "profissionais",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbEstoqueProdutos",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "int", nullable: false),
                    idLocal = table.Column<int>(type: "int", nullable: false),
                    lote = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qtd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEstoqueProdutos", x => new { x.idProduto, x.idLocal, x.lote });
                    table.ForeignKey(
                        name: "FK_tbEstoqueProdutos_Produtos",
                        column: x => x.idProduto,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                    table.ForeignKey(
                        name: "FK_tbEstoqueProdutos_tbLocalEstoque",
                        column: x => x.idLocal,
                        principalTable: "tbLocalEstoque",
                        principalColumn: "idLocalEstoque");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbPreProdRepasse",
                columns: table => new
                {
                    id_preprodrepasse = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codident = table.Column<int>(type: "int", nullable: false),
                    num_tiss = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    precounit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    dt_entrega = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbPrePro__4DF504FF85381461", x => x.id_preprodrepasse);
                    table.ForeignKey(
                        name: "FK_tbPreProdRepasse_produtos",
                        column: x => x.codident,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbProdutosConvenios",
                columns: table => new
                {
                    produtoConvenio = table.Column<int>(type: "int", nullable: false),
                    produtoEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ProdutoConvenio_Produtos",
                        column: x => x.produtoConvenio,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Produtos",
                        column: x => x.produtoEstoque,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "produtos_movimentacao",
                columns: table => new
                {
                    idmov = table.Column<float>(type: "float(10, 2)", nullable: false),
                    codigopres = table.Column<int>(type: "int", nullable: true),
                    codproduto = table.Column<int>(type: "int", nullable: true),
                    tabelaproduto = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qtdprod = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    usumov = table.Column<int>(type: "int", nullable: true),
                    datamov = table.Column<DateTime>(type: "datetime", nullable: true),
                    flexecutado = table.Column<int>(type: "int", nullable: true),
                    unidproduto = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obsmov = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coditempresc = table.Column<float>(type: "float(10, 2)", nullable: true),
                    codkit = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    horaaplicacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    usukitconfi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos_movimentacao", x => x.idmov);
                    table.ForeignKey(
                        name: "FK_ProdMov_Produtos",
                        column: x => x.codproduto,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                    table.ForeignKey(
                        name: "FK_produtos_movimentacao_prescricao",
                        column: x => x.codigopres,
                        principalTable: "prescricao",
                        principalColumn: "codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbEntSaiProd",
                columns: table => new
                {
                    idMovimento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idFornecedor = table.Column<int>(type: "int", nullable: true),
                    dtCompra = table.Column<DateTime>(type: "datetime", nullable: true),
                    tipoMovimento = table.Column<int>(type: "int", nullable: true),
                    notaFiscal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dtEntrega = table.Column<DateTime>(type: "datetime", nullable: true),
                    valorTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    descontos = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    impostos = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    valorFrete = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    usumov = table.Column<int>(type: "int", nullable: true),
                    dtMovimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    fl_finalizada = table.Column<int>(type: "int", nullable: true),
                    paciente = table.Column<float>(type: "float(10, 2)", nullable: true),
                    prescricao = table.Column<int>(type: "int", nullable: true),
                    origem = table.Column<int>(type: "int", nullable: true),
                    destino = table.Column<int>(type: "int", nullable: true),
                    temperatura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    obs = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dtVencimento = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEntSaiProd", x => x.idMovimento);
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_Pacientes",
                        column: x => x.paciente,
                        principalTable: "Pacientes",
                        principalColumn: "CodigoP");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_prescricao",
                        column: x => x.prescricao,
                        principalTable: "prescricao",
                        principalColumn: "codigo");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_tbFornecedor",
                        column: x => x.idFornecedor,
                        principalTable: "tbFornecedor",
                        principalColumn: "idFornecedor");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_tbLocalEstoque_destino",
                        column: x => x.destino,
                        principalTable: "tbLocalEstoque",
                        principalColumn: "idLocalEstoque");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_tbLocalEstoque_origem",
                        column: x => x.origem,
                        principalTable: "tbLocalEstoque",
                        principalColumn: "idLocalEstoque");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProd_tbTipoMovimento",
                        column: x => x.tipoMovimento,
                        principalTable: "tbTipoMovimento",
                        principalColumn: "idTipoMovimento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbProdutosCobranca",
                columns: table => new
                {
                    idProdCobranca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPrescricao = table.Column<int>(type: "int", nullable: true),
                    idProduto = table.Column<int>(type: "int", nullable: true),
                    idUsuario = table.Column<int>(type: "int", nullable: true),
                    totalUsado = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    data = table.Column<DateTime>(type: "datetime", nullable: true),
                    local = table.Column<int>(type: "int", nullable: true),
                    idMovimentoItem = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbProdut__B2BFCBF29A95F65D", x => x.idProdCobranca);
                    table.ForeignKey(
                        name: "FK__tbProduto__idPre__6C6814F4",
                        column: x => x.idPrescricao,
                        principalTable: "prescricao",
                        principalColumn: "codigo");
                    table.ForeignKey(
                        name: "FK__tbProduto__idPro__6D5C392D",
                        column: x => x.idProduto,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                    table.ForeignKey(
                        name: "FK__tbProduto__idUsu__6E505D66",
                        column: x => x.idUsuario,
                        principalTable: "Logins",
                        principalColumn: "Codigo");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tbEntSaiProdItens",
                columns: table => new
                {
                    idMovimentoItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idMovimento = table.Column<int>(type: "int", nullable: true),
                    idProduto = table.Column<int>(type: "int", nullable: true),
                    idProdMov = table.Column<float>(type: "float(10, 2)", nullable: true),
                    Lote = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dtFabricacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    qtdProduto = table.Column<decimal>(type: "decimal(12,0)", nullable: true),
                    PrecoUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    dtValidade = table.Column<DateTime>(type: "datetime", nullable: true),
                    fl_executado = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    obs = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fabricante = table.Column<int>(type: "int", nullable: true),
                    flag_baixa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEntSaiProdItens", x => x.idMovimentoItem);
                    table.ForeignKey(
                        name: "FK__tbEntSaiP__fabri__692D4C44",
                        column: x => x.fabricante,
                        principalTable: "tbFabricante",
                        principalColumn: "idFabricante");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProdItens_Produtos",
                        column: x => x.idProduto,
                        principalTable: "Produtos",
                        principalColumn: "CODIDENT");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProdItens_produtos_movimentacao",
                        column: x => x.idProdMov,
                        principalTable: "produtos_movimentacao",
                        principalColumn: "idmov");
                    table.ForeignKey(
                        name: "FK_tbEntSaiProdItens_tbEntSaiProd",
                        column: x => x.idMovimento,
                        principalTable: "tbEntSaiProd",
                        principalColumn: "idMovimento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "I_AjusteEstoque_DataFinalizacao",
                table: "AjusteEstoque",
                column: "DataFinalizacao");

            migrationBuilder.CreateIndex(
                name: "I_AjusteEstoque_DataCricao",
                table: "AjusteEstoqueItens",
                column: "DataAjuste");

            migrationBuilder.CreateIndex(
                name: "IX_AjusteEstoqueItens_AjusteEstoqueCodigo",
                table: "AjusteEstoqueItens",
                column: "AjusteEstoqueCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_AnamneseMastologia_Profissional",
                table: "AnamneseMastologia",
                column: "Profissional");

            migrationBuilder.CreateIndex(
                name: "i_cid10",
                table: "cid10",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "convcontra",
                table: "contratados",
                column: "convenio");

            migrationBuilder.CreateIndex(
                name: "ce_convenio",
                table: "Conv_Extra",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "codconvextra",
                table: "Conv_Extra",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "I_convenio_ce",
                table: "Conv_Extra",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "codconv",
                table: "convenios",
                column: "CODIGO");

            migrationBuilder.CreateIndex(
                name: "IX_FaturamentoPaga_codigo_fatura",
                table: "FaturamentoPaga",
                column: "codigo_fatura");

            migrationBuilder.CreateIndex(
                name: "fk_kititem",
                table: "Kits_Itens",
                column: "Kit");

            migrationBuilder.CreateIndex(
                name: "prod2item",
                table: "Kits_Itens",
                column: "iditem");

            migrationBuilder.CreateIndex(
                name: "proditem",
                table: "Kits_Itens",
                column: "PRODUTO");

            migrationBuilder.CreateIndex(
                name: "im_registro",
                table: "Med_Amb_Itens",
                column: "REGISTRO");

            migrationBuilder.CreateIndex(
                name: "mai_convenio",
                table: "Med_Amb_Itens",
                column: "PRODUTO");

            migrationBuilder.CreateIndex(
                name: "mam_procedimento",
                table: "Med_Amb_Mestre",
                column: "RegistroP");

            migrationBuilder.CreateIndex(
                name: "mam_tabela",
                table: "Med_Amb_Mestre",
                column: "PRONTUARIO");

            migrationBuilder.CreateIndex(
                name: "Med_Int_Mestre2",
                table: "Med_Int_Mestre",
                column: "PRONTUARIO");

            migrationBuilder.CreateIndex(
                name: "IX_prescricao_medico",
                table: "prescricao",
                column: "medico");

            migrationBuilder.CreateIndex(
                name: "IX_prescricao_Paciente",
                table: "prescricao",
                column: "Paciente");

            migrationBuilder.CreateIndex(
                name: "IX_prescricao_usufinal",
                table: "prescricao",
                column: "usufinal");

            migrationBuilder.CreateIndex(
                name: "pk_prescricao",
                table: "prescricao",
                column: "codigo");

            migrationBuilder.CreateIndex(
                name: "I_convenio_pi",
                table: "Proc_Amb_Itens",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "i_registro",
                table: "Proc_Amb_Itens",
                column: "REGISTRO");

            migrationBuilder.CreateIndex(
                name: "pai_convenio",
                table: "Proc_Amb_Itens",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "profissional",
                table: "Proc_Amb_Itens",
                column: "PROFISSIONAL");

            migrationBuilder.CreateIndex(
                name: "dt_movim",
                table: "Proc_Amb_Mestre",
                column: "DT_MOVIM");

            migrationBuilder.CreateIndex(
                name: "i_registrop_pm",
                table: "Proc_Amb_Mestre",
                column: "RegistroP");

            migrationBuilder.CreateIndex(
                name: "pam_procedimento",
                table: "Proc_Amb_Mestre",
                column: "PROCEDIMENTO");

            migrationBuilder.CreateIndex(
                name: "pam_tabela",
                table: "Proc_Amb_Mestre",
                column: "PRONTUARIO");

            migrationBuilder.CreateIndex(
                name: "Proc_Amb_Mestre3",
                table: "Proc_Amb_Mestre",
                columns: new[] { "PRONTUARIO", "RegistroP" });

            migrationBuilder.CreateIndex(
                name: "PROCEDIMENTOS2",
                table: "procedimentosfulllab",
                column: "TABELA");

            migrationBuilder.CreateIndex(
                name: "codprod",
                table: "Produtos",
                column: "codigo");

            migrationBuilder.CreateIndex(
                name: "descprod",
                table: "Produtos",
                column: "DESCRI");

            migrationBuilder.CreateIndex(
                name: "I_prodCodIdent",
                table: "Produtos",
                column: "CODIDENT");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_id_grupo",
                table: "Produtos",
                column: "id_grupo");

            migrationBuilder.CreateIndex(
                name: "tabprod",
                table: "Produtos",
                column: "Tabela");

            migrationBuilder.CreateIndex(
                name: "tipoprod",
                table: "Produtos",
                column: "MATMED");

            migrationBuilder.CreateIndex(
                name: "i_codproduto_mov",
                table: "produtos_movimentacao",
                column: "codproduto");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_movimentacao_codigopres",
                table: "produtos_movimentacao",
                column: "codigopres");

            migrationBuilder.CreateIndex(
                name: "i_codigo_pr",
                table: "profissionais",
                column: "codigo");

            migrationBuilder.CreateIndex(
                name: "i_codrecepcao",
                table: "Recepcao",
                column: "Codigo");

            migrationBuilder.CreateIndex(
                name: "i_codrecepcaonet",
                table: "Recepcao",
                column: "codigonet");

            migrationBuilder.CreateIndex(
                name: "i_datarecepcao",
                table: "Recepcao",
                column: "Data");

            migrationBuilder.CreateIndex(
                name: "i_medrecepcao",
                table: "Recepcao",
                column: "Medico");

            migrationBuilder.CreateIndex(
                name: "i_registroprecepcao",
                table: "Recepcao",
                column: "registrop");

            migrationBuilder.CreateIndex(
                name: "i_statusrecepcao",
                table: "Recepcao",
                column: "status");

            migrationBuilder.CreateIndex(
                name: "i_statusrecepcaonet",
                table: "Recepcao",
                column: "statusnet");

            migrationBuilder.CreateIndex(
                name: "conta",
                table: "Recepcao_Mestre",
                column: "Conta");

            migrationBuilder.CreateIndex(
                name: "convconta",
                table: "Recepcao_Mestre",
                column: "CONVENIO");

            migrationBuilder.CreateIndex(
                name: "dataconta",
                table: "Recepcao_Mestre",
                column: "DATA");

            migrationBuilder.CreateIndex(
                name: "faturaconta",
                table: "Recepcao_Mestre",
                column: "FATURA");

            migrationBuilder.CreateIndex(
                name: "i_pac_recmestre",
                table: "Recepcao_Mestre",
                column: "PACIENTE");

            migrationBuilder.CreateIndex(
                name: "pacienteconta",
                table: "Recepcao_Mestre",
                column: "PACIENTE");

            migrationBuilder.CreateIndex(
                name: "registroconta",
                table: "Recepcao_Mestre",
                column: "REGISTRO");

            migrationBuilder.CreateIndex(
                name: "I_EntSaiProd",
                table: "tbEntSaiProd",
                column: "dtMovimento");

            migrationBuilder.CreateIndex(
                name: "I_tbEntSaiProd",
                table: "tbEntSaiProd",
                column: "tipoMovimento");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProd_destino",
                table: "tbEntSaiProd",
                column: "destino");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProd_idFornecedor",
                table: "tbEntSaiProd",
                column: "idFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProd_origem",
                table: "tbEntSaiProd",
                column: "origem");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProd_paciente",
                table: "tbEntSaiProd",
                column: "paciente");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProd_prescricao",
                table: "tbEntSaiProd",
                column: "prescricao");

            migrationBuilder.CreateIndex(
                name: "Index_idProduto",
                table: "tbEntSaiProdItens",
                column: "idProduto");

            migrationBuilder.CreateIndex(
                name: "Index_lote",
                table: "tbEntSaiProdItens",
                column: "Lote");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProdItens_fabricante",
                table: "tbEntSaiProdItens",
                column: "fabricante");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProdItens_idMovimento",
                table: "tbEntSaiProdItens",
                column: "idMovimento");

            migrationBuilder.CreateIndex(
                name: "IX_tbEntSaiProdItens_idProdMov",
                table: "tbEntSaiProdItens",
                column: "idProdMov");

            migrationBuilder.CreateIndex(
                name: "IdxLocal",
                table: "tbEstoqueProdutos",
                column: "idLocal");

            migrationBuilder.CreateIndex(
                name: "IdxQtd",
                table: "tbEstoqueProdutos",
                column: "qtd");

            migrationBuilder.CreateIndex(
                name: "icoditpres",
                table: "tbitemprescricao",
                column: "codigo");

            migrationBuilder.CreateIndex(
                name: "iip_itemprescr",
                table: "tbitemprescricao",
                column: "codigopres");

            migrationBuilder.CreateIndex(
                name: "ipp_numgrupo",
                table: "tbitemprescricao",
                column: "numgrupo");

            migrationBuilder.CreateIndex(
                name: "ipp_prodprescr",
                table: "tbitemprescricao",
                column: "produto");

            migrationBuilder.CreateIndex(
                name: "IX_tbLog_usuarioLog",
                table: "tbLog",
                column: "usuarioLog");

            migrationBuilder.CreateIndex(
                name: "i_dt_entrega",
                table: "tbPreProdRepasse",
                column: "dt_entrega");

            migrationBuilder.CreateIndex(
                name: "IX_tbPreProdRepasse_codident",
                table: "tbPreProdRepasse",
                column: "codident");

            migrationBuilder.CreateIndex(
                name: "cod_amb",
                table: "TBPROCEDCOMP",
                column: "cod_amb");

            migrationBuilder.CreateIndex(
                name: "descriproc",
                table: "TBPROCEDCOMP",
                column: "DESCRI1");

            migrationBuilder.CreateIndex(
                name: "tabelaproc",
                table: "TBPROCEDCOMP",
                column: "TABELA");

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutosCobranca_idPrescricao",
                table: "tbProdutosCobranca",
                column: "idPrescricao");

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutosCobranca_idProduto",
                table: "tbProdutosCobranca",
                column: "idProduto");

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutosCobranca_idUsuario",
                table: "tbProdutosCobranca",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutosConvenios_produtoConvenio",
                table: "tbProdutosConvenios",
                column: "produtoConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_tbProdutosConvenios_produtoEstoque",
                table: "tbProdutosConvenios",
                column: "produtoEstoque");

            migrationBuilder.CreateIndex(
                name: "i_idtexto",
                table: "tbtextocomum",
                column: "idtexto");

            migrationBuilder.CreateIndex(
                name: "i_proftexto",
                table: "tbtextocomum",
                column: "codprof");

            migrationBuilder.CreateIndex(
                name: "i_texto",
                table: "tbtextocomum",
                column: "textocomum");

            migrationBuilder.CreateIndex(
                name: "i_codigo_ta",
                table: "Tipo_Ato",
                column: "CODIGO");

            migrationBuilder.CreateIndex(
                name: "ta_codigo",
                table: "Tipo_Ato",
                column: "CODIGO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "874_medicamentos");

            migrationBuilder.DropTable(
                name: "874_medicamentos_PF");

            migrationBuilder.DropTable(
                name: "874_medicamentos_RH");

            migrationBuilder.DropTable(
                name: "ABAAPRE");

            migrationBuilder.DropTable(
                name: "ABAMEDI");

            migrationBuilder.DropTable(
                name: "ABAPREC");

            migrationBuilder.DropTable(
                name: "ABAPREM");

            migrationBuilder.DropTable(
                name: "AjusteEstoqueItens");

            migrationBuilder.DropTable(
                name: "AnaDin");

            migrationBuilder.DropTable(
                name: "AnamneseMastologia");

            migrationBuilder.DropTable(
                name: "atualizacao");

            migrationBuilder.DropTable(
                name: "CADMED");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "cc_clientes");

            migrationBuilder.DropTable(
                name: "cid10");

            migrationBuilder.DropTable(
                name: "CONSULT");

            migrationBuilder.DropTable(
                name: "contratados");

            migrationBuilder.DropTable(
                name: "CONTROLE CONSULTORIO");

            migrationBuilder.DropTable(
                name: "Controle_Interface");

            migrationBuilder.DropTable(
                name: "Conv_Extra");

            migrationBuilder.DropTable(
                name: "conv_extra_faturados");

            migrationBuilder.DropTable(
                name: "conv_extra_ultimo");

            migrationBuilder.DropTable(
                name: "convenios");

            migrationBuilder.DropTable(
                name: "convenios_completo");

            migrationBuilder.DropTable(
                name: "convenios_faturados");

            migrationBuilder.DropTable(
                name: "convenios_ultimo");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Encaminhamento");

            migrationBuilder.DropTable(
                name: "entrada_e_saida");

            migrationBuilder.DropTable(
                name: "exames_bloqueados");

            migrationBuilder.DropTable(
                name: "FaturamentoPaga");

            migrationBuilder.DropTable(
                name: "Feriados");

            migrationBuilder.DropTable(
                name: "formas");

            migrationBuilder.DropTable(
                name: "GRADE");

            migrationBuilder.DropTable(
                name: "GRADECOL");

            migrationBuilder.DropTable(
                name: "GRADESEL");

            migrationBuilder.DropTable(
                name: "grupo_exame");

            migrationBuilder.DropTable(
                name: "grupo_mapa");

            migrationBuilder.DropTable(
                name: "GUARDA");

            migrationBuilder.DropTable(
                name: "histdoctors0");

            migrationBuilder.DropTable(
                name: "histdoctors2");

            migrationBuilder.DropTable(
                name: "HISTORIC");

            migrationBuilder.DropTable(
                name: "Kits");

            migrationBuilder.DropTable(
                name: "Kits_Itens");

            migrationBuilder.DropTable(
                name: "Kits_Proc");

            migrationBuilder.DropTable(
                name: "Leitos");

            migrationBuilder.DropTable(
                name: "listagem");

            migrationBuilder.DropTable(
                name: "log");

            migrationBuilder.DropTable(
                name: "logBD");

            migrationBuilder.DropTable(
                name: "logINT");

            migrationBuilder.DropTable(
                name: "MalaDireta");

            migrationBuilder.DropTable(
                name: "MAPA_ESPEC");

            migrationBuilder.DropTable(
                name: "mapaadm");

            migrationBuilder.DropTable(
                name: "mapas");

            migrationBuilder.DropTable(
                name: "Mat_Med_Unimed");

            migrationBuilder.DropTable(
                name: "materiais");

            migrationBuilder.DropTable(
                name: "matmed");

            migrationBuilder.DropTable(
                name: "matmedunimed");

            migrationBuilder.DropTable(
                name: "Med_Amb_Itens");

            migrationBuilder.DropTable(
                name: "Med_Amb_Mestre");

            migrationBuilder.DropTable(
                name: "Med_Int_Itens");

            migrationBuilder.DropTable(
                name: "Med_Int_Mestre");

            migrationBuilder.DropTable(
                name: "MEDIC");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Modificacoes");

            migrationBuilder.DropTable(
                name: "movimentacao");

            migrationBuilder.DropTable(
                name: "Order Details");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PACIENTE");

            migrationBuilder.DropTable(
                name: "Pacientes_Convenios");

            migrationBuilder.DropTable(
                name: "Pacientes_Extra");

            migrationBuilder.DropTable(
                name: "Plan1$");

            migrationBuilder.DropTable(
                name: "planvisual");

            migrationBuilder.DropTable(
                name: "Postos");

            migrationBuilder.DropTable(
                name: "Proc_Amb_Itens");

            migrationBuilder.DropTable(
                name: "Proc_Amb_Mestre");

            migrationBuilder.DropTable(
                name: "Proc_Convenios");

            migrationBuilder.DropTable(
                name: "Proc_Int_Itens");

            migrationBuilder.DropTable(
                name: "Proc_Int_Mestre");

            migrationBuilder.DropTable(
                name: "procedimentosfulllab");

            migrationBuilder.DropTable(
                name: "Prod_Convenios");

            migrationBuilder.DropTable(
                name: "Prod_Extra");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Profissionais_Convenios");

            migrationBuilder.DropTable(
                name: "profissionais_extra");

            migrationBuilder.DropTable(
                name: "Qual");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "Recepcao");

            migrationBuilder.DropTable(
                name: "recepcao_lab");

            migrationBuilder.DropTable(
                name: "Recepcao_Mestre");

            migrationBuilder.DropTable(
                name: "Repasse_Honor");

            migrationBuilder.DropTable(
                name: "Requisicao_Interface");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "setor_exame");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropTable(
                name: "STATUS");

            migrationBuilder.DropTable(
                name: "Status_Fatura");

            migrationBuilder.DropTable(
                name: "statuscarteira");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Tab_Golden");

            migrationBuilder.DropTable(
                name: "Tab_Hap");

            migrationBuilder.DropTable(
                name: "Tab_Unimed");

            migrationBuilder.DropTable(
                name: "tablac");

            migrationBuilder.DropTable(
                name: "TB_ATENDIMENTO");

            migrationBuilder.DropTable(
                name: "TB_MOTIVO_SAIDA_INTERNACAO");

            migrationBuilder.DropTable(
                name: "tbAnamnese");

            migrationBuilder.DropTable(
                name: "TBAplicaPlanTerap");

            migrationBuilder.DropTable(
                name: "TBAplicaPlanTerapItens");

            migrationBuilder.DropTable(
                name: "tbConsultaProfCon");

            migrationBuilder.DropTable(
                name: "tbConsultaProfConv");

            migrationBuilder.DropTable(
                name: "tbdocspaciente");

            migrationBuilder.DropTable(
                name: "tbEntSaiProdItens");

            migrationBuilder.DropTable(
                name: "TBESPECIALIDADE");

            migrationBuilder.DropTable(
                name: "tbEstoqueProdutos");

            migrationBuilder.DropTable(
                name: "tbitemprescricao");

            migrationBuilder.DropTable(
                name: "tblivrocaixa");

            migrationBuilder.DropTable(
                name: "tbLog");

            migrationBuilder.DropTable(
                name: "tbmodelos");

            migrationBuilder.DropTable(
                name: "TBPlanTerap");

            migrationBuilder.DropTable(
                name: "tbPreProdRepasse");

            migrationBuilder.DropTable(
                name: "TBPROCEDCOMP");

            migrationBuilder.DropTable(
                name: "tbProdutosCobranca");

            migrationBuilder.DropTable(
                name: "tbProdutosConvenios");

            migrationBuilder.DropTable(
                name: "tbprofcontratado");

            migrationBuilder.DropTable(
                name: "tbProfConvRepasse");

            migrationBuilder.DropTable(
                name: "tbprofdia");

            migrationBuilder.DropTable(
                name: "tbprofrepasse");

            migrationBuilder.DropTable(
                name: "tbRepasse");

            migrationBuilder.DropTable(
                name: "tbsemrepasse");

            migrationBuilder.DropTable(
                name: "tbtextocomum");

            migrationBuilder.DropTable(
                name: "Tipo_Atendimento");

            migrationBuilder.DropTable(
                name: "Tipo_Ato");

            migrationBuilder.DropTable(
                name: "TipoSaida");

            migrationBuilder.DropTable(
                name: "trace");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Unidades_Internacao");

            migrationBuilder.DropTable(
                name: "AjusteEstoque");

            migrationBuilder.DropTable(
                name: "Faturamento");

            migrationBuilder.DropTable(
                name: "tbFabricante");

            migrationBuilder.DropTable(
                name: "produtos_movimentacao");

            migrationBuilder.DropTable(
                name: "tbEntSaiProd");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "prescricao");

            migrationBuilder.DropTable(
                name: "tbFornecedor");

            migrationBuilder.DropTable(
                name: "tbLocalEstoque");

            migrationBuilder.DropTable(
                name: "tbTipoMovimento");

            migrationBuilder.DropTable(
                name: "grupos_produtos");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "profissionais");
        }
    }
}
