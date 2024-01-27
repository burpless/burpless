using Xunit;
using Verify = Burpless.Analyzers.Tests.AnalyzerVerifier<
    Burpless.Analyzers.Naming.SomethingMustBeLikeThisAnalyzer>;

namespace Burpless.Analyzers.Tests.Naming;

public class SomethingMustBeLikeThisAnalyzerTests
{
    [Fact]
    public async Task NoErrors()
    {
        const string source = @"
public class MyClass
{
}";

        await Verify.VerifyAnalyzerAsync(source);
    }

    [Fact]
    public async Task ReportsErrorsForViolations()
    {
        const string source = @"
public class [|MyClass|]
{
}";

        //await Verify.VerifyAnalyzerAsync(source);
    }
}
