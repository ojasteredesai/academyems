using Academyems.CoreDbContext;
using Academyems.Repositories;
using Academyems.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("GlobalConnectionStr")));

builder.Services.AddControllers();

var emsOrigins = "_emsOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: emsOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:4200");
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICourseTypeRepository, CourseTypeRepository>();
builder.Services.AddTransient<ICourseTypeService, CourseTypeService>();

var app = builder.Build();


app.UseCors(emsOrigins);


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
