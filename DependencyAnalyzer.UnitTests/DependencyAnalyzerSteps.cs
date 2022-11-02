using System;

namespace DependencyAnalyzer.UnitTests
{
    internal class DependencyAnalyzerSteps: IDisposable
    {
        private string WorkingDir = "C:\\Temp";

        public void Dispose()
        {
        }

        public void GivenWorkingDirectory(string path)
        {
            WorkingDir = path;
        }

        public void GivenTargetAssembly(string assemblyName, string version, string fullPath)
        {
            throw new NotImplementedException();
        }
    }
}
