using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(
    context => context.UseSqlite(builder.Configuration.GetConnectionString("Default"))
);

//AddSingleton
//Cria uma nova instancia do serviço quando é solicitado 
//pela primeira vez e reutiliza essa mesma instância
//em todos os locais que esse serviço é necessário

// Singleton means only a single instance will ever be created. That instance is shared between all components that require it. The same instance is thus used always.

//AddTransient
//Gera sempre uma nova instância para cada item encontrado
//que possua tal dependencia, assim, por cada dependencia 
//é criada uma nova instância.
//Cria um object a cada solicitação

// Transient The services created using transient lifetime will be created each time they are requested. This lifetime works best for lightweight services.

//AddScoped
//Numa mesma solicitação é usada a mesma instancia 
//para todas as dependencias.
//Só é usada uma nova instancia quando é feita uma nova solicitação

// Scoped means an instance is created once per scope. A scope is created on every request to the application, thus any components registered as Scoped will be created once per request.

//ref: https://www.coreprogramm.com/2020/02/difference-between-addsingleton-addScoped-addTransient.html

builder.Services.AddScoped<IRepository, Repository>();

builder.Services.AddControllers()
.AddNewtonsoftJson(
  options =>
  options.SerializerSettings.ReferenceLoopHandling =
  Newtonsoft.Json.ReferenceLoopHandling.Ignore
  )
;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
//app.UseAuthorization();

app.MapControllers();

app.Run();
