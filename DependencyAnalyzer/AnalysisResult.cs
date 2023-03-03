using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyAnalyzer
{
    public class AnalysisResult
    {
        public string AssemblyName { get; }
        public Version AssemblyVersion { get; }
        public string FileName { get; }
        public string FullPath { get; }
    }
}
