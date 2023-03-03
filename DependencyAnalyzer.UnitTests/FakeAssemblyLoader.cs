using System;
using System.Collections.Generic;
using System.Linq;
using DependencyAnalyzer.Reflection;

namespace DependencyAnalyzer.UnitTests
{
    public class FakeAssemblyLoader: IAssemblyLoader
    {
        public AssemblyInfo LoadFrom(string path)
        {
            throw new NotImplementedException();
        }

        public void Add(string fullPath, AssemblyInfo assemblyInfo)
        {
            throw new NotImplementedException();
        }
    }
}
