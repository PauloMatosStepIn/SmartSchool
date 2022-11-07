using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AlunoController : ControllerBase
  {
    private readonly IRepository _repo;
    private readonly IMapper _mapper;
    // private readonly DataContext _context;

    public AlunoController(
      // DataContext context, 
      IRepository repo,
      IMapper mapper)
    {
      // _context = context;
      _repo = repo;
      _mapper = mapper;
    }

    // public List<Aluno> Alunos = new List<Aluno>{
    //     new Aluno (){
    //         Id = 1,
    //         Nome = "Marcos",
    //         Sobrenome = "Costa",
    //         Telefone= "961234567"
    //     },
    //     new Aluno (){
    //         Id = 2,
    //         Nome = "Lecas",
    //         Sobrenome = "Santos",
    //         Telefone= "961234111"
    //     },
    //     new Aluno (){
    //         Id = 3,
    //         Nome = "Rui",
    //         Sobrenome = "Silva",
    //         Telefone= "9612342222"
    //     }
    // };


    [HttpGet]
    public async Task<IActionResult> get([FromQuery] PageParams pageParams)
    {
      var alunos = await _repo.GetAllAlunosAsync(pageParams, true);

      Response.AddPagination(alunos.CurrentPage,alunos.PageSize,alunos.TotalCount,alunos.TotalPages);

      return Ok(_mapper.Map<IEnumerable<AlunoDto>>(alunos));
    }

    [HttpGet("getRegister")]
    public IActionResult getRegister()
    {
      return Ok(new AlunoRegisterDto());
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      // var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
      var aluno = _repo.GetAlunoById(id, true);
      if (aluno == null) return BadRequest("Aluno não encontrado");
      return Ok(_mapper.Map<AlunoDto>(aluno));
    }

    // [HttpGet("{nome}")]
    // public IActionResult getByName(string nome)
    // {
    //   var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
    //   if (aluno == null) return BadRequest("Aluno não encontrado");
    //   return Ok(aluno);
    // }

    [HttpPost]
    // public IActionResult Post(Aluno aluno)
    public IActionResult Post(AlunoRegisterDto model)
    {
      // _context.Add(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      var aluno = _mapper.Map<Aluno>(model);

      _repo.Add(aluno);
      return _repo.SaveChanges()
      ? Created($"/api/aluno/{model.Id}", _mapper.Map<AlunoDto>(aluno))
      : BadRequest("Aluno não registado");

    }

    [HttpPut("{id}")]
    // public IActionResult Put(int id, Aluno aluno)
    public IActionResult Put(int id, AlunoRegisterDto model)
    {
      // var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var AlunoEncontrado = _repo.GetAlunoById(id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      // _context.Update(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      _mapper.Map(model, AlunoEncontrado);

      _repo.Update(AlunoEncontrado);
      return _repo.SaveChanges() ? Ok(_mapper.Map<AlunoDto>(AlunoEncontrado)) : BadRequest("Aluno não actualizado");

    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, AlunoRegisterDto model)
    {
      // var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var AlunoEncontrado = _repo.GetAlunoById(id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      // _context.Update(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      _mapper.Map(model, AlunoEncontrado);

      _repo.Update(AlunoEncontrado);
      return _repo.SaveChanges() ? Ok(_mapper.Map<AlunoDto>(AlunoEncontrado)) : BadRequest("Aluno não actualizado");

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      // var AlunoEncontrado = _context.Alunos.FirstOrDefault(a => a.Id == id);
      var AlunoEncontrado = _repo.GetAlunoById(id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      // _context.Remove(AlunoEncontrado);
      // _context.SaveChanges();
      // return Ok();

      _repo.Delete(AlunoEncontrado);
      return _repo.SaveChanges() ? Ok("Aluno removido") : BadRequest("Aluno não removido");

    }

  }
}