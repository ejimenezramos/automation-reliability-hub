using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Text.Json;

namespace Hub.Api.IntegrationTests;

public class HealthEndpointTests
{
    [Fact]
    public async Task GetHealth_ReturnsOk()
    {
        // Arrange: preparar la API y el cliente.
        using var factory = new WebApplicationFactory<Program>();
        using var client = factory.CreateClient(
            new WebApplicationFactoryClientOptions
            {
                BaseAddress = new Uri("https://localhost")
            });

        // Act: enviar la petición.
        using var response = await client.GetAsync("/api/health");

        // Assert: comprobar el resultado.
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var content = await response.Content.ReadAsStringAsync();

        using var json = JsonDocument.Parse(content);

        Assert.Equal(
            "ok",
            json.RootElement.GetProperty("status").GetString());
    }
}
