using AcademyEMS.CoreDbContext;
using AcademyEMS.Repositories;
using AcademyEMS.Repositories.Classes;
using AcademyEMS.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("GlobalConnectionStr")));

builder.Services.AddControllers();

var emsOrigins = "_emsOrigins";
builder.Services.AddCors(options =>
{
    // todo - this needs to be revisited
    options.AddPolicy(name: emsOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICourseTypeRepository, CourseTypeRepository>();
builder.Services.AddTransient<IUserTypeRepository, UserTypeRepository>();
builder.Services.AddTransient<ICourseTypeService, CourseTypeService>();
builder.Services.AddTransient<IUserTypeService, UserTypeService>();

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
