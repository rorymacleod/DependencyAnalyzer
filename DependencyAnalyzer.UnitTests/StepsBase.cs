using Xunit.Abstractions;

namespace DependencyAnalyzer.UnitTests
{
    public abstract class StepsBase
    {
        private bool AndGiven;
        private bool AndWhen;
        private bool AndThen;

        protected readonly ITestOutputHelper Output;

        protected StepsBase(ITestOutputHelper output)
        {
            Output = output;
        }

        protected void Given(string message)
        {
            Output.WriteLine((AndGiven ? "And given " : "Given ") + message);
            AndGiven = true;
        }

        protected void When(string message)
        {
            Output.WriteLine((AndWhen ? "And when " : "When ") + message);
            AndWhen = true;
        }

        protected void Then(string message)
        {
            Output.WriteLine((AndThen ? "And then " : "Then ") + message);
            AndThen = true;
        }
    }
}
