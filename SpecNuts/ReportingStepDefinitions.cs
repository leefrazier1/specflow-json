using System;
using SpecNuts.ReportingAspect;

namespace SpecNuts
{
	[Reporting]
	public abstract class ReportingStepDefinitions : ContextBoundObject
	{
		public void ReportStep(Action action, params object[] args)
		{
			Reporters.ExecuteStep(action, args);
		}
	}
}