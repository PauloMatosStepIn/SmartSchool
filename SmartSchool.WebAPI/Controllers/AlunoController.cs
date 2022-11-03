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
    private readonly DataContext _context;

    public AlunoController(DataContext context)
    {
      _context = context;
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
      return Ok(_context.Alunos);
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      var aluno = _context.Alunos.FirstOrDefault(a => a.Id == id);
      if (aluno == null) return BadRequest("Aluno não encontrado");
      return Ok(aluno);
    }

    [HttpGet("{nome}")]
    public IActionResult getByName(string nome)
    {
      var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome));
      if (aluno == null) return BadRequest("Aluno não encontrado");
      return Ok(aluno);
    }

    [HttpPost]
    public IActionResult Post(Aluno aluno)
    {
      _context.Add(aluno);
      _context.SaveChanges();
      return Ok(aluno);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, Aluno aluno)
    {
      var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      _context.Update(aluno);
      _context.SaveChanges();
      return Ok(aluno);
    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Aluno aluno)
    {
      var AlunoEncontrado = _context.Alunos.AsNoTracking().FirstOrDefault(a => a.Id == id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      _context.Update(aluno);
      _context.SaveChanges();
      return Ok(aluno);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var AlunoEncontrado = _context.Alunos.FirstOrDefault(a => a.Id == id);
      if (AlunoEncontrado == null) return BadRequest("Aluno não encontrado");

      _context.Remove(AlunoEncontrado);
      _context.SaveChanges();
      return Ok();
    }

  }
}