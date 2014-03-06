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

			if (subtextChars.Length == 0)
			{
				return new int[0];
			}

			for (int i = 0; i < textChars.Length - subtext.Length; i++)
			{
				if (CharsMatch(textChars[i], subtextChars[0]))
				{
					var match = true;
					
					for (int j = 0; j < subtextChars.Length; j++)
					{
						match = match && CharsMatch(textChars[i + j], subtextChars[j]);
					}

					if (match)
					{
						ret.Add(i + 1);
					}
				}
			}

			return ret.ToArray();
		}

	    private bool CharsMatch(char textChar, char subtextChar)
	    {
		    return char.ToLower(textChar) == char.ToLower(subtextChar);
	    }
    }
}
