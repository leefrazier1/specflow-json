using SpecNuts.Model;

namespace SpecNuts.EventArgs
{
	public class StepEventArgs : ScenarioEventArgs
    {
		public StepEventArgs(Reporter reporter)
			: base(reporter)
		{
			Step = reporter.CurrentStep;
		}

		public Step Step { get; internal set; }
	}
}