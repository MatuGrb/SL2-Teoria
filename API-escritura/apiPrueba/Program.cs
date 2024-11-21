using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=app.db");
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

// este endpoint va a responder peticiones de tipo GET
// Estructura: app.MapGet("ruta", () => "respuesta");
app.MapGet("/", () => 
{    
    return $"Hola mundo!";
});

app.MapGet("/{username}", (string username) => 
{    
    return $"Hola, {username}!";
});

app.MapPost("/producto", async (AppDbContext db, Producto producto) => 
{    
    db.Productos.Add(producto);
    await db.SaveChangesAsync();
    return $"Producto {producto.Nombre} creado con éxito!";
});

app.Run();

