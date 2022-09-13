using Microsoft.EntityFrameworkCore;

using ShopOnline.DataAccess;
using ShopOnline.DataAccess.Repository;
using ShopOnline.DataAccess.Repository.Contracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Local"),b=>b.MigrationsAssembly("ShopOnline.Api")));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
