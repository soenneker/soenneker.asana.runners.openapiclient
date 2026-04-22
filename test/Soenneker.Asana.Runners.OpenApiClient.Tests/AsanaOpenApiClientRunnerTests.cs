using Soenneker.Tests.HostedUnit;

namespace Soenneker.Asana.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class AsanaOpenApiClientRunnerTests : HostedUnitTest
{
    public AsanaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
