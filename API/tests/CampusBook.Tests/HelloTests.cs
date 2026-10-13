using Microsoft.AspNetCore.Mvc.Testing;

namespace CampusBook.Tests;

public class HelloTests
{
    [Fact]
    public async Task Hello_ReturnsMessage()
    {
        using var factory = new WebApplicationFactory<Program>();
        var client = factory.CreateClient();

        var body = await client.GetStringAsync("/api/hello", TestContext.Current.CancellationToken);

        Assert.Contains("Hallo van de CampusBook API", body);
    }
}
