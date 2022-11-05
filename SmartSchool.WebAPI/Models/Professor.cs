using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
  public class Professor
  {
    public Professor(int id, int registo, string nome, string apelido)
    {
      this.Id = id;
      this.Registo = registo;
      this.Nome = nome;
      this.Apelido = apelido;
    }

    public int Id { get; set; }

    public int Registo { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Telefone { get; set; }

    public DateTime DataInicioContrato { get; set; } = DateTime.Now;
    public DateTime? DataFimContrato { get; set; } = null;
    public bool Activo { get; set; } = true;
    public IEnumerable<Disciplina> Disciplinas { get; set; }
  }
}