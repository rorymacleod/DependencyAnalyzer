using System;
using System.IO;
using FluentAssertions;
using Xunit.Abstractions;

namespace DependencyAnalyzer.UnitTests
{
    internal class Steps: StepsBase, IDisposable
    {
        private readonly Driver Driver = new Driver();
        private string WorkingDir;
        private string TargetAssemblyPath;
        private AnalysisResult Result;

        public Steps(ITestOutputHelper output) : base(output)
        {
        }

        public void Dispose()
        {
            Driver?.Dispose();
        }

        public void GivenWorkingDirectory(string path)
        {
            Driver.SetWorkingDirectory(path);
            WorkingDir = path;

            Given("a working directory of " + path);
        }

        public void GivenTargetAssembly(string assemblyName, string version)
        {
            TargetAssemblyPath = Path.Combine(WorkingDir, assemblyName, ".dll");
            Driver.AddAssembly(assemblyName, version, TargetAssemblyPath);

            Given($"target assmembly {assemblyName}.dll v{version}");
        }

        public void WhenAssemblyIsAnalysed()
        {
            Result = Driver.GetDependencyAnalysis(TargetAssemblyPath);

            When("the target assmebly is analyzed");
        }

        public void ThenAssemblyNameIs(string assemblyName)
        {
            Result.Should().NotBeNull();
            Result.AssemblyName.Should().Be(assemblyName);

            Then("the target assembly name is " + assemblyName);
        }

        public void ThenAssemblyFileNameIs(string fileName)
        {
            Result.Should().NotBeNull();
            Result.FileName.Should().Be(fileName);

            Then("the target assembly file name is " + fileName);
        }

        public void ThenAssemblyFullPathIs(string fullPath)
        {
            Result.Should().NotBeNull();
            Result.FullPath.Should().Be(fullPath);

            Then("the target assembly full path is " + fullPath);
        }

        public void ThenAssemblyVersionIs(Version version)
        {
            Result.Should().NotBeNull();
            Result.AssemblyVersion.Should().Be(version);

            Then("the target assembly version is " + version);
        }
    }
}
