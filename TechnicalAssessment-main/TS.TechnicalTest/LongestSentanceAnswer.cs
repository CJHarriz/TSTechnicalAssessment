namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        // Separate the string via the sentence delimiters.
        var sentences = s.Split(new char[] { '.', '?', '!' });

        // Instantiate a variable to store the most words in a sentence.
        var mostWords = 0;


        sentences.Aggregate((max, current) =>
        {
            // Going to split again and compare totals.
        });
        return mostWords;
    }
}

#region Footnotes
//Requirements

//Find the sentence containing the largest number of words in the given text and count the number of
//words it contains.
//• The text is specified as a string S consisting of N characters: letters, spaces, dots(.), question
//marks(?) and exclamation marks(!).
//• A sentence can be divided into words by splitting it at spaces.A sentence without words is
//valid, but a valid word must contain at least one letter.
//• The length of S is within the range[1..100];
//• String S consists only of letters(a−z, A−Z), spaces, dots(.), question marks(?) and
//exclamation marks(!).
#endregion