using System.Collections.Generic;

namespace SpecResults.Model
{
	public class Step : ReportItem
	{
		public string MultiLineParameter { get; set; }
		public ExceptionInfo Exception { get; set; }
        public new StepResult Result { get; set; }
        public List<Row> Rows { get; set; } 
    }
}