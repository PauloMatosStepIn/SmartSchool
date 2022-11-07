using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
  public class Repository : IRepository
  {
    private readonly DataContext _context;
    public Repository(DataContext context)
    {
      _context = context;
    }

    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }

    public void Update<T>(T entity) where T : class
    {
      _context.Update(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public bool SaveChanges()
    {
      //se salvou alguma coisa então return true
      return (_context.SaveChanges() > 0);
    }

    public Aluno[] GetAllAlunos(bool includeProfessor = false)
    {
      IQueryable<Aluno> query = _context.Alunos;

      if (includeProfessor)
      {
        query = query.Include(a => a.AlunosDisciplinas)
        .ThenInclude(d => d.Disciplina)
        .ThenInclude(p => p.Professor);
      }

      query = query.AsNoTracking().OrderBy(a => a.Id);

      return query.ToArray();
    }

    public async Task<PageList<Aluno>> GetAllAlunosAsync(
      PageParams pageParams,
      bool includeProfessor = false)
    {
      IQueryable<Aluno> query = _context.Alunos;

      if (includeProfessor)
      {
        query = query.Include(a => a.AlunosDisciplinas)
        .ThenInclude(d => d.Disciplina)
        .ThenInclude(p => p.Professor);
      }

      query = query.AsNoTracking().OrderBy(a => a.Id);

      if (!string.IsNullOrEmpty(pageParams.Nome))
      {
        query = query.Where(a => a.Nome.ToUpper().Contains(pageParams.Nome.ToUpper())
                              || a.Apelido.ToUpper().Contains(pageParams.Nome.ToUpper())
        );
      }

      if (pageParams.Matricula != null)
      {
        query = query.Where(a => a.Matricula == pageParams.Matricula);
      }

      if (pageParams.Activo != null)
      {
        if (pageParams.Activo == 0) query = query.Where(a => a.Activo == false);
        if (pageParams.Activo > 0) query = query.Where(a => a.Activo == true);
      } 

      return await PageList<Aluno>.CreateAsync(query, pageParams.PageNumber, pageParams.PageSize);
    }


    public Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false)
    {
      IQueryable<Aluno> query = _context.Alunos;

      if (includeProfessor)
      {
        query = query.Include(a => a.AlunosDisciplinas)
        .ThenInclude(d => d.Disciplina)
        .ThenInclude(p => p.Professor);
      }

      query = query.AsNoTracking().OrderBy(a => a.Id)
      .Where(a => a.AlunosDisciplinas.Any(d => d.DisciplinaId == disciplinaId));

      return query.ToArray();
    }

    public Aluno GetAlunoById(int alunoId, bool includeProfessor = false)
    {
      IQueryable<Aluno> query = _context.Alunos;

      if (includeProfessor)
      {
        query = query.Include(a => a.AlunosDisciplinas)
        .ThenInclude(d => d.Disciplina)
        .ThenInclude(p => p.Professor);
      }

      query = query.AsNoTracking().OrderBy(a => a.Id)
      .Where(a => a.Id == alunoId)
      ;

      return query.FirstOrDefault();
    }

    public Professor[] GetAllProfessores(bool includeAlunos = false)
    {
      IQueryable<Professor> query = _context.Professores;

      if (includeAlunos)
      {
        query = query.Include(p => p.Disciplinas)
        .ThenInclude(d => d.AlunosDisciplinas)
        .ThenInclude(ad => ad.Aluno);
      }

      query = query.AsNoTracking().OrderBy(a => a.Id);

      return query.ToArray();
    }

    public Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false)
    {
      IQueryable<Professor> query = _context.Professores;

      if (includeAlunos)
      {
        query = query.Include(p => p.Disciplinas)
        .ThenInclude(d => d.AlunosDisciplinas)
        .ThenInclude(ad => ad.Aluno);
      }

      query = query.AsNoTracking().OrderBy(p => p.Id)
      .Where(p => p.Disciplinas.Any(d => d.AlunosDisciplinas
      .Any(ad => ad.DisciplinaId == disciplinaId)));

      return query.ToArray();
    }

    public Professor GetProfessorById(int professorId, bool includeAlunos = false)
    {
      IQueryable<Professor> query = _context.Professores;

      if (includeAlunos)
      {
        query = query.Include(p => p.Disciplinas)
        .ThenInclude(d => d.AlunosDisciplinas)
        .ThenInclude(ad => ad.Aluno);
      }

      query = query.AsNoTracking()
      .Where(p => p.Id == professorId);

      return query.FirstOrDefault();
    }
  }
}