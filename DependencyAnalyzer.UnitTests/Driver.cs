using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using DependencyAnalyzer.Reflection;

namespace DependencyAnalyzer.UnitTests
{
    public class Driver: IDisposable
    {
        private readonly FakeAssemblyLoader Loader = new FakeAssemblyLoader();

        public void Dispose()
        {
        }

        public void SetWorkingDirectory(string path)
        {
        }

        public void AddAssembly(string assemblyName, string version, string fullPath)
        {
            Loader.Add(fullPath, new AssemblyInfo(new AssemblyName(assemblyName) {
                Version = new Version(version)
            }));
        }

        public AnalysisResult GetDependencyAnalysis(string assemblyPath)
        {
            var analyzer = new Analyzer(Loader);
            var result = analyzer.AnalyzeDependencies(assemblyPath);
            return result;
        }
    }
}
