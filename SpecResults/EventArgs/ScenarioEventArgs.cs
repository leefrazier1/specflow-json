using SpecNuts.Model;

namespace SpecNuts.EventArgs
{
	public class ScenarioEventArgs : FeatureEventArgs
	{
		public ScenarioEventArgs(Reporter reporter)
			: base(reporter)
		{
			Scenario = Reporter.CurrentScenario;
		}

		public Scenario Scenario { get; internal set; }
	}
}