using System.Collections.Generic;

namespace TextMatcher
{
    public class TextMatcher
    {
		public int[] FindMatches(string text, string subtext)
		{
			var ret = new List<int>();
			
			var textChars = text.ToCharArray();
			var subtextChars = subtext.ToCharArray();

			for (int i = 0; i < textChars.Length; i++)
			{
				if (textChars[i] == subtextChars[0])
				{
					ret.Add(i + 1);
				}
			}

			return ret.ToArray();
		}
    }
}
