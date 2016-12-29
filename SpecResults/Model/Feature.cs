using System.Collections.Generic;

namespace SpecResults.Model
{
	public class Feature : TaggedReportItem
	{
		private string _description;

	    private static readonly string DefaultUri = "/uri/placeholder";

		public string Description
		{
			get { return _description; }
			set { _description = string.IsNullOrEmpty(value) ? value : value.Replace("\r", ""); }
		}
        public string Uri => DefaultUri;
	    
        public List<Scenario> Elements { get; set; }
	    public new string Keyword => "Feature";
	}
}