namespace SmartSchool.WebAPI.Dtos
{
  public class ProfessorRegisterDto
  {
    public int Id { get; set; }
    public int Registo { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Telefone { get; set; }
    public DateTime DataInicioContrato { get; set; } = DateTime.Now;
    public DateTime? DataFimContrato { get; set; } = null;
    public bool Activo { get; set; } = true;
  }
}