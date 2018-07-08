using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.UnitTestFramework;

namespace Burpless.ReSharper
{
    [ZoneMarker]
    public class ZoneMarker : IRequire<IPsiLanguageZone>, IRequire<IUnitTestingZone>
    {
    }
}
