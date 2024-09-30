using Favorites.Infrastructure;
using Microsoft.EntityFrameworkCore;
    
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FavoritesDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-6C9AD2N; Database=favorites-dev-db; Trusted_Connection=true; Trust Server Certificate=true; MultipleActiveResultSets=true; Integrated Security=true;");
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<FavoritesDbContext>();
    if (!dbContext.Database.CanConnect())
    {
        throw new NotImplementedException("Cannot connect to database");
    }
}

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
