using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextMatcher
{
	[TestClass]
	public class UnitTests
	{
		private const string MainText =
			"Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

		[TestMethod]
		public void When_Given_The_Main_Text_And_An_Empty_String_There_Should_Be_No_Matches()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "");

			Assert.AreEqual(0, results.Length);
		}

		[TestMethod]
		public void When_Given_The_Main_Text_And_The_Subtext_team_There_Should_Be_No_Matches()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "team");

			Assert.AreEqual(0, results.Length);
		}

		[TestMethod]
		public void When_Given_The_Main_Text_And_The_Subtext_tea_There_Should_Be_1_Match_At_90()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "tea");

			Assert.AreEqual(1, results.Length);
			Assert.AreEqual(90, results[0]);
		}
	}
}