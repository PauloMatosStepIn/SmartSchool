using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AlunoController : ControllerBase
  {
    private readonly IRepository _repo;
    // private readonly DataContext _context;

    public AlunoController(
      // DataContext context, 
      IRepository repo)
    {
      // _context = context;
      _repo = repo;
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
    public IActionResult get()
    {
      //   return Ok("Alunos: Marta,Paula,Rafa");
      var result = _repo.GetAllAlunos(true);
      return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      // var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
      var aluno = _repo.GetAlunoById(id, true);
      if (aluno == null) return BadRequest("Aluno não encontrado");
      return Ok(aluno);
    }

    // [HttpGet("{nome}")]
    // public IActionResult getByName(string nome)
    // {
    //   var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
    //   if (aluno == null) return BadRequest("Aluno não encontrado");
    //   return Ok(aluno);
    // }

    [HttpPost]
    public IActionResult Post(Aluno aluno)
    {
      // _context.Add(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      _repo.Add(aluno);
      return _repo.SaveChanges() ? Ok(aluno) : BadRequest("Aluno não registado");

    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, Aluno aluno)
    {
      // var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var AlunoEncontrado = _repo.GetAlunoById(id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      // _context.Update(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      _repo.Update(aluno);
      return _repo.SaveChanges() ? Ok(aluno) : BadRequest("Aluno não actualizado");

    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Aluno aluno)
    {
      // var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var AlunoEncontrado = _repo.GetAlunoById(id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      // _context.Update(aluno);
      // _context.SaveChanges();
      // return Ok(aluno);

      _repo.Update(aluno);
      return _repo.SaveChanges() ? Ok(aluno) : BadRequest("Aluno não actualizado");

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