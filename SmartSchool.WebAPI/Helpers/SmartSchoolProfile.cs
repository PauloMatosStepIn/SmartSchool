using AutoMapper;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Helpers
{
  public class SmartSchoolProfile : Profile
  {
    public SmartSchoolProfile()
    {
      CreateMap<Aluno, AlunoDto>()
      .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => $"{src.Nome} {src.Apelido}"))
      .ForMember(dest => dest.Idade, opt => opt.MapFrom(src => src.DataNascimento.GetCurrentAge()))
      ;
      CreateMap<AlunoDto, Aluno>();
      CreateMap<Aluno, AlunoRegisterDto>().ReverseMap();

      CreateMap<Professor, ProfessorDto>()
      .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => $"{src.Nome} {src.Apelido}"))
      ;
      CreateMap<ProfessorDto, Professor>();
      CreateMap<Professor, ProfessorRegisterDto>().ReverseMap();
    }
  }
}