using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

var app = WebApplication.Create(args);

app.MapGet("api/ingredient", async http =>
{
    var items = new[]
    {
        new { Id = new Guid("df935095-8709-4040-a2bb-b6f97cb416dc"), Name = "Vejce", Description = "Popis vajec" },
        new { Id = new Guid("23b3902d-7d4f-4213-9cf0-112348f56238"), Name = "Name 2", Description = "Description 2" }
    };

    await http.Response.WriteAsJsonAsync(items);
});

app.MapGet("api/ingredient/{id}", async http => {
    if(!http.Request.RouteValues.TryGetValue("id", out var id))
    {
        http.Response.StatusCode = StatusCodes.Status400BadRequest;
        return;
    }

    await http.Response.WriteAsJsonAsync(new { Id = new Guid(id.ToString()), Name = "Vejce" });
});

await app.RunAsync();