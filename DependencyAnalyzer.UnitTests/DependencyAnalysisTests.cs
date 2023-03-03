using System;
using Xunit;
using Xunit.Abstractions;

namespace DependencyAnalyzer.UnitTests
{
    public class DependencyAnalysisTests
    {
        private static Steps CreateSteps(ITestOutputHelper output) => new Steps(output);

        private readonly ITestOutputHelper Output;

        public DependencyAnalysisTests(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void Returns_target_assembly_details()
        {
            using (var steps = CreateSteps(Output))
            {
                steps.GivenWorkingDirectory("C:\\Dir");
                steps.GivenTargetAssembly("Alpha.Bravo", "1.2");
                steps.WhenAssemblyIsAnalysed();
                steps.ThenAssemblyNameIs("Alpha.Bravo");
                steps.ThenAssemblyFileNameIs("Alpha.Bravo.dll");
                steps.ThenAssemblyFullPathIs("C:\\Dir\\Alpha.Bravo.dll");
                steps.ThenAssemblyVersionIs(new Version(1, 2));
            }
        }



        /*
         * Returns target assembly details
         * Finds target assembly with path relative to working dir
         * Returns bin folder path
         * Throws if target assembly not found
         * Throws if target assembly cannot be loaded
         * Dependency list is empty if target has no dependencies
         * Dependency list contains single dependency
         * Dependency list contains multiple dependencies
         * Indicates dependant assembly was found
         * Indicates dependant assembly was not found
         * Indicates assembly version mismatch
         * Indicates assembly public key mismatch
         * Dependency list contains transitive dependencies
         * Ignores known system dependencies
         * Removes duplicate dependencies from list
         * Dependency list contains dependencies that differ by version
         */
    }

    public class BindingAnalysisTests
    {
        /*
         * Returns config file path
         * Finds config file based on target assembly by default
         * Tries to find config file with path relative to bin folder
         * Tries to find config file with path relative to working dir
         * Throws if config file not found
         * Throws if config file cannot be read
         * Binding list is empty if target has no dependencies
         * Binding list contains assembly binding
         * Identifies bindings for assemblies not in dependency list
         * Identifies bindings with incorrect old version
         * Identifies bindings with incorrect new version
         * Identifies bindings with incorrect public key
         * Identifies bindings where assembly downgrades dependency version
         * Adds missing bindings
         */
    }

    public class BindingOutputTests
    {
        /*
         * Adds missing bindings to config file
         * Removes unused bindings if force is true
         * Replaces bindings with incorrect old version if force is true
         * Replaces bindings with incorrect new version if force is true
         * Replaces bindings with incorrect public key if force is true
         * Preserves existing bindings
         * Preserves other config file sections
         * Sorts bindings alphabetically
         * Throws if config file cannot be written
         */
    }
}