using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextMatcher
{
	[TestClass]
	public class UnitTests
	{
		private const string MainText =
			"Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

		[TestMethod]
		public void When_Given_The_Main_Text_And_The_Letter_P_The_Result_Should_Be_1()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "P");

			Assert.AreEqual(1, results.Length);
			Assert.AreEqual(1, results[0]);
		}

		[TestMethod]
		public void When_Given_The_Main_Text_And_The_Subtext_Px_No_Matches_Should_Be_Found()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "Px");

			Assert.AreEqual(0, results.Length);
		}
	}
}
