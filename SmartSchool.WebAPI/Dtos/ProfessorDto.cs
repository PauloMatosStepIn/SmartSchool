namespace SmartSchool.WebAPI.Dtos
{
  public class ProfessorDto
  {
    public int Id { get; set; }
    public int Registo { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime DataInicioContrato { get; set; }
    public bool Activo { get; set; }
  }
}