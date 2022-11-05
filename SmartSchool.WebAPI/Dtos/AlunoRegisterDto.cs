namespace SmartSchool.WebAPI.Dtos
{
  public class AlunoRegisterDto
  {
    public int Id { get; set; }
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataMatricula { get; set; } = DateTime.Now;
    public DateTime? DataConclusao { get; set; } = null;
    public bool Activo { get; set; } = true;
    
  }
}