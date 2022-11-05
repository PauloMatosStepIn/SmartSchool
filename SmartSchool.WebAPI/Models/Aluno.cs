using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
  public class Aluno
  {
    public Aluno() { }

    public Aluno(int id, int matricula, string nome, string apelido, string telefone, DateTime dataNascimento)
    {
      this.Id = id;
      this.Matricula = matricula;
      this.Nome = nome;
      this.Apelido = apelido;
      this.DataNascimento = dataNascimento;
      this.Telefone = telefone;
    }

    public int Id { get; set; }
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataMatricula { get; set; } = DateTime.Now;
    public DateTime? DataConclusao { get; set; } = null;
    public bool Activo { get; set; } = true;
    public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
  }
}