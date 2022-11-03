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
    private readonly DataContext _context;
    public ProfessorController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    public IActionResult get()
    {
      // return Ok("Professores: Marta,Paula,Rafa");

      return Ok(_context.Professores);
    }

    [HttpGet("{id:int}")]
    public IActionResult getById(int id)
    {
      var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
      if (professor == null) return BadRequest("Professor não encontrado");
      return Ok(professor);
    }

    [HttpGet("{nome}")]
    public IActionResult getByName(string nome)
    {
      var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
      if (professor == null) return BadRequest("Professor não encontrado");
      return Ok(professor);
    }

    [HttpPost]
    public IActionResult Post(Professor professor)
    {
      _context.Add(professor);
      _context.SaveChanges();
      return Ok(professor);
    }
    [HttpPut("{id}")]
    public IActionResult Put(int id, Professor professor)
    {
      var ProfessorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      if (ProfessorEncontrado == null) return BadRequest("Professor não encontrado");

      _context.Update(professor);
      _context.SaveChanges();
      return Ok(professor);
    }

    [HttpPatch("{id}")]
    public IActionResult Patch(int id, Professor professor)
    {
      var ProfessorEncontrado = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
      if (ProfessorEncontrado == null) return BadRequest("Professor não encontrado");

      _context.Update(professor);
      _context.SaveChanges();
      return Ok(professor);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var ProfessorEncontrado = _context.Professores.FirstOrDefault(a => a.Id == id);
      if (ProfessorEncontrado == null) return BadRequest("Professor não encontrado");

      _context.Remove(ProfessorEncontrado);
      _context.SaveChanges();
      return Ok();
    }

  }
}