using System;

namespace DependencyAnalyzer.Reflection
{
    public interface IAssemblyLoader
    {
        AssemblyInfo LoadFrom(string path);
    }
}
