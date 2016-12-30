using System.Collections.Generic;

namespace SpecNuts.Model
{
	public class Scenario : TaggedReportItem
	{
        public List<Step> Steps { get; set; }
        public new string Keyword => "Scenario";
        public string Type => "scenario";
	}
}