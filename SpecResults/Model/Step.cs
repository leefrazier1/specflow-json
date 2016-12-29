using System.Collections.Generic;

namespace SpecResults.Model
{
	public class Step : ReportItem
	{
		public TableParam Table { get; set; }
		public string MultiLineParameter { get; set; }
		public ExceptionInfo Exception { get; set; }
        public new StepResult Result { get; set; }
    }
}