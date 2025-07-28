using Microsoft.EntityFrameworkCore;

using TodoApi.BusinessLayer;

using TodoApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// DB Baðlantýsý

builder.Services.AddDbContext<AppDbContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dependency Injection

builder.Services.AddScoped<ITaskRepository, TaskRepository>();

builder.Services.AddScoped<ITaskService, TaskService>();

// Controller

builder.Services.AddControllers();

// CORS ayarý ekle

builder.Services.AddCors(options =>

{

    options.AddPolicy("AllowReactApp", policy =>

    {

        policy.WithOrigins("http://localhost:3000") // React uygulamanýn adresi

              .AllowAnyHeader()

              .AllowAnyMethod()

              .AllowCredentials();

    });

});

// Swagger (opsiyonel)

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware

if (app.Environment.IsDevelopment())

{

    app.UseSwagger();

    app.UseSwaggerUI();

}

app.UseHttpsRedirection();

// CORS middleware'i Auth'dan önce kullan

app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
