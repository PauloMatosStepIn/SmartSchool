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
  public class ProfessorController : ControllerBase
  {
    // private readonly DataContext _context;
    private readonly IRepository _repo;
    public ProfessorController(
      // DataContext context, 
      IRepository repo)
    {
      _repo = repo;
      // _context = context;
    }

    [HttpGet]
    public IActionResult get()
    {
      // return Ok("Professores: Marta,Paula,Rafa");

      // return Ok(_context.Professores);

      var result = _repo.GetAllProfessores(true);

      return Ok(result);
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      // var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
      var professor = _repo.GetProfessorById(id);
      if (professor == null) return BadRequest("Professor não encontrado");
      return Ok(professor);
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
      return _repo.SaveChanges() ? Ok(professor) : BadRequest("Professor não registado");

    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, Professor professor)
    {
      // var professorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var professorEncontrado = _repo.GetProfessorById(id);
      if (professorEncontrado == null) return BadRequest("Professor não encontrado");

      // _context.Update(professor);
      // _context.SaveChanges();
      // return Ok(professor);

      _repo.Update(professor);
      return _repo.SaveChanges() ? Ok(professor) : BadRequest("Professor não actualizado");

    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Professor professor)
    {
      // var professorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      var professorEncontrado = _repo.GetProfessorById(id);

      if (professorEncontrado == null) return BadRequest("Professor não encontrado");

      // _context.Update(professor);
      // _context.SaveChanges();
      // return Ok(professor);

      _repo.Update(professor);
      return _repo.SaveChanges() ? Ok(professor) : BadRequest("Professor não actualizado");

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