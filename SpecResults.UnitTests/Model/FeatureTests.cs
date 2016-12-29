using NUnit.Framework;
using SpecResults.Model;

namespace SpecResults.UnitTests.Model
{
	[TestFixture]
	public class FeatureTests
	{
		[Test]
		[TestCase("line 1\nline 2", "line 1\nline 2")]
		[TestCase("line 1\r\nline 2", "line 1\nline 2")]
		public void Description_SetWithCRandLF_OnlyContainsLR(string description, string expectedResult)
		{
			var feature = new Feature {Description = description};

			Assert.AreEqual(expectedResult, feature.Description);
		}
	}
}