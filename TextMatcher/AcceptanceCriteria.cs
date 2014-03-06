using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextMatcher
{
	[TestClass]
	public class AcceptanceCriteria
	{
		private const string MainText =
			"Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

		[TestMethod]
		public void Acceptance_Criteria_1_When_Given_The_Main_Text_And_The_Subtext_Polly_The_Result_Should_Be_1_26_51()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "Polly");

			Assert.AreEqual(3, results.Length);
			Assert.AreEqual(1, results[0]);
			Assert.AreEqual(26, results[1]);
			Assert.AreEqual(51, results[2]);
		}

		[TestMethod]
		public void Acceptance_Criteria_2_When_Given_The_Main_Text_And_The_Subtext_ll_The_Result_Should_Be_3_28_53_78_82()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "ll");

			Assert.AreEqual(5, results.Length);
			Assert.AreEqual(3, results[0]);
			Assert.AreEqual(28, results[1]);
			Assert.AreEqual(53, results[2]);
			Assert.AreEqual(78, results[3]);
			Assert.AreEqual(82, results[4]);
		}

		[TestMethod]
		public void Acceptance_Criteria_3_When_Given_The_Main_Text_And_The_Subtext_Ll_The_Result_Should_Be_3_28_53_78_82()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "Ll");

			Assert.AreEqual(5, results.Length);
			Assert.AreEqual(3, results[0]);
			Assert.AreEqual(28, results[1]);
			Assert.AreEqual(53, results[2]);
			Assert.AreEqual(78, results[3]);
			Assert.AreEqual(82, results[4]);
		}

		[TestMethod]
		public void Acceptance_Criteria_4_When_Given_The_Main_Text_And_The_Subtext_X_No_Matches_Should_Be_Found()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "X");

			Assert.AreEqual(0, results.Length);
		}

		[TestMethod]
		public void Acceptance_Criteria_5_When_Given_The_Main_Text_And_The_Subtext_Polx_No_Matches_Should_Be_Found()
		{
			var matcher = new TextMatcher();

			var results = matcher.FindMatches(MainText, "Polx");

			Assert.AreEqual(0, results.Length);
		}
	}
}
