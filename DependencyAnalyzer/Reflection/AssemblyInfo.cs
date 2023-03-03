using System;
using System.Reflection;

namespace DependencyAnalyzer.Reflection
{
    public class AssemblyInfo
    {
        public AssemblyName Name { get; private set; }

        public AssemblyInfo(AssemblyName name)
        {
            Name = name;
        }

    }
}
