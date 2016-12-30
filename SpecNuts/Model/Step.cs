using System.Collections.Generic;

namespace SpecNuts.Model
{
	public class Step : ReportItem
	{
		public string MultiLineParameter { get; set; }
		public ExceptionInfo Exception { get; set; }
        public new StepResult Result { get; set; }
        public List<Row> Rows { get; set; } 
    }
}