using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.WebAPI.Helpers;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Data
{
  public interface IRepository
  {
    void Add<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    bool SaveChanges();

    //metodos especificos para alunos
    Task<PageList<Aluno>> GetAllAlunosAsync(PageParams pageParams, bool includeProfessor = false);
    Aluno[] GetAllAlunosByDisciplinaId(int disciplinaId, bool includeProfessor = false);
    Aluno GetAlunoById(int alunoId, bool includeProfessor = false);

    //metodos especificos para professores
    Professor[] GetAllProfessores(bool includeAlunos = false);
    Professor[] GetAllProfessoresByDisciplinaId(int disciplinaId, bool includeAlunos = false);
    Professor GetProfessorById(int professorId, bool includeAlunos = false);

  }
}