using SpecNuts.Model;

namespace SpecNuts.EventArgs
{
	public class FeatureEventArgs : ReportEventArgs
	{
		public FeatureEventArgs(Reporter reporter)
			: base(reporter)
		{
			Feature = Reporter.CurrentFeature;
		}

		public Feature Feature { get; internal set; }
	}
}