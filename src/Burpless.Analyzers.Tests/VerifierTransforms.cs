using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Burpless.Analyzers.Tests;

public static class VerifierTransforms
{
    private static readonly ImmutableDictionary<string, ReportDiagnostic> NullableWarnings = GetNullableWarningsFromCompiler();

    public static Solution GetNullableTransform(Solution solution, ProjectId projectId)
    {
        var project = solution.GetProject(projectId);

        var options = project!.CompilationOptions!.WithSpecificDiagnosticOptions(
            project.CompilationOptions.SpecificDiagnosticOptions.SetItems(NullableWarnings));

        return solution.WithProjectCompilationOptions(projectId, options);
    }

    private static ImmutableDictionary<string, ReportDiagnostic> GetNullableWarningsFromCompiler()
    {
        var args = new[] {"/warnaserror:nullable"};
        var commandLineArguments = CSharpCommandLineParser.Default.Parse(args, Environment.CurrentDirectory, Environment.CurrentDirectory);
        var nullableWarnings = commandLineArguments.CompilationOptions.SpecificDiagnosticOptions;

        return nullableWarnings
            .SetItem("CS8632", ReportDiagnostic.Error)
            .SetItem("CS8669", ReportDiagnostic.Error);
    }
}
