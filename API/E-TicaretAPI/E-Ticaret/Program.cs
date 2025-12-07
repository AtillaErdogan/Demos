using ECommerce.Application.Interfaces;
using ECommerce.Data;
using ECommerce.Domain.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using E_Ticaret.Services.Product_S;
using E_Ticaret.Services.Category_S;
using E_Ticaret.Repositories;
using E_Ticaret.Repositories.Category_R;
using E_Ticaret.Repositories.Product_R;
using E_Ticaret.Middlewares;
using ECommerce.Services.Category_S;
using ECommerce.Services.Product_S;






var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers();


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<,,,>), typeof(GenericService<,,,>));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation()
                .AddFluentValidationClientsideAdapters();

builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
