using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using DependencyAnalyzer.Reflection;

namespace DependencyAnalyzer
{
    public class Analyzer
    {
        private readonly IAssemblyLoader Loader;

        public Analyzer(IAssemblyLoader loader)
        {
            Loader = loader;
        }

        public AnalysisResult AnalyzeDependencies(string assemblyPath)
        {
            var assembly = Loader.LoadFrom(assemblyPath);

            return new AnalysisResult();
        }
    }
}
