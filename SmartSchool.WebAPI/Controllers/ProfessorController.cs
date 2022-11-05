using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProfessorController : ControllerBase
  {
    // private readonly DataContext _context;
    private readonly IRepository _repo;
    private readonly IMapper _mapper;
    public ProfessorController(
      // DataContext context, 
      IRepository repo,
      IMapper mapper
      )
    {
      _repo = repo;
      _mapper = mapper;
      // _context = context;
    }

    [HttpGet]
    public IActionResult get()
    {
      // return Ok("Professores: Marta,Paula,Rafa");

      // return Ok(_context.Professores);

      var professores = _repo.GetAllProfessores(true);

      return Ok(_mapper.Map<IEnumerable<ProfessorDto>>(professores));
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      // var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
      var professor = _repo.GetProfessorById(id);
      if (professor == null) return BadRequest("Professor não encontrado");
      return Ok(_mapper.Map<ProfessorDto>(professor));
    }

    // [HttpGet("{nome}")]
    // public IActionResult getByName(string nome)
    // {
    //   var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
    //   if (professor == null) return BadRequest("Professor não encontrado");
    //   return Ok(professor);
    // }

    [HttpPost]
    public IActionResult Post(Professor professor)
    {
      //   _context.Add(professor);
      //   _context.SaveChanges();
      //   return Ok(professor);

      _repo.Add(professor);
      return _repo.SaveChanges() ? Ok(_mapper.Map<ProfessorDto>(professor)) : BadRequest("Professor não registado");

    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, ProfessorRegisterDto model)
    {
      // var professorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var professorEncontrado = _repo.GetProfessorById(id);
      if (professorEncontrado == null) return BadRequest("Professor não encontrado");

      // _context.Update(professor);
      // _context.SaveChanges();
      // return Ok(professor);

      _mapper.Map(model, professorEncontrado);

      _repo.Update(professorEncontrado);
      return _repo.SaveChanges() ? Ok(_mapper.Map<ProfessorDto>(professorEncontrado)) : BadRequest("Professor não actualizado");

    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, ProfessorRegisterDto model)
    {
      // var professorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var professorEncontrado = _repo.GetProfessorById(id);

      if (professorEncontrado == null) return BadRequest("Professor não encontrado");

      // _context.Update(professor);
      // _context.SaveChanges();
      // return Ok(professor);

      _mapper.Map(model, professorEncontrado);


      _repo.Update(professorEncontrado);
      return _repo.SaveChanges() ? Ok(_mapper.Map<ProfessorDto>(professorEncontrado)) : BadRequest("Professor não actualizado");

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      // var professorEncontrado = _context.Professores.FirstOrDefault(a => a.Id == id);
      var professorEncontrado = _repo.GetProfessorById(id);

      if (professorEncontrado == null) return BadRequest("Professor não encontrado");

      // _context.Remove(ProfessorEncontrado);
      // _context.SaveChanges();
      // return Ok();

      _repo.Delete(professorEncontrado);
      return _repo.SaveChanges() ? Ok("Professor removido") : BadRequest("Professor não removido");

    }

  }
}