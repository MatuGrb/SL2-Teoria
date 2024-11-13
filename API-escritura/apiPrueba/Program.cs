

var builder = WebApplication.CreateBuilder(args);
// configuración de servicios
var app = builder.Build();

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

app.Run();
