// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.WebAPI.Data;

#nullable disable

namespace SmartSchool.WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Apelido")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activo = true,
                            Apelido = "Kent",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4618),
                            DataNascimento = new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Activo = true,
                            Apelido = "Isabela",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4631),
                            DataNascimento = new DateTime(2003, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Activo = true,
                            Apelido = "Antonia",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4638),
                            DataNascimento = new DateTime(2000, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Activo = true,
                            Apelido = "Maria",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4644),
                            DataNascimento = new DateTime(2001, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Activo = true,
                            Apelido = "Machado",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4649),
                            DataNascimento = new DateTime(1999, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Activo = true,
                            Apelido = "Alvares",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4656),
                            DataNascimento = new DateTime(2004, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Activo = true,
                            Apelido = "José",
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4662),
                            DataNascimento = new DateTime(2006, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            CursoId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4681)
                        },
                        new
                        {
                            AlunoId = 2,
                            CursoId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4685)
                        },
                        new
                        {
                            AlunoId = 3,
                            CursoId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4687)
                        },
                        new
                        {
                            AlunoId = 4,
                            CursoId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4689)
                        },
                        new
                        {
                            AlunoId = 5,
                            CursoId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4691)
                        },
                        new
                        {
                            AlunoId = 6,
                            CursoId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4694)
                        },
                        new
                        {
                            AlunoId = 7,
                            CursoId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4696)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4716)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4720)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4722)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4724)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4726)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4728)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4730)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4732)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4734)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4737)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4739)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4741)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4743)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4745)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4747)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4749)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4751)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4753)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4755)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4757)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4759)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4761)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataMatricula = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4763)
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologias de Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("int");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int?>("PreRequisitoId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PreRequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Apelido")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DataFimContrato")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataInicioContrato")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<int>("Registo")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activo = true,
                            Apelido = "António",
                            DataInicioContrato = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4332),
                            Nome = "Lauro",
                            Registo = 1
                        },
                        new
                        {
                            Id = 2,
                            Activo = true,
                            Apelido = "Cavaliery",
                            DataInicioContrato = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4380),
                            Nome = "Roberto",
                            Registo = 2
                        },
                        new
                        {
                            Id = 3,
                            Activo = true,
                            Apelido = "Junior",
                            DataInicioContrato = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4382),
                            Nome = "Ronaldo",
                            Registo = 3
                        },
                        new
                        {
                            Id = 4,
                            Activo = true,
                            Apelido = "Leão",
                            DataInicioContrato = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4384),
                            Nome = "Rodrigo",
                            Registo = 4
                        },
                        new
                        {
                            Id = 5,
                            Activo = true,
                            Apelido = "Dumas",
                            DataInicioContrato = new DateTime(2022, 11, 8, 11, 12, 57, 148, DateTimeKind.Local).AddTicks(4386),
                            Nome = "Alexandre",
                            Registo = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.WebAPI.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.WebAPI.Models.Disciplina", "PreRequisito")
                        .WithMany()
                        .HasForeignKey("PreRequisitoId");

                    b.HasOne("SmartSchool.WebAPI.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("PreRequisito");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Aluno", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Disciplina", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.WebAPI.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
