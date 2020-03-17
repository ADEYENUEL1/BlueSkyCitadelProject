using System.Diagnostics;
using System.CodeDom.Compiler;
using global::Microsoft.VisualStudio.TestTools.UnitTesting;
using global::TechTalk.SpecFlow;

[GeneratedCode("SpecFlow", "3.1.80")]
[TestClass]
public class BlueskyCitadelProject1_MSTestAssemblyHooks
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext testContext)
    {
        var currentAssembly = typeof(BlueskyCitadelProject1_MSTestAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        var currentAssembly = typeof(BlueskyCitadelProject1_MSTestAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
