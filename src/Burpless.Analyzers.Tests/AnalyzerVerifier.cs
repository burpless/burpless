using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Text;

namespace Burpless.Analyzers.Tests;

public static class AnalyzerVerifier<TAnalyzer>
    where TAnalyzer : DiagnosticAnalyzer, new()
{
    public static DiagnosticResult Diagnostic()
    {
        return CSharpAnalyzerVerifier<TAnalyzer, DefaultVerifier>.Diagnostic();
    }

    public static DiagnosticResult Diagnostic(string diagnosticId)
    {
        return CSharpAnalyzerVerifier<TAnalyzer, DefaultVerifier>.Diagnostic(diagnosticId);
    }

    public static DiagnosticResult Diagnostic(DiagnosticDescriptor descriptor)
    {
        return CSharpAnalyzerVerifier<TAnalyzer, DefaultVerifier>.Diagnostic(descriptor);
    }

    public static async Task VerifyAnalyzerAsync(string source, params DiagnosticResult[] expected)
    {
        var test = new Test
        {
            TestCode = source
        };

        test.ExpectedDiagnostics.AddRange(expected);

        await test.RunAsync(CancellationToken.None);
    }

    public static async Task VerifyAnalyzerAsync(string source, string fileName, params DiagnosticResult[] expected)
    {
        var test = new Test();

        test.TestState.Sources.Add((fileName, SourceText.From(source)));
        test.ExpectedDiagnostics.AddRange(expected);

        await test.RunAsync(CancellationToken.None);
    }

    private class Test : CSharpAnalyzerTest<TAnalyzer, DefaultVerifier>
    {
        public Test()
        {
            SolutionTransforms.Add(VerifierTransforms.GetNullableTransform);
        }
    }
}
