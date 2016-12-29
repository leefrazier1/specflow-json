using System.Collections.Generic;

namespace SpecResults.Model
{
    public class Tag : ReportItem
    {
        public new string Name { get; set; }
    }

    public class TaggedReportItem : ReportItem
	{
		public List<Tag> Tags { get; set; }
	}
}