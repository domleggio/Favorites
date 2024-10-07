using Favorites.Application.Services.interfaces;
using Favorites.Application.Services.services;
using Favorites.Domain;
using Favorites.Infrastructure;
using Favorites.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme)
    .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services.AddIdentityCore<User>()
    .AddEntityFrameworkStores<FavoritesDbContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<FavoritesDbContext>(options =>
{
    options.UseSqlServer("YOUR_SERVER_NAME; Database=favorites-dev-db; Trusted_Connection=true; Trust Server Certificate=true; MultipleActiveResultSets=true; Integrated Security=true;");
});

builder.Services.AddTransient<IFavoritesService, FavoritesService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IFavoritesDbContext, FavoritesDbContext>();

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
app.MapIdentityApi<User>();
app.UseAuthorization();

app.MapControllers();

app.Run();
