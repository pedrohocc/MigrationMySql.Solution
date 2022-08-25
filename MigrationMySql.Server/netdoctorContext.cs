using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MigrationMySql.Server
{
    public partial class netdoctorContext : DbContext
    {
        public netdoctorContext()
        {
        }

        public netdoctorContext(DbContextOptions<netdoctorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abaapre> Abaapres { get; set; } = null!;
        public virtual DbSet<Abamedi> Abamedis { get; set; } = null!;
        public virtual DbSet<Abaprec> Abaprecs { get; set; } = null!;
        public virtual DbSet<Abaprem> Abaprems { get; set; } = null!;
        public virtual DbSet<AjusteEstoque> AjusteEstoques { get; set; } = null!;
        public virtual DbSet<AjusteEstoqueIten> AjusteEstoqueItens { get; set; } = null!;
        public virtual DbSet<AnaDin> AnaDins { get; set; } = null!;
        public virtual DbSet<Anamnese> Anamneses { get; set; } = null!;
        public virtual DbSet<AnamneseMastologium> AnamneseMastologia { get; set; } = null!;
        public virtual DbSet<Atualizacao> Atualizacaos { get; set; } = null!;
        public virtual DbSet<Cadmed> Cadmeds { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CcCliente> CcClientes { get; set; } = null!;
        public virtual DbSet<Cid10> Cid10s { get; set; } = null!;
        public virtual DbSet<Consult> Consults { get; set; } = null!;
        public virtual DbSet<Contratado> Contratados { get; set; } = null!;
        public virtual DbSet<ControleConsultorio> ControleConsultorios { get; set; } = null!;
        public virtual DbSet<ControleInterface> ControleInterfaces { get; set; } = null!;
        public virtual DbSet<ConvExtra> ConvExtras { get; set; } = null!;
        public virtual DbSet<ConvExtraFaturado> ConvExtraFaturados { get; set; } = null!;
        public virtual DbSet<ConvExtraUltimo> ConvExtraUltimos { get; set; } = null!;
        public virtual DbSet<Convenio> Convenios { get; set; } = null!;
        public virtual DbSet<ConveniosCompleto> ConveniosCompletos { get; set; } = null!;
        public virtual DbSet<ConveniosFaturado> ConveniosFaturados { get; set; } = null!;
        public virtual DbSet<ConveniosUltimo> ConveniosUltimos { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Encaminhamento> Encaminhamentos { get; set; } = null!;
        public virtual DbSet<EntradaESaidum> EntradaESaida { get; set; } = null!;
        public virtual DbSet<ExamesBloqueado> ExamesBloqueados { get; set; } = null!;
        public virtual DbSet<Faturamento> Faturamentos { get; set; } = null!;
        public virtual DbSet<FaturamentoPaga> FaturamentoPagas { get; set; } = null!;
        public virtual DbSet<Feriado> Feriados { get; set; } = null!;
        public virtual DbSet<Forma> Formas { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Gradecol> Gradecols { get; set; } = null!;
        public virtual DbSet<Gradesel> Gradesels { get; set; } = null!;
        public virtual DbSet<GrupoExame> GrupoExames { get; set; } = null!;
        public virtual DbSet<GrupoMapa> GrupoMapas { get; set; } = null!;
        public virtual DbSet<GruposProduto> GruposProdutos { get; set; } = null!;
        public virtual DbSet<Guardum> Guarda { get; set; } = null!;
        public virtual DbSet<Histdoctors0> Histdoctors0s { get; set; } = null!;
        public virtual DbSet<Histdoctors2> Histdoctors2s { get; set; } = null!;
        public virtual DbSet<Historic> Historics { get; set; } = null!;
        public virtual DbSet<Kit> Kits { get; set; } = null!;
        public virtual DbSet<KitsIten> KitsItens { get; set; } = null!;
        public virtual DbSet<KitsProc> KitsProcs { get; set; } = null!;
        public virtual DbSet<Leito> Leitos { get; set; } = null!;
        public virtual DbSet<Listagem> Listagems { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogBd> LogBds { get; set; } = null!;
        public virtual DbSet<LogInt> LogInts { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<MalaDiretum> MalaDireta { get; set; } = null!;
        public virtual DbSet<Mapa> Mapas { get; set; } = null!;
        public virtual DbSet<MapaEspec> MapaEspecs { get; set; } = null!;
        public virtual DbSet<Mapaadm> Mapaadms { get; set; } = null!;
        public virtual DbSet<MatMedUnimed> MatMedUnimeds { get; set; } = null!;
        public virtual DbSet<Materiai> Materiais { get; set; } = null!;
        public virtual DbSet<Matmed> Matmeds { get; set; } = null!;
        public virtual DbSet<Matmedunimed1> Matmedunimeds1 { get; set; } = null!;
        public virtual DbSet<MedAmbIten> MedAmbItens { get; set; } = null!;
        public virtual DbSet<MedAmbMestre> MedAmbMestres { get; set; } = null!;
        public virtual DbSet<MedIntIten> MedIntItens { get; set; } = null!;
        public virtual DbSet<MedIntMestre> MedIntMestres { get; set; } = null!;
        public virtual DbSet<Medic> Medics { get; set; } = null!;
        public virtual DbSet<Medico> Medicos { get; set; } = null!;
        public virtual DbSet<Modificaco> Modificacoes { get; set; } = null!;
        public virtual DbSet<Movimentacao> Movimentacaos { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Paciente> Pacientes { get; set; } = null!;
        public virtual DbSet<Paciente1> Pacientes1 { get; set; } = null!;
        public virtual DbSet<PacientesConvenio> PacientesConvenios { get; set; } = null!;
        public virtual DbSet<PacientesExtra> PacientesExtras { get; set; } = null!;
        public virtual DbSet<Plan1> Plan1s { get; set; } = null!;
        public virtual DbSet<Planvisual> Planvisuals { get; set; } = null!;
        public virtual DbSet<Posto> Postos { get; set; } = null!;
        public virtual DbSet<Prescricao> Prescricaos { get; set; } = null!;
        public virtual DbSet<ProcAmbIten> ProcAmbItens { get; set; } = null!;
        public virtual DbSet<ProcAmbMestre> ProcAmbMestres { get; set; } = null!;
        public virtual DbSet<ProcConvenio> ProcConvenios { get; set; } = null!;
        public virtual DbSet<ProcIntIten> ProcIntItens { get; set; } = null!;
        public virtual DbSet<ProcIntMestre> ProcIntMestres { get; set; } = null!;
        public virtual DbSet<Procedimento> Procedimentos { get; set; } = null!;
        public virtual DbSet<Procedimentosfulllab> Procedimentosfulllabs { get; set; } = null!;
        public virtual DbSet<ProdConvenio> ProdConvenios { get; set; } = null!;
        public virtual DbSet<ProdExtra> ProdExtras { get; set; } = null!;
        public virtual DbSet<Prodkit> Prodkits { get; set; } = null!;
        public virtual DbSet<ProdkitPresc> ProdkitPrescs { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<ProdutosMovimentacao> ProdutosMovimentacaos { get; set; } = null!;
        public virtual DbSet<Profissionai> Profissionais { get; set; } = null!;
        public virtual DbSet<ProfissionaisConvenio> ProfissionaisConvenios { get; set; } = null!;
        public virtual DbSet<ProfissionaisExtra> ProfissionaisExtras { get; set; } = null!;
        public virtual DbSet<Qual> Quals { get; set; } = null!;
        public virtual DbSet<Receita> Receitas { get; set; } = null!;
        public virtual DbSet<Recepcao> Recepcaos { get; set; } = null!;
        public virtual DbSet<RecepcaoInternacao> RecepcaoInternacaos { get; set; } = null!;
        public virtual DbSet<RecepcaoLab> RecepcaoLabs { get; set; } = null!;
        public virtual DbSet<RecepcaoMestre> RecepcaoMestres { get; set; } = null!;
        public virtual DbSet<RepasseHonor> RepasseHonors { get; set; } = null!;
        public virtual DbSet<RequisicaoInterface> RequisicaoInterfaces { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Setor> Setors { get; set; } = null!;
        public virtual DbSet<SetorExame> SetorExames { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<StatusFatura> StatusFaturas { get; set; } = null!;
        public virtual DbSet<Statuscarteira> Statuscarteiras { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<TabGolden> TabGoldens { get; set; } = null!;
        public virtual DbSet<TabHap> TabHaps { get; set; } = null!;
        public virtual DbSet<TabUnimed> TabUnimeds { get; set; } = null!;
        public virtual DbSet<Tablac> Tablacs { get; set; } = null!;
        public virtual DbSet<TbAnamnese> TbAnamneses { get; set; } = null!;
        public virtual DbSet<TbAtendimento> TbAtendimentos { get; set; } = null!;
        public virtual DbSet<TbConsultaProfCon> TbConsultaProfCons { get; set; } = null!;
        public virtual DbSet<TbConsultaProfConv> TbConsultaProfConvs { get; set; } = null!;
        public virtual DbSet<TbEntSaiProd> TbEntSaiProds { get; set; } = null!;
        public virtual DbSet<TbEntSaiProdIten> TbEntSaiProdItens { get; set; } = null!;
        public virtual DbSet<TbEstoqueProduto> TbEstoqueProdutos { get; set; } = null!;
        public virtual DbSet<TbFabricante> TbFabricantes { get; set; } = null!;
        public virtual DbSet<TbFornecedor> TbFornecedors { get; set; } = null!;
        public virtual DbSet<TbLocalEstoque> TbLocalEstoques { get; set; } = null!;
        public virtual DbSet<TbLog> TbLogs { get; set; } = null!;
        public virtual DbSet<TbMotivoSaidaInternacao> TbMotivoSaidaInternacaos { get; set; } = null!;
        public virtual DbSet<TbPreProdRepasse> TbPreProdRepasses { get; set; } = null!;
        public virtual DbSet<TbProdutosCobranca> TbProdutosCobrancas { get; set; } = null!;
        public virtual DbSet<TbProdutosConvenio> TbProdutosConvenios { get; set; } = null!;
        public virtual DbSet<TbProfConvRepasse> TbProfConvRepasses { get; set; } = null!;
        public virtual DbSet<TbRepasse> TbRepasses { get; set; } = null!;
        public virtual DbSet<TbTipoMovimento> TbTipoMovimentos { get; set; } = null!;
        public virtual DbSet<TbaplicaPlanTerap> TbaplicaPlanTeraps { get; set; } = null!;
        public virtual DbSet<TbaplicaPlanTerapIten> TbaplicaPlanTerapItens { get; set; } = null!;
        public virtual DbSet<Tbdocspaciente> Tbdocspacientes { get; set; } = null!;
        public virtual DbSet<Tbespecialidade> Tbespecialidades { get; set; } = null!;
        public virtual DbSet<Tbitemprescricao> Tbitemprescricaos { get; set; } = null!;
        public virtual DbSet<Tblivrocaixa> Tblivrocaixas { get; set; } = null!;
        public virtual DbSet<Tbmodelo> Tbmodelos { get; set; } = null!;
        public virtual DbSet<TbplanTerap> TbplanTeraps { get; set; } = null!;
        public virtual DbSet<Tbprocedcomp> Tbprocedcomps { get; set; } = null!;
        public virtual DbSet<Tbprofcontratado> Tbprofcontratados { get; set; } = null!;
        public virtual DbSet<Tbprofdium> Tbprofdia { get; set; } = null!;
        public virtual DbSet<Tbprofrepasse> Tbprofrepasses { get; set; } = null!;
        public virtual DbSet<Tbsemrepasse> Tbsemrepasses { get; set; } = null!;
        public virtual DbSet<Tbtextocomum> Tbtextocomums { get; set; } = null!;
        public virtual DbSet<TipoAtendimento> TipoAtendimentos { get; set; } = null!;
        public virtual DbSet<TipoAto> TipoAtos { get; set; } = null!;
        public virtual DbSet<TipoSaidum> TipoSaida { get; set; } = null!;
        public virtual DbSet<Trace> Traces { get; set; } = null!;
        public virtual DbSet<Unidade> Unidades { get; set; } = null!;
        public virtual DbSet<UnidadesInternacao> UnidadesInternacaos { get; set; } = null!;
        public virtual DbSet<VwAgendaProf> VwAgendaProfs { get; set; } = null!;
        public virtual DbSet<VwCabecalhoContum> VwCabecalhoConta { get; set; } = null!;
        public virtual DbSet<VwContaProcNaoRealizado> VwContaProcNaoRealizados { get; set; } = null!;
        public virtual DbSet<VwContum> VwConta { get; set; } = null!;
        public virtual DbSet<VwDetalhesContum> VwDetalhesConta { get; set; } = null!;
        public virtual DbSet<VwKitIten> VwKitItens { get; set; } = null!;
        public virtual DbSet<VwMatmedContum> VwMatmedConta { get; set; } = null!;
        public virtual DbSet<VwPrescPaciProf> VwPrescPaciProfs { get; set; } = null!;
        public virtual DbSet<VwProcAmbMestreIten> VwProcAmbMestreItens { get; set; } = null!;
        public virtual DbSet<VwProcContum> VwProcConta { get; set; } = null!;
        public virtual DbSet<VwRepasse> VwRepasses { get; set; } = null!;
        public virtual DbSet<VwRepasseInter> VwRepasseInters { get; set; } = null!;
        public virtual DbSet<VwTotaisProdExec> VwTotaisProdExecs { get; set; } = null!;
        public virtual DbSet<VwTotaisProdExecSemLocal> VwTotaisProdExecSemLocals { get; set; } = null!;
        public virtual DbSet<VwUltConvPac> VwUltConvPacs { get; set; } = null!;
        public virtual DbSet<_874Medicamento> _874Medicamentos { get; set; } = null!;
        public virtual DbSet<_874MedicamentosPf> _874MedicamentosPfs { get; set; } = null!;
        public virtual DbSet<_874MedicamentosRh> _874MedicamentosRhs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=notebook-dell\\sqlexpress;database=netdoctor;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abaapre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABAAPRE");

                entity.Property(e => e.AprCodi)
                    .HasMaxLength(4)
                    .HasColumnName("APR_CODI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.AprDesc)
                    .HasMaxLength(60)
                    .HasColumnName("APR_DESC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.AprFlag).HasColumnName("APR_FLAG");

                entity.Property(e => e.AprIpi).HasColumnName("APR_IPI");

                entity.Property(e => e.AprQtde).HasColumnName("APR_QTDE");
            });

            modelBuilder.Entity<Abamedi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABAMEDI");

                entity.Property(e => e.MedCodi)
                    .HasMaxLength(5)
                    .HasColumnName("MED_CODI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.MedDesc)
                    .HasMaxLength(40)
                    .HasColumnName("MED_DESC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.MedFlag).HasColumnName("MED_FLAG");

                entity.Property(e => e.MedSolu).HasColumnName("MED_SOLU");
            });

            modelBuilder.Entity<Abaprec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABAPREC");

                entity.Property(e => e.PreApre)
                    .HasMaxLength(4)
                    .HasColumnName("PRE_APRE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreData)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRE_DATA");

                entity.Property(e => e.PreEdis).HasColumnName("PRE_EDIS");

                entity.Property(e => e.PreEx1).HasColumnName("PRE_EX1");

                entity.Property(e => e.PreEx2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PRE_EX2");

                entity.Property(e => e.PreEx3).HasColumnName("PRE_EX3");

                entity.Property(e => e.PreEx4).HasColumnName("PRE_EX4");

                entity.Property(e => e.PreEx5).HasColumnName("PRE_EX5");

                entity.Property(e => e.PreEx6).HasColumnName("PRE_EX6");

                entity.Property(e => e.PreExce)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_EXCE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreFlag).HasColumnName("PRE_FLAG");

                entity.Property(e => e.PreGene)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_GENE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreIpi).HasColumnName("PRE_IPI");

                entity.Property(e => e.PreLabo)
                    .HasMaxLength(3)
                    .HasColumnName("PRE_LABO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreMedi)
                    .HasMaxLength(5)
                    .HasColumnName("PRE_MEDI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrePort)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_PORT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrePrec).HasColumnName("PRE_PREC");

                entity.Property(e => e.PreRev1).HasColumnName("PRE_REV1");

                entity.Property(e => e.PreRev2).HasColumnName("PRE_REV2");

                entity.Property(e => e.PreRev3).HasColumnName("PRE_REV3");

                entity.Property(e => e.PreRev4).HasColumnName("PRE_REV4");

                entity.Property(e => e.PreRev5).HasColumnName("PRE_REV5");

                entity.Property(e => e.PreRev6).HasColumnName("PRE_REV6");

                entity.Property(e => e.PreTipo)
                    .HasMaxLength(3)
                    .HasColumnName("PRE_TIPO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Abaprem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ABAPREM");

                entity.Property(e => e.PreApre)
                    .HasMaxLength(4)
                    .HasColumnName("PRE_APRE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreData)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PRE_DATA");

                entity.Property(e => e.PreEdis).HasColumnName("PRE_EDIS");

                entity.Property(e => e.PreEx1).HasColumnName("PRE_EX1");

                entity.Property(e => e.PreEx2).HasColumnName("PRE_EX2");

                entity.Property(e => e.PreEx3).HasColumnName("PRE_EX3");

                entity.Property(e => e.PreEx4).HasColumnName("PRE_EX4");

                entity.Property(e => e.PreEx5).HasColumnName("PRE_EX5");

                entity.Property(e => e.PreEx6).HasColumnName("PRE_EX6");

                entity.Property(e => e.PreExce)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_EXCE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreFlag).HasColumnName("PRE_FLAG");

                entity.Property(e => e.PreGene)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_GENE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreIpi).HasColumnName("PRE_IPI");

                entity.Property(e => e.PreLabo)
                    .HasMaxLength(3)
                    .HasColumnName("PRE_LABO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PreMedi)
                    .HasMaxLength(5)
                    .HasColumnName("PRE_MEDI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrePort)
                    .HasMaxLength(1)
                    .HasColumnName("PRE_PORT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrePrec).HasColumnName("PRE_PREC");

                entity.Property(e => e.PreRev1).HasColumnName("PRE_REV1");

                entity.Property(e => e.PreRev2).HasColumnName("PRE_REV2");

                entity.Property(e => e.PreRev3).HasColumnName("PRE_REV3");

                entity.Property(e => e.PreRev4).HasColumnName("PRE_REV4");

                entity.Property(e => e.PreRev5).HasColumnName("PRE_REV5");

                entity.Property(e => e.PreRev6).HasColumnName("PRE_REV6");

                entity.Property(e => e.PreTipo)
                    .HasMaxLength(3)
                    .HasColumnName("PRE_TIPO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<AjusteEstoque>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__AjusteEs__06370DAD0969FB88");

                entity.ToTable("AjusteEstoque");

                entity.HasIndex(e => e.DataFinalizacao, "I_AjusteEstoque_DataFinalizacao");

                entity.Property(e => e.CodigoValidacao)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DataCriacao).HasColumnType("datetime");

                entity.Property(e => e.DataFinalizacao).HasColumnType("datetime");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AjusteEstoqueIten>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__AjusteEs__06370DAD1FCF8646");

                entity.HasIndex(e => e.DataAjuste, "I_AjusteEstoque_DataCricao");

                entity.Property(e => e.DataAjuste).HasColumnType("datetime");

                entity.Property(e => e.Lote)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAjuste)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioNome)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAlterado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAnterior)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AjusteEstoqueCodigoNavigation)
                    .WithMany(p => p.AjusteEstoqueItens)
                    .HasForeignKey(d => d.AjusteEstoqueCodigo)
                    .HasConstraintName("FK__AjusteEst__Ajust__61E9B6FB");
            });

            modelBuilder.Entity<AnaDin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AnaDin");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Anamnese>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Codigo_Historico");

                entity.ToTable("Anamnese");

                entity.Property(e => e.Cid10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cid10");

                entity.Property(e => e.Codigonet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigonet");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.FlagSigiloso)
                    .HasColumnName("flag_sigiloso")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Historico)
                    .HasColumnType("ntext")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ResultExames)
                    .HasColumnType("ntext")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Unidadeorigem).HasColumnName("unidadeorigem");
            });

            modelBuilder.Entity<AnamneseMastologium>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("pk_AnamneseMastologia");

                entity.Property(e => e.Abortos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Acne)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Amamentacoes)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AntecePesEciru)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AntecePesECiru");

                entity.Property(e => e.ApUrinario)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cesareas)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ciclos)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Dismenorreia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExameGineco)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExameMamaDir)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExameMamaEsq)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gestacoes)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hirsutismo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MedicamentosUso)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Menarca)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Obesidade)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Paciente).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Para)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartosNormais)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Peso)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PressaoArterial)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Procedencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QueixasPrincipais)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tempo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UltimaMenstruacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoParto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProfissionalNavigation)
                    .WithMany(p => p.AnamneseMastologia)
                    .HasForeignKey(d => d.Profissional)
                    .HasConstraintName("fk_ProfissionaisAnamneseMastologia");
            });

            modelBuilder.Entity<Atualizacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("atualizacao");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Datafim)
                    .HasColumnType("datetime")
                    .HasColumnName("datafim");

                entity.Property(e => e.Dataini)
                    .HasColumnType("datetime")
                    .HasColumnName("dataini");

                entity.Property(e => e.Segundos).HasColumnName("segundos");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(5)
                    .HasColumnName("unidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Cadmed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CADMED");

                entity.Property(e => e.CobrAnestVl).HasColumnName("COBR ANEST VL");

                entity.Property(e => e.CodMed)
                    .HasMaxLength(50)
                    .HasColumnName("COD MED");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Crm).HasColumnName("CRM");

                entity.Property(e => e.DescPartic).HasColumnName("DESC PARTIC");

                entity.Property(e => e.DescProd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("desc_prod");

                entity.Property(e => e.Desconto).HasColumnName("DESCONTO");

                entity.Property(e => e.End)
                    .HasMaxLength(50)
                    .HasColumnName("END");

                entity.Property(e => e.FatorRelat).HasColumnName("FATOR RELAT");

                entity.Property(e => e.FoneCel)
                    .HasMaxLength(50)
                    .HasColumnName("FONE (CEL)");

                entity.Property(e => e.FoneRes)
                    .HasMaxLength(50)
                    .HasColumnName("FONE(RES)");

                entity.Property(e => e.ImpUnimedxxx).HasColumnName("IMP UNIMEDXXX");

                entity.Property(e => e.LioAux).HasColumnName("LIO AUX");

                entity.Property(e => e.Medic)
                    .HasMaxLength(50)
                    .HasColumnName("MEDIC");

                entity.Property(e => e.MédRelatUnimed)
                    .HasColumnType("ntext")
                    .HasColumnName("MÉD RELAT UNIMED");

                entity.Property(e => e.Médico)
                    .HasMaxLength(50)
                    .HasColumnName("MÉDICO");

                entity.Property(e => e.NumUnim)
                    .HasMaxLength(255)
                    .HasColumnName("NUM UNIM");

                entity.Property(e => e.PgLio).HasColumnName("PG LIO");

                entity.Property(e => e.SiglaMed)
                    .HasMaxLength(50)
                    .HasColumnName("SIGLA MED")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<CcCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cc_clientes");

                entity.Property(e => e.Atualiza).HasColumnName("atualiza");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Forma).HasColumnName("forma");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(100)
                    .HasColumnName("observacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<Cid10>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cid10");

                entity.HasIndex(e => e.Codigo, "i_cid10");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Flativo).HasColumnName("flativo");
            });

            modelBuilder.Entity<Consult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONSULT");

                entity.Property(e => e.Cat)
                    .HasMaxLength(13)
                    .HasColumnName("CAT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.Fone)
                    .HasMaxLength(13)
                    .HasColumnName("FONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .HasColumnName("HORA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Contratado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contratados");

                entity.HasIndex(e => e.Convenio, "convcontra");

                entity.Property(e => e.Cnes)
                    .HasMaxLength(10)
                    .HasColumnName("cnes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigonoconvenio)
                    .HasMaxLength(50)
                    .HasColumnName("codigonoconvenio")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.Faturaclinica)
                    .HasColumnName("faturaclinica")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Flinterno).HasColumnName("flinterno");

                entity.Property(e => e.Nome)
                    .HasMaxLength(200)
                    .HasColumnName("nome")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(100)
                    .HasColumnName("unidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ControleConsultorio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CONTROLE CONSULTORIO");

                entity.Property(e => e.Anestesista)
                    .HasMaxLength(50)
                    .HasColumnName("ANESTESISTA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Autoriz)
                    .HasMaxLength(20)
                    .HasColumnName("AUTORIZ")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodJustif)
                    .HasMaxLength(50)
                    .HasColumnName("COD JUSTIF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodUsuDep)
                    .HasMaxLength(2)
                    .HasColumnName("COD USU DEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodUsuDig)
                    .HasMaxLength(2)
                    .HasColumnName("COD USU DIG")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(255)
                    .HasColumnName("CONVENIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CódProced)
                    .HasMaxLength(50)
                    .HasColumnName("CÓD PROCED")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.DataLançam)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA LANÇAM");

                entity.Property(e => e.DataUnimed)
                    .HasMaxLength(50)
                    .HasColumnName("DATA UNIMED")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DtAutoriz)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DT AUTORIZ");

                entity.Property(e => e.DtEmissGuia)
                    .HasMaxLength(50)
                    .HasColumnName("DT EMISS GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FormaPgto)
                    .HasMaxLength(255)
                    .HasColumnName("FORMA PGTO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.GuiaPrincipal)
                    .HasMaxLength(50)
                    .HasColumnName("GUIA PRINCIPAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Idade).HasColumnName("IDADE");

                entity.Property(e => e.Interc)
                    .HasMaxLength(50)
                    .HasColumnName("INTERC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .HasColumnName("LOTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .HasColumnName("MATRICULA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mes)
                    .HasMaxLength(4)
                    .HasColumnName("MES")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.MédSolicitante)
                    .HasMaxLength(6)
                    .HasColumnName("MÉD SOLICITANTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NGuia)
                    .HasMaxLength(255)
                    .HasColumnName("N GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NRec)
                    .HasMaxLength(50)
                    .HasColumnName("N_REC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NTitular)
                    .HasMaxLength(255)
                    .HasColumnName("N TITULAR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Num)
                    .HasMaxLength(255)
                    .HasColumnName("NUM")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(50)
                    .HasColumnName("OBS:")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Olho)
                    .HasMaxLength(255)
                    .HasColumnName("OLHO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(40)
                    .HasColumnName("PACIENTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Plano)
                    .HasMaxLength(50)
                    .HasColumnName("PLANO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Qtde).HasColumnName("QTDE");

                entity.Property(e => e.QtdeUco).HasColumnName("QTDE UCO");

                entity.Property(e => e.SiglaMéd)
                    .HasMaxLength(255)
                    .HasColumnName("SIGLA MÉD")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SiglaProced)
                    .HasMaxLength(255)
                    .HasColumnName("SIGLA PROCED")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UnimPac)
                    .HasMaxLength(50)
                    .HasColumnName("UNIM PAC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UnimedFilme).HasColumnName("UNIMED FILME");

                entity.Property(e => e.UnimedMat).HasColumnName("UNIMED MAT");

                entity.Property(e => e.ValidCart)
                    .HasMaxLength(50)
                    .HasColumnName("VALID CART")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ValorAnest).HasColumnName("VALOR ANEST");

                entity.Property(e => e.ValorPt).HasColumnName("VALOR PT");
            });

            modelBuilder.Entity<ControleInterface>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Controle_Interface");

                entity.Property(e => e.PEntrada)
                    .HasMaxLength(255)
                    .HasColumnName("P_Entrada")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PSaida)
                    .HasMaxLength(255)
                    .HasColumnName("P_Saida")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.TAtua)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("T_Atua");
            });

            modelBuilder.Entity<ConvExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Conv_Extra");

                entity.HasIndex(e => e.Convenio, "I_convenio_ce");

                entity.HasIndex(e => e.Convenio, "ce_convenio");

                entity.HasIndex(e => e.Convenio, "codconvextra");

                entity.Property(e => e.C03s)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("C03S")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cnes)
                    .HasMaxLength(50)
                    .HasColumnName("cnes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod");

                entity.Property(e => e.CodMat).HasColumnName("cod_mat");

                entity.Property(e => e.CodMed).HasColumnName("cod_med");

                entity.Property(e => e.Contasfatura).HasColumnName("contasfatura");

                entity.Property(e => e.Convenio)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.DiasRetorno)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("DIAS_RETORNO");

                entity.Property(e => e.FlTotmatmed).HasColumnName("fl_totmatmed");

                entity.Property(e => e.Honorarios1)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("honorarios1");

                entity.Property(e => e.Honorarios2)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("honorarios2");

                entity.Property(e => e.HorarioF)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("HORARIO_F");

                entity.Property(e => e.HorarioI)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("HORARIO_I");

                entity.Property(e => e.HrEmFim)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HrEmIni)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IndiceF)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_F");

                entity.Property(e => e.IndiceP)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_P");

                entity.Property(e => e.IndiceS)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_S");

                entity.Property(e => e.Matmed1)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nomeplano)
                    .HasMaxLength(50)
                    .HasColumnName("nomeplano")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Planilha)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLANILHA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Programa)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum).HasColumnName("recnum");

                entity.Property(e => e.RegAns)
                    .HasMaxLength(20)
                    .HasColumnName("reg_ans")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TABELA1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela2)
                    .HasMaxLength(30)
                    .HasColumnName("TABELA2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgencia)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("URGENCIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ConvExtraFaturado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("conv_extra_faturados");

                entity.Property(e => e.C03s)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("C03S")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.DiasRetorno)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("DIAS_RETORNO");

                entity.Property(e => e.HorarioF)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("HORARIO_F");

                entity.Property(e => e.HorarioI)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("HORARIO_I");

                entity.Property(e => e.HrEmFim)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HrEmIni)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IndiceF)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("INDICE_F");

                entity.Property(e => e.IndiceP)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("INDICE_P");

                entity.Property(e => e.IndiceS)
                    .HasColumnType("decimal(10, 4)")
                    .HasColumnName("INDICE_S");

                entity.Property(e => e.Matmed1)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Planilha)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLANILHA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Programa)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ConvExtraUltimo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("conv_extra_ultimo");

                entity.Property(e => e.C03s)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("C03S")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.DiasRetorno)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("DIAS_RETORNO");

                entity.Property(e => e.HorarioF)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("HORARIO_F");

                entity.Property(e => e.HorarioI)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("HORARIO_I");

                entity.Property(e => e.HrEmFim)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HrEmIni)
                    .HasMaxLength(5)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IndiceF)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_F");

                entity.Property(e => e.IndiceP)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_P");

                entity.Property(e => e.IndiceS)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("INDICE_S");

                entity.Property(e => e.Matmed1)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Planilha)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLANILHA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Programa)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PROGRAMA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela4)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgencia)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("URGENCIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Convenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("convenios");

                entity.HasIndex(e => e.Codigo, "codconv");

                entity.Property(e => e.Arredonda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ARREDONDA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codesm)
                    .HasMaxLength(5)
                    .HasColumnName("codesm");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CODIGO");

                entity.Property(e => e.CodigoTerceiro).HasColumnName("codigoTerceiro");

                entity.Property(e => e.Contato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTATO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dhe).HasColumnName("DHE");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FlCompmatricula).HasColumnName("fl_compmatricula");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(255)
                    .HasColumnName("OBS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Percentual)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("PERCENTUAL");

                entity.Property(e => e.Razaosocial)
                    .HasMaxLength(255)
                    .HasColumnName("RAZAOSOCIAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TaxaImposto)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("taxaImposto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Vias)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("VIAS");
            });

            modelBuilder.Entity<ConveniosCompleto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("convenios_completo");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(255)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep).HasColumnName("CEP");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(255)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(255)
                    .HasColumnName("CNPJ")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Complemento)
                    .HasMaxLength(255)
                    .HasColumnName("COMPLEMENTO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ddd).HasColumnName("DDD");

                entity.Property(e => e.EndereçoEletrônico)
                    .HasMaxLength(255)
                    .HasColumnName("ENDEREÇO ELETRÔNICO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fax).HasColumnName("FAX");

                entity.Property(e => e.Logradouro)
                    .HasMaxLength(255)
                    .HasColumnName("LOGRADOURO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(255)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(255)
                    .HasColumnName("NOME FANTASIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NºRegistroAns)
                    .HasMaxLength(255)
                    .HasColumnName("Nº REGISTRO ANS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Número).HasColumnName("NÚMERO");

                entity.Property(e => e.RazãoSocial)
                    .HasMaxLength(255)
                    .HasColumnName("RAZÃO SOCIAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone).HasColumnName("TELEFONE");

                entity.Property(e => e.Uf)
                    .HasMaxLength(255)
                    .HasColumnName("UF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ConveniosFaturado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("convenios_faturados");

                entity.Property(e => e.Arredonda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ARREDONDA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codesm)
                    .HasMaxLength(5)
                    .HasColumnName("codesm");

                entity.Property(e => e.Codesm2)
                    .HasMaxLength(10)
                    .HasColumnName("codesm2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Contato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTATO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dhe).HasColumnName("DHE");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Percentual)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("PERCENTUAL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Vias)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("VIAS");
            });

            modelBuilder.Entity<ConveniosUltimo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("convenios_ultimo");

                entity.Property(e => e.Arredonda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ARREDONDA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codesm)
                    .HasMaxLength(10)
                    .HasColumnName("codesm")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Contato)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CONTATO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dhe).HasColumnName("DHE");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Percentual)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("PERCENTUAL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Vias)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("VIAS");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Extension)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Notes)
                    .HasColumnType("text")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TitleOfCourtesy)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Encaminhamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Encaminhamento");

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Descricao).HasColumnType("ntext");

                entity.Property(e => e.Destino).HasColumnType("ntext");
            });

            modelBuilder.Entity<EntradaESaidum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("entrada_e_saida");

                entity.Property(e => e.Cod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cod")
                    .IsFixedLength();

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senha");
            });

            modelBuilder.Entity<ExamesBloqueado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exames_bloqueados");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Exame)
                    .HasMaxLength(5)
                    .HasColumnName("exame")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Faturamento>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("Faturamento");

                entity.Property(e => e.Cobrado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.DataNf)
                    .HasColumnType("datetime")
                    .HasColumnName("DataNF");

                entity.Property(e => e.DataPg).HasColumnType("datetime");

                entity.Property(e => e.Dtcobranca)
                    .HasColumnType("datetime")
                    .HasColumnName("dtcobranca");

                entity.Property(e => e.Fim).HasColumnType("datetime");

                entity.Property(e => e.Glosado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Inicio).HasColumnType("datetime");

                entity.Property(e => e.Mesref)
                    .HasMaxLength(5)
                    .HasColumnName("mesref")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nf)
                    .HasMaxLength(50)
                    .HasColumnName("nf")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(1000)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Pago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorRecursado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorRecursadoPago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Vencimento).HasColumnType("datetime");

                entity.Property(e => e.Vlimpostos)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("vlimpostos");
            });

            modelBuilder.Entity<FaturamentoPaga>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("FaturamentoPaga");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.CodigoFatura).HasColumnName("codigo_fatura");

                entity.Property(e => e.DataNota)
                    .HasColumnType("datetime")
                    .HasColumnName("data_nota");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("datetime")
                    .HasColumnName("data_pagamento");

                entity.Property(e => e.NumeroNota).HasColumnName("numero_nota");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("observacao");

                entity.Property(e => e.ValorGlosa)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_glosa");

                entity.Property(e => e.ValorImposto)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_imposto");

                entity.Property(e => e.ValorPagamento)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor_pagamento");

                entity.HasOne(d => d.CodigoFaturaNavigation)
                    .WithMany(p => p.FaturamentoPagas)
                    .HasForeignKey(d => d.CodigoFatura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FaturamentoPaga_Faturamento");
            });

            modelBuilder.Entity<Feriado>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Data)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descrição)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dia)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Forma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("formas");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(30)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADE");

                entity.Property(e => e.Cabfixo).HasColumnName("CABFIXO");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Grade1)
                    .HasMaxLength(8)
                    .HasColumnName("GRADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpGrade)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_GRADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(10)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Setor)
                    .HasMaxLength(2)
                    .HasColumnName("SETOR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tamcols).HasColumnName("TAMCOLS");

                entity.Property(e => e.Tamtotal).HasColumnName("TAMTOTAL");
            });

            modelBuilder.Entity<Gradecol>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADECOL");

                entity.Property(e => e.Codgrade).HasColumnName("CODGRADE");

                entity.Property(e => e.Exame)
                    .HasMaxLength(3)
                    .HasColumnName("EXAME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .HasColumnName("GRADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ordem).HasColumnName("ORDEM");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Tamanho).HasColumnName("TAMANHO");
            });

            modelBuilder.Entity<Gradesel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GRADESEL");

                entity.Property(e => e.Estacao)
                    .HasMaxLength(3)
                    .HasColumnName("ESTACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Grade)
                    .HasMaxLength(10)
                    .HasColumnName("GRADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Imprime).HasColumnName("IMPRIME");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<GrupoExame>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("grupo_exame");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Setor).HasColumnName("setor");
            });

            modelBuilder.Entity<GrupoMapa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("grupo_mapa");

                entity.Property(e => e.Apelido)
                    .HasMaxLength(2)
                    .HasColumnName("APELIDO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(2)
                    .HasColumnName("CODIGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cor01)
                    .HasMaxLength(70)
                    .HasColumnName("COR01")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cor02)
                    .HasMaxLength(150)
                    .HasColumnName("COR02")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(30)
                    .HasColumnName("GRUPO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpEtqd)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_ETQD")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpExm)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_EXM")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpGab)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_GAB")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpSpc)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_SPC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpUrg)
                    .HasMaxLength(1)
                    .HasColumnName("IMP_URG")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpressN)
                    .HasMaxLength(8)
                    .HasColumnName("IMPRESS_N")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ImpressU)
                    .HasMaxLength(8)
                    .HasColumnName("IMPRESS_U")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.MedRealiz)
                    .HasMaxLength(6)
                    .HasColumnName("MED_REALIZ")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Porcent).HasColumnName("PORCENT");

                entity.Property(e => e.Rotina1).HasColumnName("ROTINA1");

                entity.Property(e => e.Rotina2).HasColumnName("ROTINA2");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SaidaN)
                    .HasMaxLength(4)
                    .HasColumnName("SAIDA_N")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SaidaU)
                    .HasMaxLength(4)
                    .HasColumnName("SAIDA_U")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Setor01)
                    .HasMaxLength(130)
                    .HasColumnName("SETOR01")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Setor02)
                    .HasMaxLength(130)
                    .HasColumnName("SETOR02")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Setor03)
                    .HasMaxLength(130)
                    .HasColumnName("SETOR03")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TipoFat)
                    .HasMaxLength(1)
                    .HasColumnName("TIPO_FAT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Titan)
                    .HasMaxLength(1)
                    .HasColumnName("TITAN")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<GruposProduto>(entity =>
            {
                entity.HasKey(e => e.IdGrupo);

                entity.ToTable("grupos_produtos");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.DescricaoGrupo)
                    .HasMaxLength(50)
                    .HasColumnName("descricao_grupo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Guardum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GUARDA");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(6)
                    .HasColumnName("CODIGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.Nome)
                    .HasMaxLength(35)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Trace)
                    .HasColumnType("ntext")
                    .HasColumnName("TRACE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Histdoctors0>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("histdoctors0");

                entity.Property(e => e.Atributo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodMedico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaciente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataConsulta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Historico)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Histdoctors2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("histdoctors2");

                entity.Property(e => e.Atributo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodMedico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaciente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataConsulta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Historico).IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Historic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HISTORIC");

                entity.Property(e => e.Atributo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodMedico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaciente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataConsulta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Historico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observacao)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Flag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Obskit)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("obskit");
            });

            modelBuilder.Entity<KitsIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kits_Itens");

                entity.HasIndex(e => e.Kit, "fk_kititem");

                entity.HasIndex(e => e.Iditem, "prod2item");

                entity.HasIndex(e => e.Produto, "proditem");

                entity.Property(e => e.Iditem)
                    .HasColumnType("decimal(12, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("iditem");

                entity.Property(e => e.Obs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Procedimento).HasColumnName("PROCEDIMENTO");

                entity.Property(e => e.Proddilu).HasColumnName("proddilu");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Qtddilu).HasColumnName("qtddilu");

                entity.Property(e => e.Unid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unid");
            });

            modelBuilder.Entity<KitsProc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kits_Proc");

                entity.Property(e => e.Cidkit)
                    .HasMaxLength(10)
                    .HasColumnName("cidkit")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codkitproc)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codkitproc");

                entity.Property(e => e.Desckitproc)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Histclinkit)
                    .HasMaxLength(100)
                    .HasColumnName("histclinkit")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabelakit)
                    .HasMaxLength(30)
                    .HasColumnName("tabelakit")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Leito>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Numero)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PRONTUARIO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.UnidInternacao)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("UNID_INTERNACAO");
            });

            modelBuilder.Entity<Listagem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("listagem");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.CodigoColunas)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("CODIGO_COLUNAS");

                entity.Property(e => e.Codmapa).HasColumnName("codmapa");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Exame)
                    .HasMaxLength(10)
                    .HasColumnName("exame")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Folha).HasColumnName("folha");

                entity.Property(e => e.Impresso).HasColumnName("impresso");

                entity.Property(e => e.Mapa).HasColumnName("mapa");

                entity.Property(e => e.Requisicao)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("requisicao");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("CONTA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasColumnName("descricao");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<LogBd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logBD");

                entity.Property(e => e.Bd)
                    .HasMaxLength(50)
                    .HasColumnName("BD")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fim)
                    .HasColumnType("datetime")
                    .HasColumnName("fim");

                entity.Property(e => e.Inicio)
                    .HasColumnType("datetime")
                    .HasColumnName("inicio");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<LogInt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logINT");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("CONTA");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hora)
                    .HasColumnType("datetime")
                    .HasColumnName("hora");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.FlLivrocaixa).HasColumnName("fl_livrocaixa");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Login1)
                    .HasMaxLength(100)
                    .HasColumnName("Login")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeCompleto)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.RegProfis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("reg_profis")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Senha)
                    .HasMaxLength(30)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Siglaconselho)
                    .HasMaxLength(10)
                    .HasColumnName("siglaconselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TipoUsuario).HasColumnName("Tipo_Usuario");

                entity.Property(e => e.UfConselho)
                    .HasMaxLength(2)
                    .HasColumnName("UF_conselho")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UltimoAcesso)
                    .HasColumnType("datetime")
                    .HasColumnName("Ultimo_Acesso");
            });

            modelBuilder.Entity<MalaDiretum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.ComplEnd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COMPL_END")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONVENIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dtnasc)
                    .HasMaxLength(20)
                    .HasColumnName("DTNASC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endresp)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ENDRESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Foneresp)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FONERESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mae)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ocupacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OCUPACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Pai)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RG")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tel1)
                    .HasMaxLength(30)
                    .HasColumnName("tel1");

                entity.Property(e => e.Tel2)
                    .HasMaxLength(30)
                    .HasColumnName("tel2");

                entity.Property(e => e.Tel3)
                    .HasMaxLength(30)
                    .HasColumnName("tel3");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipologradouro).HasColumnName("tipologradouro");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Mapa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapas");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<MapaEspec>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAPA_ESPEC");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Mapaadm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mapaadm");

                entity.Property(e => e.Dtcoleta)
                    .HasMaxLength(10)
                    .HasColumnName("dtcoleta")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hrcoleta)
                    .HasMaxLength(10)
                    .HasColumnName("hrcoleta")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Idade).HasColumnName("idade");

                entity.Property(e => e.Nome)
                    .HasMaxLength(300)
                    .HasColumnName("nome")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Requisicao)
                    .HasMaxLength(20)
                    .HasColumnName("requisicao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result1)
                    .HasMaxLength(10)
                    .HasColumnName("result1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result2)
                    .HasMaxLength(10)
                    .HasColumnName("result2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result3)
                    .HasMaxLength(10)
                    .HasColumnName("result3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result4)
                    .HasMaxLength(10)
                    .HasColumnName("result4")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result5)
                    .HasMaxLength(10)
                    .HasColumnName("result5")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Result6)
                    .HasMaxLength(10)
                    .HasColumnName("result6")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<MatMedUnimed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mat_Med_Unimed");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col006)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Materiai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("materiais");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Matmed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matmed");

                entity.Property(e => e.Alteração).HasColumnType("smalldatetime");

                entity.Property(e => e.Compra)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Código)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data).HasColumnType("smalldatetime");

                entity.Property(e => e.Data1).HasColumnType("smalldatetime");

                entity.Property(e => e.Descrição)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dv)
                    .HasMaxLength(50)
                    .HasColumnName("DV")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Embalagem)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Especi)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fracionar)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.GrupodeEstoque)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Inclusão).HasColumnType("smalldatetime");

                entity.Property(e => e.MinistériodaSaúde)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Motivo)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nacional)
                    .HasMaxLength(1)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeComercial)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Origem)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ReutilizaçãoGenérico)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Situação)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TabUd)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Validade).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Matmedunimed1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("matmedunimed");

                entity.Property(e => e.Código).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeComercial)
                    .HasMaxLength(255)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Preço).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<MedAmbIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Med_Amb_Itens");

                entity.HasIndex(e => e.Registro, "im_registro");

                entity.HasIndex(e => e.Produto, "mai_convenio");

                entity.Property(e => e.CustoUnitario)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("custoUnitario");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrUnit).HasColumnName("PR_UNIT");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Qtd).HasColumnName("QTD");

                entity.Property(e => e.QtdUtilizada).HasColumnName("qtdUtilizada");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro).HasColumnName("REGISTRO");
            });

            modelBuilder.Entity<MedAmbMestre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Med_Amb_Mestre");

                entity.HasIndex(e => e.RegistroP, "mam_procedimento");

                entity.HasIndex(e => e.Prontuario, "mam_tabela");

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_MOVIM");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Posto)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("POSTO");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("PRONTUARIO");

                entity.Property(e => e.QtdItens)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("QTD_ITENS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.RegistroP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPago).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MedIntIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Med_Int_Itens");

                entity.Property(e => e.Item).HasColumnName("ITEM");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrUnit).HasColumnName("PR_UNIT");

                entity.Property(e => e.Produto).HasColumnName("PRODUTO");

                entity.Property(e => e.Qtd)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("QTD");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro).HasColumnName("REGISTRO");
            });

            modelBuilder.Entity<MedIntMestre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Med_Int_Mestre");

                entity.HasIndex(e => e.Prontuario, "Med_Int_Mestre2")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_MOVIM");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador)
                    .HasMaxLength(20)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Posto)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("POSTO");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PRONTUARIO");

                entity.Property(e => e.QtdItens)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("QTD_ITENS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.RegistroP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Requisicao)
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TotalPago).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Medic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MEDIC");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Medico>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Campainha).HasColumnName("CAMPAINHA");

                entity.Property(e => e.Crm)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CRM")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hrent1)
                    .HasColumnType("datetime")
                    .HasColumnName("hrent1");

                entity.Property(e => e.Hrent2)
                    .HasColumnType("datetime")
                    .HasColumnName("hrent2");

                entity.Property(e => e.Hrsai1)
                    .HasColumnType("datetime")
                    .HasColumnName("hrsai1");

                entity.Property(e => e.Hrsai2)
                    .HasColumnType("datetime")
                    .HasColumnName("hrsai2");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeCompleto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Modificaco>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Movimentacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("movimentacao");

                entity.Property(e => e.Banco).HasColumnName("banco");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShipName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShipPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShipRegion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.ProductId })
                    .HasName("PK_Order_Details");

                entity.ToTable("Order Details");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PACIENTE");

                entity.Property(e => e.Cep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodPaciente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtNascimento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Endereco)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flimportado).HasColumnName("flimportado");

                entity.Property(e => e.Fone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FoneAdicional)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mae)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Naturalidade)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Pai)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Paciente1>(entity =>
            {
                entity.HasKey(e => e.CodigoP)
                    .HasName("PK__Paciente__86EBD4961BDF3B0D");

                entity.ToTable("Pacientes");

                entity.Property(e => e.CodigoP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Altura)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("altura");

                entity.Property(e => e.Atualiza).HasColumnName("atualiza");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(10)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Codigolegado)
                    .HasMaxLength(30)
                    .HasColumnName("codigolegado")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ComplEnd)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("COMPL_END")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONVENIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .HasColumnName("cpf")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dtnasc)
                    .HasMaxLength(20)
                    .HasColumnName("DTNASC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dtobito)
                    .HasColumnType("datetime")
                    .HasColumnName("dtobito");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endresp)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ENDRESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatirdu)
                    .HasMaxLength(5)
                    .HasColumnName("fatirdu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatordu)
                    .HasMaxLength(5)
                    .HasColumnName("fatordu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatorrh)
                    .HasMaxLength(1)
                    .HasColumnName("fatorrh")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FlImportado).HasColumnName("fl_importado");

                entity.Property(e => e.Foneresp)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("FONERESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Gsang)
                    .HasMaxLength(5)
                    .HasColumnName("gsang")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mae)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Numero)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ocupacao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OCUPACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Pai)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("peso");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rg)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RG")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Statuscarteira).HasColumnName("statuscarteira");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(30)
                    .HasColumnName("telefone2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipologradouro).HasColumnName("tipologradouro");

                entity.Property(e => e.Uf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("UF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Unidade).HasColumnName("UNIDADE");
            });

            modelBuilder.Entity<PacientesConvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pacientes_Convenios");

                entity.Property(e => e.Atualiza).HasColumnName("atualiza");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .HasColumnName("CONVENIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dependencia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DEPENDENCIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMPRESA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guia)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATRICULA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente).HasColumnName("PACIENTE");

                entity.Property(e => e.Pacientenomeplano)
                    .HasMaxLength(50)
                    .HasColumnName("pacientenomeplano")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Titular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TITULAR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ultimo)
                    .HasMaxLength(50)
                    .HasColumnName("ULTIMO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Validade)
                    .HasMaxLength(50)
                    .HasColumnName("VALIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<PacientesExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Pacientes_Extra");

                entity.Property(e => e.Ecivil)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ECIVIL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endresp)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("ENDRESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mae)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MAE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nacional)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NACIONAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Natural)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NATURAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ocupacao)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OCUPACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente).HasColumnName("PACIENTE");

                entity.Property(e => e.Pai)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PAI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Responsavel)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Plan1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Plan1$");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(255)
                    .HasColumnName("AUTORIZACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Convênio)
                    .HasMaxLength(255)
                    .HasColumnName("CONVÊNIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.Guia).HasColumnName("GUIA");

                entity.Property(e => e.Matricula).HasColumnName("MATRICULA");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(255)
                    .HasColumnName("PACIENTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Plano)
                    .HasMaxLength(255)
                    .HasColumnName("PLANO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Principal).HasColumnName("PRINCIPAL");

                entity.Property(e => e.Procedimento)
                    .HasMaxLength(255)
                    .HasColumnName("PROCEDIMENTO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .HasColumnName("VALOR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Planvisual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("planvisual");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(255)
                    .HasColumnName("AUTORIZACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Conta).HasColumnName("CONTA");

                entity.Property(e => e.Convênio)
                    .HasMaxLength(255)
                    .HasColumnName("CONVÊNIO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.Guia)
                    .HasMaxLength(53)
                    .HasColumnName("GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(53)
                    .HasColumnName("MATRICULA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(255)
                    .HasColumnName("PACIENTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Plano)
                    .HasMaxLength(255)
                    .HasColumnName("PLANO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Principal)
                    .HasMaxLength(53)
                    .HasColumnName("PRINCIPAL")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Procedimento)
                    .HasMaxLength(255)
                    .HasColumnName("PROCEDIMENTO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Valor)
                    .HasMaxLength(255)
                    .HasColumnName("VALOR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Posto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Endereço)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeCompleto)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<Prescricao>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_prescricao_1");

                entity.ToTable("prescricao");

                entity.HasIndex(e => e.Codigo, "pk_prescricao");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Altura)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("altura");

                entity.Property(e => e.Ciclo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ciclo");

                entity.Property(e => e.Codigonet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigonet");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Datafinal)
                    .HasColumnType("datetime")
                    .HasColumnName("datafinal");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(4000)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dia)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dia");

                entity.Property(e => e.Dtexcpres)
                    .HasColumnType("datetime")
                    .HasColumnName("dtexcpres");

                entity.Property(e => e.DtexcpresC)
                    .HasColumnType("datetime")
                    .HasColumnName("dtexcpresC");

                entity.Property(e => e.Medico).HasColumnName("medico");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Paciente).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("peso");

                entity.Property(e => e.Presfinalizada).HasColumnName("presfinalizada");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("protocolo");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Supcorp)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("supcorp");

                entity.Property(e => e.Unidadeorigem).HasColumnName("unidadeorigem");

                entity.Property(e => e.Usufinal).HasColumnName("usufinal");

                entity.HasOne(d => d.MedicoNavigation)
                    .WithMany(p => p.Prescricaos)
                    .HasForeignKey(d => d.Medico)
                    .HasConstraintName("FK_prescricao_profissionais");

                entity.HasOne(d => d.PacienteNavigation)
                    .WithMany(p => p.Prescricaos)
                    .HasForeignKey(d => d.Paciente)
                    .HasConstraintName("FK_prescricao_Pacientes");

                entity.HasOne(d => d.UsufinalNavigation)
                    .WithMany(p => p.Prescricaos)
                    .HasForeignKey(d => d.Usufinal)
                    .HasConstraintName("FK_prescricao_Logins");
            });

            modelBuilder.Entity<ProcAmbIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proc_Amb_Itens");

                entity.HasIndex(e => e.Convenio, "I_convenio_pi");

                entity.HasIndex(e => e.Registro, "i_registro");

                entity.HasIndex(e => e.Convenio, "pai_convenio");

                entity.HasIndex(e => e.Profissional, "profissional");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Item)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ITEM");

                entity.Property(e => e.Percentual)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("PERCENTUAL");

                entity.Property(e => e.Profissional)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("PROFISSIONAL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TIPO");

                entity.Property(e => e.VlUnit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VL_UNIT");
            });

            modelBuilder.Entity<ProcAmbMestre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proc_Amb_Mestre");

                entity.HasIndex(e => new { e.Prontuario, e.RegistroP }, "Proc_Amb_Mestre3")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DtMovim, "dt_movim");

                entity.HasIndex(e => e.RegistroP, "i_registrop_pm");

                entity.HasIndex(e => e.Procedimento, "pam_procedimento");

                entity.HasIndex(e => e.Prontuario, "pam_tabela");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_MOVIM");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.FlSit).HasColumnName("fl_sit");

                entity.Property(e => e.HrFim)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_fim");

                entity.Property(e => e.HrInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_inicio");

                entity.Property(e => e.Procedimento)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PROCEDIMENTO");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRONTUARIO");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("QTD");

                entity.Property(e => e.QtdItens)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("QTD_ITENS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Reducaoacrescimo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reducaoacrescimo");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.RegistroP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tecnica).HasColumnName("tecnica");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.TotalPago).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Via).HasColumnName("via");
            });

            modelBuilder.Entity<ProcConvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proc_Convenios");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mascara)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MASCARA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");
            });

            modelBuilder.Entity<ProcIntIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proc_Int_Itens");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Item)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("ITEM");

                entity.Property(e => e.Material).HasColumnName("material");

                entity.Property(e => e.Percentual)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PERCENTUAL");

                entity.Property(e => e.Profissional)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("PROFISSIONAL");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("TIPO");

                entity.Property(e => e.Via)
                    .HasColumnName("via")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.VlUnit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("VL_UNIT");
            });

            modelBuilder.Entity<ProcIntMestre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Proc_Int_Mestre");

                entity.Property(e => e.Autori)
                    .HasMaxLength(20)
                    .HasColumnName("autori")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Coletador)
                    .HasMaxLength(20)
                    .HasColumnName("coletador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Dataaut)
                    .HasColumnType("datetime")
                    .HasColumnName("dataaut");

                entity.Property(e => e.DtColeta)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_coleta");

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_MOVIM");

                entity.Property(e => e.Faltamat).HasColumnName("faltamat");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.Guia)
                    .HasMaxLength(20)
                    .HasColumnName("guia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HrColeta)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_coleta");

                entity.Property(e => e.Impetiq).HasColumnName("IMPETIQ");

                entity.Property(e => e.Lamina)
                    .HasMaxLength(10)
                    .HasColumnName("lamina")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Procedimento)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PROCEDIMENTO");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PRONTUARIO");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("QTD");

                entity.Property(e => e.QtdItens)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("QTD_ITENS");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.RegistroP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Registroporigem)
                    .HasMaxLength(20)
                    .HasColumnName("REGISTROPORIGEM")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("TOTAL");

                entity.Property(e => e.TotalPago).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Urgente).HasColumnName("urgente");
            });

            modelBuilder.Entity<Procedimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("procedimentos");

                entity.Property(e => e.Autorizacao).HasColumnName("autorizacao");

                entity.Property(e => e.Auxiliares)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("AUXILIARES");

                entity.Property(e => e.Cdesp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cdesp");

                entity.Property(e => e.CodAmb).HasColumnName("cod_amb");

                entity.Property(e => e.CodAmb2).HasColumnName("cod_amb2");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(20)
                    .HasColumnName("COD_EXT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodRelacionado)
                    .HasMaxLength(20)
                    .HasColumnName("cod_relacionado")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigotabelatiss)
                    .HasMaxLength(5)
                    .HasColumnName("codigotabelatiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codtipoato).HasColumnName("codtipoato");

                entity.Property(e => e.Descri1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Exafatu)
                    .HasMaxLength(100)
                    .HasColumnName("exafatu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatorqtd2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("fatorqtd2");

                entity.Property(e => e.Filme)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("FILME");

                entity.Property(e => e.FlTextocomp)
                    .HasMaxLength(100)
                    .HasColumnName("fl_textocomp")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Honorarios)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("HONORARIOS");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Laudo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("LAUDO");

                entity.Property(e => e.Material)
                    .HasMaxLength(300)
                    .HasColumnName("material")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obc)
                    .HasMaxLength(100)
                    .HasColumnName("obc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(100)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operacional)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("OPERACIONAL");

                entity.Property(e => e.Preparo)
                    .HasMaxLength(300)
                    .HasColumnName("preparo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(50)
                    .HasColumnName("sigla");

                entity.Property(e => e.Sinonimia)
                    .HasMaxLength(300)
                    .HasColumnName("sinonimia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgencia).HasColumnName("urgencia");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("VALOR$");
            });

            modelBuilder.Entity<Procedimentosfulllab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("procedimentosfulllab");

                entity.HasIndex(e => e.Tabela, "PROCEDIMENTOS2")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.Autorizacao).HasColumnName("autorizacao");

                entity.Property(e => e.Auxiliares)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("AUXILIARES");

                entity.Property(e => e.CodAmb)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("COD_AMB");

                entity.Property(e => e.CodAmb2)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cod_amb2");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("COD_EXT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Exafatu)
                    .HasMaxLength(100)
                    .HasColumnName("exafatu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Filme)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("FILME");

                entity.Property(e => e.Honorarios)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("HONORARIOS");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Laudo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("LAUDO");

                entity.Property(e => e.Material)
                    .HasMaxLength(300)
                    .HasColumnName("material")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obc)
                    .HasMaxLength(100)
                    .HasColumnName("obc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(100)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operacional)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("OPERACIONAL");

                entity.Property(e => e.Preparo)
                    .HasMaxLength(300)
                    .HasColumnName("preparo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(3)
                    .HasColumnName("sigla");

                entity.Property(e => e.Sinonimia)
                    .HasMaxLength(300)
                    .HasColumnName("sinonimia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgencia).HasColumnName("urgencia");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("VALOR$");
            });

            modelBuilder.Entity<ProdConvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prod_Convenios");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mascara)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MASCARA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Revenda)
                    .HasColumnType("decimal(8, 4)")
                    .HasColumnName("REVENDA");
            });

            modelBuilder.Entity<ProdExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prod_Extra");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("COD_EXT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(16, 4)")
                    .HasColumnName("PRECO");

                entity.Property(e => e.Produto)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("PRODUTO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UltAlt)
                    .HasColumnType("datetime")
                    .HasColumnName("ULT_ALT");
            });

            modelBuilder.Entity<Prodkit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("prodkit");

                entity.Property(e => e.Apresentacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("apresentacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Conversao)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("conversao");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descri")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Flinativo).HasColumnName("flinativo");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.NumTiss)
                    .HasMaxLength(20)
                    .HasColumnName("num_tiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrVenda)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("pr_venda");

                entity.Property(e => e.Qtdpadrao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("qtdpadrao");

                entity.Property(e => e.Tabela).HasMaxLength(50);

                entity.Property(e => e.UnidCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_compra");

                entity.Property(e => e.UnidConsumo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_consumo");
            });

            modelBuilder.Entity<ProdkitPresc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("prodkitPresc");

                entity.Property(e => e.Apresentacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("apresentacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Conversao)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("conversao");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .HasColumnName("descri")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Flinativo).HasColumnName("flinativo");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.NumTiss)
                    .HasMaxLength(20)
                    .HasColumnName("num_tiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrVenda)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("pr_venda");

                entity.Property(e => e.Qtdpadrao).HasColumnName("qtdpadrao");

                entity.Property(e => e.Tabela).HasMaxLength(50);

                entity.Property(e => e.UnidCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_compra");

                entity.Property(e => e.UnidConsumo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_consumo");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.HasKey(e => e.Codident);

                entity.HasIndex(e => e.Codident, "I_prodCodIdent");

                entity.HasIndex(e => e.Codigo, "codprod");

                entity.HasIndex(e => e.Descri, "descprod");

                entity.HasIndex(e => e.Tabela, "tabprod");

                entity.HasIndex(e => e.Matmed, "tipoprod");

                entity.Property(e => e.Codident).HasColumnName("CODIDENT");

                entity.Property(e => e.Apresentacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APRESENTACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Brasindice)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BRASINDICE");

                entity.Property(e => e.CodAmb)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("COD_AMB");

                entity.Property(e => e.CodConv).HasMaxLength(20);

                entity.Property(e => e.Codanvisa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codanvisa");

                entity.Property(e => e.Codbarras)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("codbarras");

                entity.Property(e => e.Codfabricante).HasColumnName("codfabricante");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigotabelatiss)
                    .HasMaxLength(10)
                    .HasColumnName("codigotabelatiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Convant).HasColumnName("CONVANT");

                entity.Property(e => e.Convbb).HasColumnName("CONVBB");

                entity.Property(e => e.Conversao)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("CONVERSAO");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DescriResumida)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI_RESUMIDA");

                entity.Property(e => e.Divisor)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("DIVISOR");

                entity.Property(e => e.Dosagem)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dosagem");

                entity.Property(e => e.Flinativo)
                    .HasColumnName("flinativo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Flrepasse).HasColumnName("flrepasse");

                entity.Property(e => e.Grupo).HasColumnName("grupo");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.Livre)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("LIVRE");

                entity.Property(e => e.Localizacao)
                    .HasMaxLength(30)
                    .HasColumnName("localizacao");

                entity.Property(e => e.Matmed)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("MATMED");

                entity.Property(e => e.Minimo)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("MINIMO");

                entity.Property(e => e.Multiplicador)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("MULTIPLICADOR");

                entity.Property(e => e.NumTiss)
                    .HasMaxLength(20)
                    .HasColumnName("num_tiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrCusto)
                    .HasColumnType("numeric(14, 4)")
                    .HasColumnName("PR_CUSTO");

                entity.Property(e => e.PrVenda)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("PR_VENDA");

                entity.Property(e => e.PrVendaAnt)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("pr_venda_ant");

                entity.Property(e => e.ProdBase).HasColumnName("prod_base");

                entity.Property(e => e.ProdRef).HasColumnName("prod_ref");

                entity.Property(e => e.Qtdpadrao)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QTDPADRAO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Saldo)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("SALDO");

                entity.Property(e => e.Saldo0Qtd)
                    .HasColumnType("numeric(8, 2)")
                    .HasColumnName("SALDO0_QTD");

                entity.Property(e => e.Tabela).HasMaxLength(50);

                entity.Property(e => e.Tipodespesa).HasColumnName("tipodespesa");

                entity.Property(e => e.UnidCobranca)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_cobranca");

                entity.Property(e => e.UnidCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UNID_COMPRA");

                entity.Property(e => e.UnidConsumo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UNID_CONSUMO");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Produtos)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK_Produtos_grupos_produtos");
            });

            modelBuilder.Entity<ProdutosMovimentacao>(entity =>
            {
                entity.HasKey(e => e.Idmov);

                entity.ToTable("produtos_movimentacao");

                entity.HasIndex(e => e.Codproduto, "i_codproduto_mov");

                entity.Property(e => e.Idmov)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idmov");

                entity.Property(e => e.Codigopres).HasColumnName("codigopres");

                entity.Property(e => e.Coditempresc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("coditempresc");

                entity.Property(e => e.Codkit)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("codkit");

                entity.Property(e => e.Codproduto).HasColumnName("codproduto");

                entity.Property(e => e.Datamov)
                    .HasColumnType("datetime")
                    .HasColumnName("datamov");

                entity.Property(e => e.Flexecutado).HasColumnName("flexecutado");

                entity.Property(e => e.Horaaplicacao)
                    .HasColumnType("datetime")
                    .HasColumnName("horaaplicacao");

                entity.Property(e => e.Obsmov)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("obsmov");

                entity.Property(e => e.Qtdprod)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("qtdprod");

                entity.Property(e => e.Tabelaproduto)
                    .HasMaxLength(30)
                    .HasColumnName("tabelaproduto")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Unidproduto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unidproduto");

                entity.Property(e => e.Usukitconfi).HasColumnName("usukitconfi");

                entity.Property(e => e.Usumov).HasColumnName("usumov");

                entity.HasOne(d => d.CodigopresNavigation)
                    .WithMany(p => p.ProdutosMovimentacaos)
                    .HasForeignKey(d => d.Codigopres)
                    .HasConstraintName("FK_produtos_movimentacao_prescricao");

                entity.HasOne(d => d.CodprodutoNavigation)
                    .WithMany(p => p.ProdutosMovimentacaos)
                    .HasForeignKey(d => d.Codproduto)
                    .HasConstraintName("FK_ProdMov_Produtos");
            });

            modelBuilder.Entity<Profissionai>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("profissionais");

                entity.HasIndex(e => e.Codigo, "i_codigo_pr");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Atividades)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("ATIVIDADES");

                entity.Property(e => e.Bairro)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cbos)
                    .HasMaxLength(20)
                    .HasColumnName("cbos")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cbosantigo)
                    .HasMaxLength(10)
                    .HasColumnName("cbosantigo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cep)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("CEP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ConsultaDia).HasColumnName("consulta_dia");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("CPF")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DigitoRegProfis)
                    .HasMaxLength(3)
                    .HasColumnName("digito_reg_profis")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Especialidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ESPECIALIDADE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Estado)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FlLivrocaixa).HasColumnName("fl_livrocaixa");

                entity.Property(e => e.FlSolicitante).HasColumnName("fl_solicitante");

                entity.Property(e => e.FlagMedico)
                    .HasColumnName("flag_medico")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(1)
                    .HasColumnName("grupo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdWeb).HasColumnName("id_web");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Online)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ONLINE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ProcDia).HasColumnName("proc_dia");

                entity.Property(e => e.Producaom)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PRODUCAOM");

                entity.Property(e => e.Producaov)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("PRODUCAOV");

                entity.Property(e => e.RegProfis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REG_PROFIS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Samed)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("SAMED");

                entity.Property(e => e.Senha)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(50)
                    .HasColumnName("sigla")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Siglaconselho)
                    .HasMaxLength(10)
                    .HasColumnName("siglaconselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tratamento)
                    .HasMaxLength(50)
                    .HasColumnName("tratamento")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UfConselho)
                    .HasMaxLength(2)
                    .HasColumnName("UF_conselho")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.VlConsulta)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("VL_CONSULTA");
            });

            modelBuilder.Entity<ProfissionaisConvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Profissionais_Convenios");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Medico)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MEDICO");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<ProfissionaisExtra>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("profissionais_extra");

                entity.Property(e => e.Atende)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ATENDE")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.C01i)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("C01I");

                entity.Property(e => e.C01n)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("C01N");

                entity.Property(e => e.C01s)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("C01S")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.C02n)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("C02N");

                entity.Property(e => e.C02s)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("C02S")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.C03i)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("C03I");

                entity.Property(e => e.C03n)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("C03N");

                entity.Property(e => e.Co2i)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("CO2I");

                entity.Property(e => e.Medico)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("MEDICO");

                entity.Property(e => e.Taxaa)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("TAXAA");

                entity.Property(e => e.Taxai)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("TAXAI");

                entity.Property(e => e.Tipoa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPOA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipoi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TIPOI")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Qual>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Qual");

                entity.Property(e => e.CoDigo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Co'digo")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CoE29)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Co?E29")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col002)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col004)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col005AGGEr)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Col005?,A?G??????????G?Er")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exame)
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.GEr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("???????G?Er")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.GEr1)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("????G?Er")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mne)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName(" Mne")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.RotinaAcuAcido)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName(" Rotina\r\n ACU ACIDO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Receita>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigonet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigonet");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(30)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Texto)
                    .HasMaxLength(4000)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Unidadeorigem).HasColumnName("unidadeorigem");
            });

            modelBuilder.Entity<Recepcao>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Recepcao__06370DAD2B8DA8C7");

                entity.ToTable("Recepcao");

                entity.HasIndex(e => e.Codigo, "i_codrecepcao");

                entity.HasIndex(e => e.Codigonet, "i_codrecepcaonet");

                entity.HasIndex(e => e.Data, "i_datarecepcao");

                entity.HasIndex(e => e.Medico, "i_medrecepcao");

                entity.HasIndex(e => e.Registrop, "i_registroprecepcao");

                entity.HasIndex(e => e.Status, "i_statusrecepcao");

                entity.HasIndex(e => e.Statusnet, "i_statusrecepcaonet");

                entity.Property(e => e.Agendaunidade).HasColumnName("agendaunidade");

                entity.Property(e => e.Codigonet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigonet");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Enviousms).HasColumnName("enviousms");

                entity.Property(e => e.FlImportado).HasColumnName("fl_importado");

                entity.Property(e => e.HrAtend).HasColumnType("datetime");

                entity.Property(e => e.HrChega).HasColumnType("datetime");

                entity.Property(e => e.Hrmarcada)
                    .HasColumnType("datetime")
                    .HasColumnName("hrmarcada");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Registrop)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("registrop");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Unidadeorigem).HasColumnName("unidadeorigem");
            });

            modelBuilder.Entity<RecepcaoInternacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("recepcao_internacao");

                entity.Property(e => e.Altura)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("altura");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(50)
                    .HasColumnName("autorizacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Carater).HasColumnName("carater");

                entity.Property(e => e.Cid10)
                    .HasMaxLength(10)
                    .HasColumnName("cid10")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.CodigoRepasse).HasColumnName("codigo_repasse");

                entity.Property(e => e.Conta).HasColumnType("decimal(22, 0)");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Dadosclinicos)
                    .HasMaxLength(100)
                    .HasColumnName("dadosclinicos")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data0)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA0");

                entity.Property(e => e.Data1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA1");

                entity.Property(e => e.Diariasaut)
                    .HasMaxLength(10)
                    .HasColumnName("diariasaut")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Diariassol)
                    .HasMaxLength(10)
                    .HasColumnName("diariassol")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Docinc).HasColumnName("docinc");

                entity.Property(e => e.DtAut)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_aut");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatirdu)
                    .HasMaxLength(5)
                    .HasColumnName("fatirdu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatorrh)
                    .HasMaxLength(1)
                    .HasColumnName("fatorrh")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("FATURA");

                entity.Property(e => e.Gsang)
                    .HasMaxLength(5)
                    .HasColumnName("gsang")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hora0)
                    .HasColumnType("datetime")
                    .HasColumnName("HORA0");

                entity.Property(e => e.Hora1)
                    .HasColumnType("datetime")
                    .HasColumnName("HORA1");

                entity.Property(e => e.Leito)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LEITO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Localatend).HasColumnName("localatend");

                entity.Property(e => e.Medautor).HasColumnName("medautor");

                entity.Property(e => e.Medicamentos)
                    .HasMaxLength(100)
                    .HasColumnName("medicamentos")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Medico).HasColumnName("medico");

                entity.Property(e => e.Minuto0)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MINUTO0");

                entity.Property(e => e.Minuto1)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MINUTO1");

                entity.Property(e => e.Motivosaida).HasColumnName("motivosaida");

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .HasColumnName("nota")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(100)
                    .HasColumnName("observacoes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR0")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(22, 0)")
                    .HasColumnName("PACIENTE");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("peso");

                entity.Property(e => e.Posto)
                    .HasMaxLength(3)
                    .HasColumnName("posto")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Prontos).HasColumnName("prontos");

                entity.Property(e => e.Regime).HasColumnName("regime");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.Senhaonline)
                    .HasMaxLength(30)
                    .HasColumnName("senhaonline")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.TipoAcomodacao).HasColumnName("tipo_acomodacao");

                entity.Property(e => e.TipoAtend).HasColumnName("Tipo_Atend");

                entity.Property(e => e.Tipointernacao).HasColumnName("tipointernacao");

                entity.Property(e => e.Tiposaida).HasColumnName("tiposaida");

                entity.Property(e => e.UnidInternacao)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("UNID_INTERNACAO");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(3)
                    .HasColumnName("unidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgente).HasColumnName("urgente");
            });

            modelBuilder.Entity<RecepcaoLab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recepcao_lab");

                entity.Property(e => e.Altura)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("altura");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(50)
                    .HasColumnName("autorizacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Carater).HasColumnName("carater");

                entity.Property(e => e.Cid10)
                    .HasMaxLength(10)
                    .HasColumnName("cid10")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.CodigoRepasse).HasColumnName("codigo_repasse");

                entity.Property(e => e.Conta).HasColumnType("decimal(22, 0)");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Dadosclinicos)
                    .HasMaxLength(100)
                    .HasColumnName("dadosclinicos")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data0)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA0");

                entity.Property(e => e.Data1)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA1");

                entity.Property(e => e.Diariasaut)
                    .HasMaxLength(10)
                    .HasColumnName("diariasaut")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Diariassol)
                    .HasMaxLength(10)
                    .HasColumnName("diariassol")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Docinc).HasColumnName("docinc");

                entity.Property(e => e.DtAut)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dt_aut");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatirdu)
                    .HasMaxLength(5)
                    .HasColumnName("fatirdu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatorrh)
                    .HasMaxLength(1)
                    .HasColumnName("fatorrh")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("FATURA");

                entity.Property(e => e.Gsang)
                    .HasMaxLength(5)
                    .HasColumnName("gsang")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hora0)
                    .HasColumnType("datetime")
                    .HasColumnName("HORA0");

                entity.Property(e => e.Hora1)
                    .HasColumnType("datetime")
                    .HasColumnName("HORA1");

                entity.Property(e => e.Leito)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LEITO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Localatend).HasColumnName("localatend");

                entity.Property(e => e.Medautor).HasColumnName("medautor");

                entity.Property(e => e.Medicamentos)
                    .HasMaxLength(100)
                    .HasColumnName("medicamentos")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Medico).HasColumnName("medico");

                entity.Property(e => e.Minuto0)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MINUTO0");

                entity.Property(e => e.Minuto1)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("MINUTO1");

                entity.Property(e => e.Motivosaida).HasColumnName("motivosaida");

                entity.Property(e => e.Nota)
                    .HasMaxLength(100)
                    .HasColumnName("nota")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Observacao)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Observacoes)
                    .HasMaxLength(100)
                    .HasColumnName("observacoes")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR0")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(22, 0)")
                    .HasColumnName("PACIENTE");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("peso");

                entity.Property(e => e.Posto)
                    .HasMaxLength(3)
                    .HasColumnName("posto")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Prontos).HasColumnName("prontos");

                entity.Property(e => e.Regime).HasColumnName("regime");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.Senhaonline)
                    .HasMaxLength(30)
                    .HasColumnName("senhaonline")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.TipoAcomodacao).HasColumnName("tipo_acomodacao");

                entity.Property(e => e.TipoAtend).HasColumnName("Tipo_Atend");

                entity.Property(e => e.Tipointernacao).HasColumnName("tipointernacao");

                entity.Property(e => e.Tiposaida).HasColumnName("tiposaida");

                entity.Property(e => e.UnidInternacao)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("UNID_INTERNACAO");

                entity.Property(e => e.Unidade)
                    .HasMaxLength(3)
                    .HasColumnName("unidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgente).HasColumnName("urgente");
            });

            modelBuilder.Entity<RecepcaoMestre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Recepcao_Mestre");

                entity.HasIndex(e => e.Conta, "conta");

                entity.HasIndex(e => e.Convenio, "convconta");

                entity.HasIndex(e => e.Data, "dataconta");

                entity.HasIndex(e => e.Fatura, "faturaconta");

                entity.HasIndex(e => e.Paciente, "i_pac_recmestre");

                entity.HasIndex(e => e.Paciente, "pacienteconta");

                entity.HasIndex(e => e.Registro, "registroconta");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(30)
                    .HasColumnName("autorizacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cid10)
                    .HasMaxLength(10)
                    .HasColumnName("cid10")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodigoRepasse).HasColumnName("codigo_repasse");

                entity.Property(e => e.Conta).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("CONVENIO");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA");

                entity.Property(e => e.Dataok)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dataok");

                entity.Property(e => e.DtAut)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_aut");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("FATURA");

                entity.Property(e => e.FlOnline).HasColumnName("fl_online");

                entity.Property(e => e.Guia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GUIA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guiaprincipal)
                    .HasMaxLength(20)
                    .HasColumnName("guiaprincipal")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HoraAtend).HasColumnType("datetime");

                entity.Property(e => e.HoraCheg).HasColumnType("datetime");

                entity.Property(e => e.Medatend).HasColumnName("medatend");

                entity.Property(e => e.Medico)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("MEDICO");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obsagenda)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("obsagenda");

                entity.Property(e => e.Operador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OPERADOR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("PACIENTE");

                entity.Property(e => e.PkLegada)
                    .HasMaxLength(50)
                    .HasColumnName("pk_legada")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Prescricao).HasColumnName("prescricao");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REGISTRO");

                entity.Property(e => e.Repasseprod)
                    .HasColumnName("repasseprod")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Repasseserv)
                    .HasColumnName("repasseserv")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Tempodoenca).HasColumnName("tempodoenca");

                entity.Property(e => e.TipoAtend).HasColumnName("Tipo_Atend");

                entity.Property(e => e.TipoFat).HasColumnName("tipo_fat");

                entity.Property(e => e.Tipoconsulta).HasColumnName("tipoconsulta");

                entity.Property(e => e.Tiposaida).HasColumnName("tiposaida");

                entity.Property(e => e.Unidadetempo)
                    .HasMaxLength(2)
                    .HasColumnName("unidadetempo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<RepasseHonor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Repasse_Honor");

                entity.Property(e => e.Cobrado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Fatura).HasColumnName("fatura");

                entity.Property(e => e.Glosado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Profissional).HasColumnName("profissional");

                entity.Property(e => e.Repasse).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<RequisicaoInterface>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Requisicao_Interface");

                entity.Property(e => e.Data)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("data");

                entity.Property(e => e.Exame)
                    .HasMaxLength(10)
                    .HasColumnName("exame")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hora)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("hora");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cod00)
                    .HasMaxLength(11)
                    .HasColumnName("cod_00")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codgrp)
                    .HasMaxLength(4)
                    .HasColumnName("codgrp")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .HasColumnName("codigo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codimp)
                    .HasMaxLength(3)
                    .HasColumnName("codimp")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codlst)
                    .HasMaxLength(2)
                    .HasColumnName("codlst")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codset)
                    .HasMaxLength(2)
                    .HasColumnName("codset")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Colheita)
                    .HasColumnType("ntext")
                    .HasColumnName("colheita")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dd)
                    .HasMaxLength(3)
                    .HasColumnName("dd")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exame)
                    .HasMaxLength(27)
                    .HasColumnName("exame")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exm0)
                    .HasColumnType("ntext")
                    .HasColumnName("exm0")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exm1)
                    .HasColumnType("ntext")
                    .HasColumnName("exm1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exm2)
                    .HasColumnType("ntext")
                    .HasColumnName("exm2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatmed00).HasColumnName("fatmed_00");

                entity.Property(e => e.Fltr)
                    .HasMaxLength(45)
                    .HasColumnName("fltr")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Gab0)
                    .HasColumnType("ntext")
                    .HasColumnName("gab0")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Gab1)
                    .HasColumnType("ntext")
                    .HasColumnName("gab1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hst1)
                    .HasMaxLength(3)
                    .HasColumnName("hst1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hst2)
                    .HasMaxLength(3)
                    .HasColumnName("hst2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Hst3)
                    .HasMaxLength(3)
                    .HasColumnName("hst3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Impexm)
                    .HasMaxLength(1)
                    .HasColumnName("impexm")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mtfilm00).HasColumnName("mtfilm_00");

                entity.Property(e => e.Ordetq)
                    .HasMaxLength(3)
                    .HasColumnName("ordetq")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.OrdetqT)
                    .HasMaxLength(3)
                    .HasColumnName("ordetq_t")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Ordimp)
                    .HasMaxLength(4)
                    .HasColumnName("ordimp")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .HasColumnName("sexo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Val00).HasColumnName("val_00");
            });

            modelBuilder.Entity<Setor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Setor");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Setor1)
                    .HasMaxLength(50)
                    .HasColumnName("Setor")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<SetorExame>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("setor_exame");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .HasColumnName("nome")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(5)
                    .HasColumnName("sigla")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STATUS");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Interno)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("interno")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tipo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<StatusFatura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Status_Fatura");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Statuscarteira>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("statuscarteira");

                entity.Property(e => e.Descstatuscart)
                    .HasMaxLength(200)
                    .HasColumnName("descstatuscart");

                entity.Property(e => e.Idstatuscart).HasColumnName("idstatuscart");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ContactTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HomePage)
                    .HasColumnType("text")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TabGolden>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tab_Golden");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cnpj")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodAutor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cod_autor")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Controle)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("controle")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Natureza)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("natureza")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo).HasColumnName("tipo");

                entity.Property(e => e.Urgencia)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("urgencia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TabHap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tab_Hap");

                entity.Property(e => e.Conta)
                    .HasMaxLength(30)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Senha)
                    .HasMaxLength(30)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TabUnimed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tab_Unimed");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Crm)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("crm");

                entity.Property(e => e.Guia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("guia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("matricula")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Rg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rg")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Tablac>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tablac");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col002)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Col004)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Exame)
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Honorarios)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Resto1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("resto1")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Resto2)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("resto2")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Resto3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("resto3")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.RotinaAcuAcido)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName(" Rotina\r\n ACU ACIDO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("sigla")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TbAnamnese>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbAnamnese");

                entity.Property(e => e.Antfamil)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("antfamil");

                entity.Property(e => e.Antpess)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("antpess");

                entity.Property(e => e.Codanamnese)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codanamnese");

                entity.Property(e => e.Codpaciente)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codpaciente");

                entity.Property(e => e.Conduta)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("conduta");

                entity.Property(e => e.Estadiam)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("estadiam");

                entity.Property(e => e.Hipotdiag)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("hipotdiag");

                entity.Property(e => e.Histatual)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("histatual");

                entity.Property(e => e.Identanam)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("identanam");
            });

            modelBuilder.Entity<TbAtendimento>(entity =>
            {
                entity.HasKey(e => new { e.CdPaciente, e.NrAtendimento })
                    .HasName("PK_ATENDIMENTO");

                entity.ToTable("TB_ATENDIMENTO");

                entity.Property(e => e.CdPaciente)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CD_PACIENTE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrAtendimento)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NR_ATENDIMENTO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CdModoEvento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CD_MODO_EVENTO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CdMotivoSaida)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CD_MOTIVO_SAIDA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CdOperadora)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CD_OPERADORA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CdPadraoAcomodacao)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CD_PADRAO_ACOMODACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CdPlano)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CD_PLANO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DsSituacaoClinica)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DS_SITUACAO_CLINICA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DtFimAtendimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_FIM_ATENDIMENTO");

                entity.Property(e => e.DtFinalizado)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_FINALIZADO");

                entity.Property(e => e.DtIniAtendimento)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INI_ATENDIMENTO");

                entity.Property(e => e.DtIniVigenciaContrato)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_INI_VIGENCIA_CONTRATO");

                entity.Property(e => e.InAcidente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_ACIDENTE")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InCaraterAtendimento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_CARATER_ATENDIMENTO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InCaraterInternado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_CARATER_INTERNADO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InCidNotificavel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_CID_NOTIFICAVEL")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InFinalizado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_FINALIZADO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InTipoDoenca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IN_TIPO_DOENCA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.InTipoInternacao)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IN_TIPO_INTERNACAO")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrCartaoSaude)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NR_CARTAO_SAUDE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrCidObito)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NR_CID_OBITO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrContratoOperadora)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("NR_CONTRATO_OPERADORA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrDeclaracaoObito)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NR_DECLARACAO_OBITO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NrTempoEvolucaoDoenca)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NR_TEMPO_EVOLUCAO_DOENCA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UnTempoEvolucaoDoenca)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("UN_TEMPO_EVOLUCAO_DOENCA")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TbConsultaProfCon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbConsultaProfCon");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(20)
                    .HasColumnName("cod_ext")
                    .IsFixedLength();

                entity.Property(e => e.CodigoProf).HasColumnName("codigo_prof");

                entity.Property(e => e.Convenio)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("convenio");
            });

            modelBuilder.Entity<TbConsultaProfConv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbConsultaProfConv");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(40)
                    .HasColumnName("cod_ext")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodigoProf).HasColumnName("codigo_prof");

                entity.Property(e => e.Convenio)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("convenio");
            });

            modelBuilder.Entity<TbEntSaiProd>(entity =>
            {
                entity.HasKey(e => e.IdMovimento);

                entity.ToTable("tbEntSaiProd");

                entity.HasIndex(e => e.DtMovimento, "I_EntSaiProd");

                entity.HasIndex(e => e.TipoMovimento, "I_tbEntSaiProd");

                entity.Property(e => e.IdMovimento).HasColumnName("idMovimento");

                entity.Property(e => e.Descontos)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("descontos");

                entity.Property(e => e.Destino).HasColumnName("destino");

                entity.Property(e => e.DtCompra)
                    .HasColumnType("datetime")
                    .HasColumnName("dtCompra");

                entity.Property(e => e.DtEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("dtEntrega");

                entity.Property(e => e.DtMovimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtMovimento");

                entity.Property(e => e.DtVencimento)
                    .HasColumnType("datetime")
                    .HasColumnName("dtVencimento");

                entity.Property(e => e.FlFinalizada).HasColumnName("fl_finalizada");

                entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");

                entity.Property(e => e.Impostos)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("impostos");

                entity.Property(e => e.NotaFiscal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("notaFiscal");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Origem).HasColumnName("origem");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("paciente");

                entity.Property(e => e.Prescricao).HasColumnName("prescricao");

                entity.Property(e => e.Temperatura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("temperatura");

                entity.Property(e => e.TipoMovimento).HasColumnName("tipoMovimento");

                entity.Property(e => e.Usumov).HasColumnName("usumov");

                entity.Property(e => e.ValorFrete)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valorFrete");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("valorTotal");

                entity.HasOne(d => d.DestinoNavigation)
                    .WithMany(p => p.TbEntSaiProdDestinoNavigations)
                    .HasForeignKey(d => d.Destino);

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbEntSaiProds)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("FK_tbEntSaiProd_tbFornecedor");

                entity.HasOne(d => d.OrigemNavigation)
                    .WithMany(p => p.TbEntSaiProdOrigemNavigations)
                    .HasForeignKey(d => d.Origem);

                entity.HasOne(d => d.PacienteNavigation)
                    .WithMany(p => p.TbEntSaiProds)
                    .HasForeignKey(d => d.Paciente)
                    .HasConstraintName("FK_tbEntSaiProd_Pacientes");

                entity.HasOne(d => d.PrescricaoNavigation)
                    .WithMany(p => p.TbEntSaiProds)
                    .HasForeignKey(d => d.Prescricao)
                    .HasConstraintName("FK_tbEntSaiProd_prescricao");

                entity.HasOne(d => d.TipoMovimentoNavigation)
                    .WithMany(p => p.TbEntSaiProds)
                    .HasForeignKey(d => d.TipoMovimento)
                    .HasConstraintName("FK_tbEntSaiProd_tbTipoMovimento");
            });

            modelBuilder.Entity<TbEntSaiProdIten>(entity =>
            {
                entity.HasKey(e => e.IdMovimentoItem);

                entity.ToTable("tbEntSaiProdItens");

                entity.HasIndex(e => e.IdProduto, "Index_idProduto");

                entity.HasIndex(e => e.Lote, "Index_lote");

                entity.Property(e => e.IdMovimentoItem).HasColumnName("idMovimentoItem");

                entity.Property(e => e.DtFabricacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtFabricacao");

                entity.Property(e => e.DtValidade)
                    .HasColumnType("datetime")
                    .HasColumnName("dtValidade");

                entity.Property(e => e.Fabricante).HasColumnName("fabricante");

                entity.Property(e => e.FlExecutado)
                    .HasColumnName("fl_executado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagBaixa).HasColumnName("flag_baixa");

                entity.Property(e => e.IdMovimento).HasColumnName("idMovimento");

                entity.Property(e => e.IdProdMov)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("idProdMov");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.PrecoUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QtdProduto)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("qtdProduto");

                entity.HasOne(d => d.FabricanteNavigation)
                    .WithMany(p => p.TbEntSaiProdItens)
                    .HasForeignKey(d => d.Fabricante)
                    .HasConstraintName("FK__tbEntSaiP__fabri__692D4C44");

                entity.HasOne(d => d.IdMovimentoNavigation)
                    .WithMany(p => p.TbEntSaiProdItens)
                    .HasForeignKey(d => d.IdMovimento)
                    .HasConstraintName("FK_tbEntSaiProdItens_tbEntSaiProd");

                entity.HasOne(d => d.IdProdMovNavigation)
                    .WithMany(p => p.TbEntSaiProdItens)
                    .HasForeignKey(d => d.IdProdMov)
                    .HasConstraintName("FK_tbEntSaiProdItens_produtos_movimentacao");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbEntSaiProdItens)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_tbEntSaiProdItens_Produtos");
            });

            modelBuilder.Entity<TbEstoqueProduto>(entity =>
            {
                entity.HasKey(e => new { e.IdProduto, e.IdLocal, e.Lote });

                entity.ToTable("tbEstoqueProdutos");

                entity.HasIndex(e => e.IdLocal, "IdxLocal");

                entity.HasIndex(e => e.Qtd, "IdxQtd");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.IdLocal).HasColumnName("idLocal");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lote");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.HasOne(d => d.IdLocalNavigation)
                    .WithMany(p => p.TbEstoqueProdutos)
                    .HasForeignKey(d => d.IdLocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEstoqueProdutos_tbLocalEstoque");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbEstoqueProdutos)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbEstoqueProdutos_Produtos");
            });

            modelBuilder.Entity<TbFabricante>(entity =>
            {
                entity.HasKey(e => e.IdFabricante)
                    .HasName("PK__tbFabric__6E91D599202D7450");

                entity.ToTable("tbFabricante");

                entity.Property(e => e.IdFabricante).HasColumnName("idFabricante");

                entity.Property(e => e.DescFabricante)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descFabricante");
            });

            modelBuilder.Entity<TbFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor);

                entity.ToTable("tbFornecedor");

                entity.Property(e => e.IdFornecedor).HasColumnName("idFornecedor");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                entity.Property(e => e.CodigoTerceiro).HasColumnName("codigoTerceiro");

                entity.Property(e => e.ContatoFornecedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescFornecedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFornecedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelFornecedor)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLocalEstoque>(entity =>
            {
                entity.HasKey(e => e.IdLocalEstoque)
                    .HasName("PK_tbLocalEstoque_1");

                entity.ToTable("tbLocalEstoque");

                entity.Property(e => e.IdLocalEstoque).HasColumnName("idLocalEstoque");

                entity.Property(e => e.Local)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("local");
            });

            modelBuilder.Entity<TbLog>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("tbLog");

                entity.Property(e => e.IdLog).HasColumnName("idLog");

                entity.Property(e => e.DataLog)
                    .HasColumnType("datetime")
                    .HasColumnName("dataLog");

                entity.Property(e => e.DescricaoLog)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("descricaoLog");

                entity.Property(e => e.UsuarioLog).HasColumnName("usuarioLog");

                entity.HasOne(d => d.UsuarioLogNavigation)
                    .WithMany(p => p.TbLogs)
                    .HasForeignKey(d => d.UsuarioLog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbLog_Logins");
            });

            modelBuilder.Entity<TbMotivoSaidaInternacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_MOTIVO_SAIDA_INTERNACAO");

                entity.Property(e => e.CdMotivoSaida)
                    .HasMaxLength(2)
                    .HasColumnName("CD_MOTIVO_SAIDA");

                entity.Property(e => e.CdTipoMotivo)
                    .HasMaxLength(1)
                    .HasColumnName("CD_TIPO_MOTIVO");

                entity.Property(e => e.NmMotivoSaida)
                    .HasMaxLength(200)
                    .HasColumnName("NM_MOTIVO_SAIDA");
            });

            modelBuilder.Entity<TbPreProdRepasse>(entity =>
            {
                entity.HasKey(e => e.IdPreprodrepasse)
                    .HasName("PK__tbPrePro__4DF504FF85381461");

                entity.ToTable("tbPreProdRepasse");

                entity.HasIndex(e => e.DtEntrega, "i_dt_entrega");

                entity.Property(e => e.IdPreprodrepasse).HasColumnName("id_preprodrepasse");

                entity.Property(e => e.Codident).HasColumnName("codident");

                entity.Property(e => e.DtEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_entrega");

                entity.Property(e => e.NumTiss)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("num_tiss");

                entity.Property(e => e.Precounit)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("precounit");

                entity.HasOne(d => d.CodidentNavigation)
                    .WithMany(p => p.TbPreProdRepasses)
                    .HasForeignKey(d => d.Codident)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbPreProdRepasse_produtos");
            });

            modelBuilder.Entity<TbProdutosCobranca>(entity =>
            {
                entity.HasKey(e => e.IdProdCobranca)
                    .HasName("PK__tbProdut__B2BFCBF29A95F65D");

                entity.ToTable("tbProdutosCobranca");

                entity.Property(e => e.IdProdCobranca).HasColumnName("idProdCobranca");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.IdMovimentoItem).HasColumnName("idMovimentoItem");

                entity.Property(e => e.IdPrescricao).HasColumnName("idPrescricao");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.TotalUsado)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("totalUsado");

                entity.HasOne(d => d.IdPrescricaoNavigation)
                    .WithMany(p => p.TbProdutosCobrancas)
                    .HasForeignKey(d => d.IdPrescricao)
                    .HasConstraintName("FK__tbProduto__idPre__6C6814F4");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbProdutosCobrancas)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK__tbProduto__idPro__6D5C392D");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.TbProdutosCobrancas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__tbProduto__idUsu__6E505D66");
            });

            modelBuilder.Entity<TbProdutosConvenio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbProdutosConvenios");

                entity.Property(e => e.ProdutoConvenio).HasColumnName("produtoConvenio");

                entity.Property(e => e.ProdutoEstoque).HasColumnName("produtoEstoque");

                entity.HasOne(d => d.ProdutoConvenioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ProdutoConvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdutoConvenio_Produtos");

                entity.HasOne(d => d.ProdutoEstoqueNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ProdutoEstoque)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdutoEstoque_Produtos");
            });

            modelBuilder.Entity<TbProfConvRepasse>(entity =>
            {
                entity.HasKey(e => e.IdProfConvRepasse)
                    .HasName("PK__tbProfCo__6E66719CC976522A");

                entity.ToTable("tbProfConvRepasse");

                entity.Property(e => e.IdProfConvRepasse).HasColumnName("idProfConvRepasse");

                entity.Property(e => e.Codprof).HasColumnName("codprof");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.Vlrepasse)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("vlrepasse");
            });

            modelBuilder.Entity<TbRepasse>(entity =>
            {
                entity.HasKey(e => e.CodRepasse)
                    .HasName("PK__tbRepass__190EAF4C9C794153");

                entity.ToTable("tbRepasse");

                entity.Property(e => e.CodRepasse).HasColumnName("cod_repasse");

                entity.Property(e => e.CustoTotal)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("custo_total");

                entity.Property(e => e.DataRepasse)
                    .HasColumnType("datetime")
                    .HasColumnName("data_repasse");

                entity.Property(e => e.RepasseTotal)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("repasse_total");

                entity.Property(e => e.TotalPago)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("total_pago");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            modelBuilder.Entity<TbTipoMovimento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimento);

                entity.ToTable("tbTipoMovimento");

                entity.Property(e => e.IdTipoMovimento)
                    .ValueGeneratedNever()
                    .HasColumnName("idTipoMovimento");

                entity.Property(e => e.DescTipoMovimento)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descTipoMovimento");
            });

            modelBuilder.Entity<TbaplicaPlanTerap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBAplicaPlanTerap");

                entity.Property(e => e.AlturaAplica).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bsaaplica)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("BSAAPlica");

                entity.Property(e => e.DescAplicacao)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DtAplicacao).HasColumnType("datetime");

                entity.Property(e => e.FlImportado).HasColumnName("fl_importado");

                entity.Property(e => e.Hdaaplicacao)
                    .HasMaxLength(4000)
                    .HasColumnName("HDAAplicacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdaplicaPlanTerap)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDAplicaPlanTerap");

                entity.Property(e => e.IdplanTerap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IDPlanTerap");

                entity.Property(e => e.PesoAplica).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sequencia)
                    .HasMaxLength(10)
                    .HasColumnName("sequencia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TbaplicaPlanTerapIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBAplicaPlanTerapItens");

                entity.Property(e => e.Codproduto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codproduto");

                entity.Property(e => e.IdaplicaPlanTerap)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("IDAplicaPlanTerap");

                entity.Property(e => e.IdaplicaPlanTerapItens)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDAPlicaPlanTerapItens");

                entity.Property(e => e.Qtddose).HasColumnName("qtddose");

                entity.Property(e => e.Qtdplaneja).HasColumnName("qtdplaneja");

                entity.Property(e => e.Qtdproduto).HasColumnName("qtdproduto");

                entity.Property(e => e.UnidadeAplica)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UnidadeDose)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Tbdocspaciente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbdocspaciente");

                entity.Property(e => e.Arqdoc)
                    .HasMaxLength(300)
                    .HasColumnName("arqdoc");

                entity.Property(e => e.Coddoc)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("coddoc");

                entity.Property(e => e.Codpaciente).HasColumnName("codpaciente");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Dtdoc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dtdoc");

                entity.Property(e => e.Tipomodelo).HasColumnName("tipomodelo");

                entity.Property(e => e.Usuariodoc)
                    .HasMaxLength(50)
                    .HasColumnName("usuariodoc");
            });

            modelBuilder.Entity<Tbespecialidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBESPECIALIDADE");

                entity.Property(e => e.Cdesp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CDESP");

                entity.Property(e => e.Cdprdcon)
                    .HasMaxLength(8)
                    .HasColumnName("CDPRDCON")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("COD");

                entity.Property(e => e.Descesp)
                    .HasMaxLength(60)
                    .HasColumnName("DESCESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nmesp)
                    .HasMaxLength(51)
                    .HasColumnName("NMESP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Tbitemprescricao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbitemprescricao");

                entity.HasIndex(e => e.Codigo, "icoditpres");

                entity.HasIndex(e => e.Codigopres, "iip_itemprescr");

                entity.HasIndex(e => e.Numgrupo, "ipp_numgrupo");

                entity.HasIndex(e => e.Produto, "ipp_prodprescr");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigopres).HasColumnName("codigopres");

                entity.Property(e => e.Numgrupo).HasColumnName("numgrupo");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Proddilu).HasColumnName("proddilu");

                entity.Property(e => e.Produto).HasColumnName("produto");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qtd");

                entity.Property(e => e.Qtddilu)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qtddilu");

                entity.Property(e => e.Unid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unid");

                entity.Property(e => e.Uniddilu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("uniddilu");
            });

            modelBuilder.Entity<Tblivrocaixa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblivrocaixa");

                entity.Property(e => e.Dtmov)
                    .HasColumnType("datetime")
                    .HasColumnName("dtmov");

                entity.Property(e => e.FlFechado).HasColumnName("fl_fechado");

                entity.Property(e => e.Historico)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("historico")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Idfornecedor).HasColumnName("idfornecedor");

                entity.Property(e => e.Idmov)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idmov");

                entity.Property(e => e.Tipomov).HasColumnName("tipomov");

                entity.Property(e => e.Vlmov)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("vlmov");
            });

            modelBuilder.Entity<Tbmodelo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbmodelos");

                entity.Property(e => e.Arqmodelo)
                    .HasMaxLength(200)
                    .HasColumnName("arqmodelo");

                entity.Property(e => e.Codmodelo)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codmodelo");

                entity.Property(e => e.Conteudomodelo)
                    .HasColumnType("ntext")
                    .HasColumnName("conteudomodelo");

                entity.Property(e => e.Descmodelo)
                    .HasMaxLength(200)
                    .HasColumnName("descmodelo");

                entity.Property(e => e.Temp)
                    .HasColumnName("temp")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TbplanTerap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBPlanTerap");

                entity.Property(e => e.Cid)
                    .HasMaxLength(10)
                    .HasColumnName("cid")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codpaciente)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codpaciente");

                entity.Property(e => e.Codprofissional).HasColumnName("codprofissional");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(40)
                    .HasColumnName("convenio")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DescPlanTerap)
                    .HasMaxLength(400)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DtCriaPlan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.HdaplanTerap)
                    .HasColumnType("ntext")
                    .HasColumnName("HDAPlanTerap")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Histclin)
                    .HasMaxLength(500)
                    .HasColumnName("histclin")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdplanTerap)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDPlanTerap");
            });

            modelBuilder.Entity<Tbprocedcomp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBPROCEDCOMP");

                entity.HasIndex(e => e.CodAmb, "cod_amb");

                entity.HasIndex(e => e.Descri1, "descriproc");

                entity.HasIndex(e => e.Tabela, "tabelaproc");

                entity.Property(e => e.Autorizacao).HasColumnName("autorizacao");

                entity.Property(e => e.Auxiliares)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("AUXILIARES");

                entity.Property(e => e.Cdesp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("cdesp");

                entity.Property(e => e.CodAmb).HasColumnName("cod_amb");

                entity.Property(e => e.CodAmb2).HasColumnName("cod_amb2");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(20)
                    .HasColumnName("COD_EXT")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodRelacionado)
                    .HasMaxLength(20)
                    .HasColumnName("cod_relacionado")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codigo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("codigo");

                entity.Property(e => e.Codigotabelatiss)
                    .HasMaxLength(5)
                    .HasColumnName("codigotabelatiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codtipoato).HasColumnName("codtipoato");

                entity.Property(e => e.Descri1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI1")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri3)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI3")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.Exafatu)
                    .HasMaxLength(100)
                    .HasColumnName("exafatu")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fatorqtd2)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("fatorqtd2");

                entity.Property(e => e.Filme)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("FILME");

                entity.Property(e => e.FlTextocomp)
                    .HasMaxLength(100)
                    .HasColumnName("fl_textocomp")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Honorarios)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("HONORARIOS");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Indice)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("INDICE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Laudo)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("LAUDO");

                entity.Property(e => e.Material)
                    .HasMaxLength(300)
                    .HasColumnName("material")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obc)
                    .HasMaxLength(100)
                    .HasColumnName("obc")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(100)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operacional)
                    .HasColumnType("numeric(14, 2)")
                    .HasColumnName("OPERACIONAL");

                entity.Property(e => e.Preparo)
                    .HasMaxLength(300)
                    .HasColumnName("preparo")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("numeric(8, 0)")
                    .HasColumnName("RECNUM");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(50)
                    .HasColumnName("sigla");

                entity.Property(e => e.Sinonimia)
                    .HasMaxLength(300)
                    .HasColumnName("sinonimia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TABELA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Urgencia).HasColumnName("urgencia");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("VALOR$");
            });

            modelBuilder.Entity<Tbprofcontratado>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbprofcontratado");

                entity.Property(e => e.Idcontratado).HasColumnName("idcontratado");

                entity.Property(e => e.Idprof).HasColumnName("idprof");
            });

            modelBuilder.Entity<Tbprofdium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbprofdia");

                entity.Property(e => e.Codprof).HasColumnName("codprof");

                entity.Property(e => e.Dtagenda)
                    .HasColumnType("datetime")
                    .HasColumnName("dtagenda");

                entity.Property(e => e.Idprofdia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idprofdia");

                entity.Property(e => e.Intervalo).HasColumnName("intervalo");

                entity.Property(e => e.Obsprofdia)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("obsprofdia");

                entity.Property(e => e.Sematendimento).HasColumnName("sematendimento");

                entity.Property(e => e.Usuprofdia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("usuprofdia");
            });

            modelBuilder.Entity<Tbprofrepasse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbprofrepasse");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Medico)
                    .HasMaxLength(255)
                    .HasColumnName("MEDICO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(255)
                    .HasColumnName("SIGLA")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Tbsemrepasse>(entity =>
            {
                entity.HasKey(e => e.Idsemrepasse)
                    .HasName("PK__tbsemrep__A0464FC24BFFE5CB");

                entity.ToTable("tbsemrepasse");

                entity.Property(e => e.Idsemrepasse).HasColumnName("idsemrepasse");

                entity.Property(e => e.Coditem)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("coditem");

                entity.Property(e => e.Codprof).HasColumnName("codprof");
            });

            modelBuilder.Entity<Tbtextocomum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbtextocomum");

                entity.HasIndex(e => e.Idtexto, "i_idtexto");

                entity.HasIndex(e => e.Codprof, "i_proftexto");

                entity.HasIndex(e => e.Textocomum, "i_texto");

                entity.Property(e => e.Codprof).HasColumnName("codprof");

                entity.Property(e => e.Idtexto)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idtexto");

                entity.Property(e => e.Nrrepcontagem)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("nrrepcontagem");

                entity.Property(e => e.Nrrepet)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("nrrepet");

                entity.Property(e => e.Textocomum)
                    .HasMaxLength(100)
                    .HasColumnName("textocomum");
            });

            modelBuilder.Entity<TipoAtendimento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tipo_Atendimento");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<TipoAto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tipo_Ato");

                entity.HasIndex(e => e.Codigo, "i_codigo_ta");

                entity.HasIndex(e => e.Codigo, "ta_codigo");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasColumnName("CODIGO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codtiss)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("codtiss");

                entity.Property(e => e.Descri)
                    .HasMaxLength(40)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Fator)
                    .HasMaxLength(50)
                    .HasColumnName("FATOR")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Recnum)
                    .HasColumnType("decimal(8, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RECNUM");
            });

            modelBuilder.Entity<TipoSaidum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DescTipoAtend)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<Trace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trace");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(128)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ClientProcessId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("CPU");

                entity.Property(e => e.Duration).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EventClass).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Reads).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RowNumber).ValueGeneratedOnAdd();

                entity.Property(e => e.Spid)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("SPID");

                entity.Property(e => e.SqluserName)
                    .HasMaxLength(128)
                    .HasColumnName("SQLUserName")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData)
                    .HasColumnType("ntext")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Writes).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Unidade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Unidade");

                entity.Property(e => e.AlertaProdutos).HasColumnName("alertaProdutos");

                entity.Property(e => e.BaseFinanceiro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("baseFinanceiro");

                entity.Property(e => e.Caminhologo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("caminhologo");

                entity.Property(e => e.Caminhomodelos)
                    .HasMaxLength(200)
                    .HasColumnName("caminhomodelos");

                entity.Property(e => e.Caminhoxml)
                    .HasMaxLength(255)
                    .HasColumnName("caminhoxml")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidade)
                    .HasMaxLength(100)
                    .HasColumnName("cidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cidpadrao)
                    .HasMaxLength(10)
                    .HasColumnName("cidpadrao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(20)
                    .HasColumnName("CNPJ")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.CodigoFinanceiro).HasColumnName("codigoFinanceiro");

                entity.Property(e => e.Datanivel)
                    .HasColumnType("datetime")
                    .HasColumnName("datanivel");

                entity.Property(e => e.Endereco)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Endnet)
                    .HasMaxLength(400)
                    .HasColumnName("endnet")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FlEnviasms).HasColumnName("fl_enviasms");

                entity.Property(e => e.HrEnviosms)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("hr_enviosms");

                entity.Property(e => e.IdWeb).HasColumnName("id_web");

                entity.Property(e => e.Ip)
                    .HasMaxLength(30)
                    .HasColumnName("IP")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Logonet)
                    .HasMaxLength(300)
                    .HasColumnName("logonet")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PassFinanceiro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passFinanceiro");

                entity.Property(e => e.RazaoSocial)
                    .HasMaxLength(100)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.ServerFinanceiro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serverFinanceiro");

                entity.Property(e => e.StMsgSms)
                    .HasMaxLength(200)
                    .HasColumnName("st_msg_sms");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserFinanceiro)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userFinanceiro");
            });

            modelBuilder.Entity<UnidadesInternacao>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Unidades_Internacao");

                entity.Property(e => e.Codigo)
                    .HasColumnType("decimal(4, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descri)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Setor)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("SETOR");
            });

            modelBuilder.Entity<VwAgendaProf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_agenda_prof");

                entity.Property(e => e.Codconv)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("codconv");

                entity.Property(e => e.CodigoP).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("convenio")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Dtnasc)
                    .HasMaxLength(20)
                    .HasColumnName("DTNASC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Enviousms).HasColumnName("enviousms");

                entity.Property(e => e.HrAtend).HasColumnType("datetime");

                entity.Property(e => e.HrChega).HasColumnType("datetime");

                entity.Property(e => e.Hrmarcada)
                    .HasColumnType("datetime")
                    .HasColumnName("hrmarcada");

                entity.Property(e => e.IdWeb).HasColumnName("id_web");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nomeprof)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeprof")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(200)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Statusnet).HasColumnName("statusnet");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Telefone2)
                    .HasMaxLength(30)
                    .HasColumnName("telefone2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipoatend).HasColumnName("tipoatend");
            });

            modelBuilder.Entity<VwCabecalhoContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_cabecalho_conta");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(30)
                    .HasColumnName("autorizacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codconv)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("codconv");

                entity.Property(e => e.Codigop)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("codigop");

                entity.Property(e => e.Codmedsolici).HasColumnName("codmedsolici");

                entity.Property(e => e.ConsProfSolici)
                    .HasMaxLength(10)
                    .HasColumnName("cons_prof_solici")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("cpf")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.DtAut)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_aut");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("fatura");

                entity.Property(e => e.Guia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("guia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guiaprincipal)
                    .HasMaxLength(20)
                    .HasColumnName("guiaprincipal")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matricula")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Medsolici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medsolici")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nomeconv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeconv")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(100)
                    .HasColumnName("paciente")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.RegProfisSolici)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("reg_profis_solici")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("registro");

                entity.Property(e => e.Sigla)
                    .HasMaxLength(50)
                    .HasColumnName("sigla")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Siglamed)
                    .HasMaxLength(50)
                    .HasColumnName("siglamed")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TipoAtend).HasColumnName("tipo_atend");

                entity.Property(e => e.UfConselhoSolici)
                    .HasMaxLength(2)
                    .HasColumnName("uf_conselho_solici")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<VwContaProcNaoRealizado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_conta_proc_nao_realizado");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("paciente");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prontuario");
            });

            modelBuilder.Entity<VwContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_conta");

                entity.Property(e => e.Autorizacao)
                    .HasMaxLength(30)
                    .HasColumnName("autorizacao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Cid10)
                    .HasMaxLength(10)
                    .HasColumnName("cid10")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Codconv)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("codconv");

                entity.Property(e => e.Codmedico).HasColumnName("codmedico");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("convenio")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Descatend)
                    .HasMaxLength(50)
                    .HasColumnName("descatend")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.DtAut)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_aut");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("fatura");

                entity.Property(e => e.Guia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("guia")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Guiaprincipal)
                    .HasMaxLength(20)
                    .HasColumnName("guiaprincipal")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Horaatend)
                    .HasColumnType("datetime")
                    .HasColumnName("horaatend");

                entity.Property(e => e.Horacheg)
                    .HasColumnType("datetime")
                    .HasColumnName("horacheg");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("matricula")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Medcobra)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("medcobra");

                entity.Property(e => e.Medico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medico")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(500)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Operador)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("operador")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(8, 0)")
                    .HasColumnName("paciente");

                entity.Property(e => e.Registro)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("registro");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.TipoAtend).HasColumnName("tipo_atend");

                entity.Property(e => e.Tipoconsulta).HasColumnName("tipoconsulta");

                entity.Property(e => e.Tiposaida).HasColumnName("tiposaida");
            });

            modelBuilder.Entity<VwDetalhesContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_detalhes_conta");

                entity.Property(e => e.Coditem)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("coditem");

                entity.Property(e => e.Codprof)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("codprof");

                entity.Property(e => e.Codtiss)
                    .HasMaxLength(20)
                    .HasColumnName("codtiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Custounitario)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("custounitario");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Divisor)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("divisor");

                entity.Property(e => e.Flrepasse).HasColumnName("flrepasse");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.PrCusto)
                    .HasColumnType("numeric(14, 4)")
                    .HasColumnName("pr_custo");

                entity.Property(e => e.Profissional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("profissional")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Qtdutilizada)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("qtdutilizada");

                entity.Property(e => e.RegProfis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("reg_profis")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Registro).HasColumnName("registro");

                entity.Property(e => e.Siglaconselho)
                    .HasMaxLength(10)
                    .HasColumnName("siglaconselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("tipo");

                entity.Property(e => e.Totalpago).HasColumnName("totalpago");

                entity.Property(e => e.UfConselho)
                    .HasMaxLength(2)
                    .HasColumnName("uf_conselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Vltotal).HasColumnName("vltotal");

                entity.Property(e => e.Vlunit).HasColumnName("vlunit");
            });

            modelBuilder.Entity<VwKitIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_kit_itens");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Iditem)
                    .HasColumnType("decimal(12, 0)")
                    .HasColumnName("iditem");

                entity.Property(e => e.Matmed)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("matmed");

                entity.Property(e => e.Obs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("obs");

                entity.Property(e => e.Obskit)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("obskit");

                entity.Property(e => e.Ordem).HasColumnName("ordem");

                entity.Property(e => e.Qtddilu).HasColumnName("qtddilu");

                entity.Property(e => e.Unid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("unid");
            });

            modelBuilder.Entity<VwMatmedContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_matmed_conta");

                entity.Property(e => e.Codident).HasColumnName("codident");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Custounitario)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("custounitario");

                entity.Property(e => e.Descri)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("descri")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Divisor)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("DIVISOR");

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_movim");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.Flrepasse).HasColumnName("flrepasse");

                entity.Property(e => e.Item).HasColumnName("item");

                entity.Property(e => e.Matmed)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("matmed");

                entity.Property(e => e.NumTiss)
                    .HasMaxLength(20)
                    .HasColumnName("num_tiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrCusto)
                    .HasColumnType("numeric(14, 4)")
                    .HasColumnName("pr_custo");

                entity.Property(e => e.PrUnit).HasColumnName("pr_unit");

                entity.Property(e => e.Produto).HasColumnName("produto");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Qtdutilizada).HasColumnName("qtdutilizada");

                entity.Property(e => e.Registro).HasColumnName("registro");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.Totalpago).HasColumnName("totalpago");

                entity.Property(e => e.UnidCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_compra");

                entity.Property(e => e.UnidConsumo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unid_consumo");
            });

            modelBuilder.Entity<VwPrescPaciProf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PrescPaciProf");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.DtexcpresC)
                    .HasColumnType("datetime")
                    .HasColumnName("dtexcpresC");

                entity.Property(e => e.Dtnasc)
                    .HasMaxLength(20)
                    .HasColumnName("DTNASC")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdWeb).HasColumnName("id_web");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("NOME")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.NomeProf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Obs)
                    .HasMaxLength(100)
                    .HasColumnName("obs")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Presfinalizada).HasColumnName("presfinalizada");

                entity.Property(e => e.Protocolo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("protocolo");

                entity.Property(e => e.RegProfis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("REG_PROFIS")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SEXO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Siglaconselho)
                    .HasMaxLength(10)
                    .HasColumnName("siglaconselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.UfConselho)
                    .HasMaxLength(2)
                    .HasColumnName("UF_conselho")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");
            });

            modelBuilder.Entity<VwProcAmbMestreIten>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_proc_amb_mestre_itens");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("convenio");

                entity.Property(e => e.DtMovim)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_movim");

                entity.Property(e => e.FlInteira).HasColumnName("fl_inteira");

                entity.Property(e => e.FlSit).HasColumnName("fl_sit");

                entity.Property(e => e.HrFim)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_fim");

                entity.Property(e => e.HrInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_inicio");

                entity.Property(e => e.Percentual)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("percentual");

                entity.Property(e => e.Procedimento)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("procedimento");

                entity.Property(e => e.Profissional)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("profissional");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prontuario");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("qtd");

                entity.Property(e => e.Reducaoacrescimo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("reducaoacrescimo");

                entity.Property(e => e.Registrop)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("registrop");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .HasColumnName("tabela")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tecnica).HasColumnName("tecnica");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("tipo");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Totalpago)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalpago");

                entity.Property(e => e.Via).HasColumnName("via");

                entity.Property(e => e.VlUnit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("vl_unit");
            });

            modelBuilder.Entity<VwProcContum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_proc_conta");

                entity.Property(e => e.CodAmb).HasColumnName("cod_amb");

                entity.Property(e => e.CodExt)
                    .HasMaxLength(20)
                    .HasColumnName("cod_ext")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Contratado).HasColumnName("contratado");

                entity.Property(e => e.Convenio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("convenio")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conveniopi)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("conveniopi");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Descato)
                    .HasMaxLength(40)
                    .HasColumnName("descato")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descri")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(282)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Especialidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("especialidade")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.FlSit).HasColumnName("fl_sit");

                entity.Property(e => e.HrFim)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_fim");

                entity.Property(e => e.HrInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("hr_inicio");

                entity.Property(e => e.Inativo).HasColumnName("inativo");

                entity.Property(e => e.Medico)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medico")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Procedimento)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("procedimento");

                entity.Property(e => e.Profissional)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("profissional");

                entity.Property(e => e.Prontuario)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("prontuario");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("qtd");

                entity.Property(e => e.RegProfis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("reg_profis")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Registrop)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("registrop");

                entity.Property(e => e.Registropi)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("registropi");

                entity.Property(e => e.Registropm)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("registropm");

                entity.Property(e => e.Siglaconselho)
                    .HasMaxLength(10)
                    .HasColumnName("siglaconselho")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tabela)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tabela")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tecnica).HasColumnName("tecnica");

                entity.Property(e => e.TipoAto)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("tipo_ato");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("total");

                entity.Property(e => e.Totalpago)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalpago");

                entity.Property(e => e.UfConselho)
                    .HasMaxLength(2)
                    .HasColumnName("uf_conselho")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Via).HasColumnName("via");

                entity.Property(e => e.VlUnit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("vl_unit");
            });

            modelBuilder.Entity<VwRepasse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_repasse");

                entity.Property(e => e.Codconv)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("codconv");

                entity.Property(e => e.Codexec).HasColumnName("codexec");

                entity.Property(e => e.CodigoRepasse).HasColumnName("codigo_repasse");

                entity.Property(e => e.Codmedsolici).HasColumnName("codmedsolici");

                entity.Property(e => e.Codtiss)
                    .HasMaxLength(20)
                    .HasColumnName("codtiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Custototal)
                    .HasColumnType("decimal(38, 11)")
                    .HasColumnName("custototal");

                entity.Property(e => e.Custounitario)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("custounitario");

                entity.Property(e => e.Datapg)
                    .HasColumnType("datetime")
                    .HasColumnName("datapg");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(403)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dtdeta)
                    .HasColumnType("datetime")
                    .HasColumnName("dtdeta");

                entity.Property(e => e.Fatura)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("fatura");

                entity.Property(e => e.Flrepasse).HasColumnName("flrepasse");

                entity.Property(e => e.LucroBruto).HasColumnName("lucro_bruto");

                entity.Property(e => e.LucroLiquido).HasColumnName("lucro_liquido");

                entity.Property(e => e.Medsolici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medsolici")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Medsolici2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medsolici2")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mesref)
                    .HasMaxLength(5)
                    .HasColumnName("mesref")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nf)
                    .HasMaxLength(50)
                    .HasColumnName("nf")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nomeconv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeconv")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(100)
                    .HasColumnName("paciente")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrCusto)
                    .HasColumnType("decimal(25, 9)")
                    .HasColumnName("pr_custo");

                entity.Property(e => e.Precounit)
                    .HasColumnType("decimal(25, 9)")
                    .HasColumnName("precounit");

                entity.Property(e => e.Profissional)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("profissional")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Qtd).HasColumnName("qtd");

                entity.Property(e => e.Qtdutilizada)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("qtdutilizada");

                entity.Property(e => e.Registro).HasColumnName("registro");

                entity.Property(e => e.Repasse).HasColumnName("repasse");

                entity.Property(e => e.Siglamed)
                    .HasMaxLength(50)
                    .HasColumnName("siglamed")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.StatusFatura).HasColumnName("status_fatura");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("tipo");

                entity.Property(e => e.TipoAtend).HasColumnName("tipo_atend");

                entity.Property(e => e.Totalpago).HasColumnName("totalpago");

                entity.Property(e => e.Vlglosa).HasColumnName("vlglosa");

                entity.Property(e => e.Vltotal).HasColumnName("vltotal");

                entity.Property(e => e.Vlunit).HasColumnName("vlunit");
            });

            modelBuilder.Entity<VwRepasseInter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_repasse_inter");

                entity.Property(e => e.Codconv)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("codconv");

                entity.Property(e => e.CodigoRepasse).HasColumnName("codigo_repasse");

                entity.Property(e => e.Codmedsolici).HasColumnName("codmedsolici");

                entity.Property(e => e.Codtiss)
                    .HasMaxLength(20)
                    .HasColumnName("codtiss")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Conta)
                    .HasColumnType("decimal(22, 0)")
                    .HasColumnName("conta");

                entity.Property(e => e.Custototal).HasColumnName("custototal");

                entity.Property(e => e.Custounitario).HasColumnName("custounitario");

                entity.Property(e => e.Datapg)
                    .HasColumnType("datetime")
                    .HasColumnName("datapg");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(280)
                    .IsUnicode(false)
                    .HasColumnName("descricao")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Dtdeta)
                    .HasColumnType("datetime")
                    .HasColumnName("dtdeta");

                entity.Property(e => e.Fatura).HasColumnName("fatura");

                entity.Property(e => e.LucroBruto)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("lucro_bruto");

                entity.Property(e => e.LucroLiquido)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("lucro_liquido");

                entity.Property(e => e.Medsolici)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("medsolici")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Mesref)
                    .HasMaxLength(5)
                    .HasColumnName("mesref")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nf)
                    .HasMaxLength(50)
                    .HasColumnName("nf")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Nomeconv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nomeconv")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Paciente)
                    .HasMaxLength(100)
                    .HasColumnName("paciente")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.PrCusto).HasColumnName("pr_custo");

                entity.Property(e => e.Precounit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("precounit");

                entity.Property(e => e.Profissional)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("profissional");

                entity.Property(e => e.Qtd)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("QTD");

                entity.Property(e => e.Qtdutilizada)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("qtdutilizada");

                entity.Property(e => e.Registro).HasColumnName("registro");

                entity.Property(e => e.Repasse)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("repasse");

                entity.Property(e => e.Siglamed)
                    .HasMaxLength(50)
                    .HasColumnName("siglamed")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Tipo)
                    .HasColumnType("decimal(2, 0)")
                    .HasColumnName("tipo");

                entity.Property(e => e.TipoAtend).HasColumnName("tipo_atend");

                entity.Property(e => e.Totalpago)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("totalpago");

                entity.Property(e => e.Vlglosa)
                    .HasColumnType("decimal(21, 2)")
                    .HasColumnName("vlglosa");

                entity.Property(e => e.Vltotal)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("vltotal");

                entity.Property(e => e.Vlunit)
                    .HasColumnType("decimal(14, 2)")
                    .HasColumnName("vlunit");
            });

            modelBuilder.Entity<VwTotaisProdExec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TotaisProdExec");

                entity.Property(e => e.Apresentacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APRESENTACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdPrescricao).HasColumnName("idPrescricao");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Matmed)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("MATMED");

                entity.Property(e => e.TotUsado)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("totUsado");
            });

            modelBuilder.Entity<VwTotaisProdExecSemLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TotaisProdExecSemLocal");

                entity.Property(e => e.Apresentacao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APRESENTACAO")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.Descri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRI")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AI");

                entity.Property(e => e.IdPrescricao).HasColumnName("idPrescricao");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.Matmed)
                    .HasColumnType("numeric(4, 0)")
                    .HasColumnName("MATMED");

                entity.Property(e => e.TotUsado)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("totUsado");
            });

            modelBuilder.Entity<VwUltConvPac>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ult_conv_pac");

                entity.Property(e => e.Convenio).HasColumnName("convenio");

                entity.Property(e => e.Paciente)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("paciente");
            });

            modelBuilder.Entity<_874Medicamento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("874_medicamentos");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col006)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col008)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col009)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col010)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col011)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col012)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col013)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col014)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col015)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col016)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_874MedicamentosPf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("874_medicamentos_PF");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col006)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col008)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col009)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col010)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col011)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col012)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col013)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col014)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col015)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col016)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_874MedicamentosRh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("874_medicamentos_RH");

                entity.Property(e => e.Col001)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col002)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col003)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col004)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col005)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col006)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col007)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col008)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col009)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col010)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col011)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col012)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col013)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col014)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col015)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Col016)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
