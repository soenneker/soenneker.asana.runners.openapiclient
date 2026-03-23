using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Asana.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class AsanaOpenApiClientRunnerTests : FixturedUnitTest
{
    public AsanaOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
