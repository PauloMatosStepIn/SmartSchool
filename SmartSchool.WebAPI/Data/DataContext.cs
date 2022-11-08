using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
  public class DataContext : DbContext
  {

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Disciplina> Disciplinas { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<AlunoDisciplina> AlunosDisciplinas { get; set; }
    public DbSet<AlunoCurso> AlunosCursos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      //many to many
      builder.Entity<AlunoDisciplina>()
      .HasKey(AD => new { AD.AlunoId, AD.DisciplinaId });

      builder.Entity<AlunoCurso>()
            .HasKey(AC => new { AC.AlunoId, AC.CursoId });

      //seed data
      builder.Entity<Professor>()
                      .HasData(new List<Professor>(){
                    new Professor(1,1, "Lauro","António"),
                    new Professor(2,2, "Roberto","Cavaliery"),
                    new Professor(3,3, "Ronaldo","Junior"),
                    new Professor(4,4, "Rodrigo","Leão"),
                    new Professor(5,5, "Alexandre","Dumas"),
                      });


      builder.Entity<Curso>()
          .HasData(new List<Curso>{
                    new Curso(1, "Tecnologias de Informação"),
                    new Curso(2, "Sistemas de Informação"),
                    new Curso(3, "Ciência da Computação")
          });

      builder.Entity<Disciplina>()
          .HasData(new List<Disciplina>{
                    new Disciplina(1, "Matemática", 1,1),
                    new Disciplina(2, "Matemática", 1,3),
                    new Disciplina(3, "Física", 2,3),
                    new Disciplina(4, "Português", 3,1),
                    new Disciplina(5, "Inglês", 4,1),
                    new Disciplina(6, "Inglês", 4,2),
                    new Disciplina(7, "Inglês", 4,3),
                    new Disciplina(8, "Programação", 5,1),
                    new Disciplina(9, "Programação", 5,2),
                    new Disciplina(10, "Programação", 5,3)
          });

      builder.Entity<Aluno>()
          .HasData(new List<Aluno>(){
                    new Aluno(1,1, "Marta", "Kent", "33225555", DateTime.Parse("10/05/2002")),
                    new Aluno(2,2, "Paula", "Isabela", "3354288", DateTime.Parse("12/07/2003")),
                    new Aluno(3,3, "Laura", "Antonia", "55668899", DateTime.Parse("3/12/2000")),
                    new Aluno(4,4, "Luiza", "Maria", "6565659", DateTime.Parse("10/01/2001")),
                    new Aluno(5,5, "Lucas", "Machado", "565685415", DateTime.Parse("12/05/1999")),
                    new Aluno(6,6, "Pedro", "Alvares", "456454545", DateTime.Parse("2/05/2004")),
                    new Aluno(7,7, "Paulo", "José", "9874512", DateTime.Parse("5/06/2006"))
          });

      builder.Entity<AlunoCurso>()
          .HasData(new List<AlunoCurso>() {
                    new AlunoCurso() {AlunoId = 1, CursoId = 1 },
                    new AlunoCurso() {AlunoId = 2, CursoId = 2 },
                    new AlunoCurso() {AlunoId = 3, CursoId = 3 },
                    new AlunoCurso() {AlunoId = 4, CursoId = 2 },
                    new AlunoCurso() {AlunoId = 5, CursoId = 3 },
                    new AlunoCurso() {AlunoId = 6, CursoId = 2 },
                    new AlunoCurso() {AlunoId = 7, CursoId = 3 },
          });

      builder.Entity<AlunoDisciplina>()
          .HasData(new List<AlunoDisciplina>() {
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 1, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 2, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 3, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 4, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 5, DisciplinaId = 5 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 6, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 1 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 2 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 3 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 4 },
                    new AlunoDisciplina() {AlunoId = 7, DisciplinaId = 5 }
          });

    }
  }
}