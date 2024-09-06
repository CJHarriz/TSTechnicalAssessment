namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        // Ensure we have at least 3 points
        if (points.Length < 3)
        {
            Console.WriteLine("Not enough points to form a pit.");
            return -1;
        }

        var peaks = new List<int>()
        {
            points[0]
        };

        // Loop through the points excluding the added ends to find peaks and valleys
        for (int i = 1; i < points.Length - 1; i++)
        {
            if (IsPointAPeak(points[i], points[i-1], points[i+1]))
            {
                peaks.Add(points[i]);
            }
        }
        peaks.Add(points[^1]);

        // Guard clause ensuring we have at least 3 peaks
        if (peaks.Count < 3)
        {
            Console.WriteLine("Not enough peaks to form a pit.");
            return -1;
        }

        var deepestPit = -1;

        // Find the deepest pit
        for (int i = 1; i < peaks.Count - 1; i++)
        {
            if (peaks[i] > peaks[i -1] || peaks[i] > peaks[i + 1])
            {
                continue;
            }
            // Find the lowest point between the peaks
            var lowestPoint = Math.Max(peaks[i] - peaks[i - 1], peaks[i] - peaks[i + 1]);

            // Flip sign to get the depth of the pit
            lowestPoint *= -1;

            deepestPit = Math.Max(deepestPit, lowestPoint);
        }

        return deepestPit;
    }

    // Is peak/valley function
    private static bool IsPointAPeak(int point, int prePoint, int postPoint)
    {
        return (point > prePoint && point > postPoint) || (point < prePoint && point < postPoint);
    }
}

#region Footnotes
//Requirement

//Given an array of coordinates that plot pits and hills on a graph, find the deepest pit and provide the
//depth as per the specifications below.

//• A non-empty array A consisting of N integers is given.A pit in this array is any triplet of integers (P, Q,
//R) such that


//o 0 ≤ P > Q<R;
//o sequence[A[P], A[P + 1], ..., A[Q]] is strictly decreasing,
//i.e.A[P] > A[P + 1] = A[Q];
//o sequence A[Q], A[Q + 1], ..., A[R] is strictly increasing,
//i.e.A[Q] < A[Q + 1] = A[R].
//o The depth of a pit(P, Q, R) is the number min{A[P] − A[Q], A[R] − A[Q]}.


//• N is an integer within the range [1..1,000,000] ;
//• Each element of array A is an integer within the range [−100, 000, 000..100, 000, 000].

//• Only count the pit if the decline started above ground i.e., 0
//• Only count it as a pit if the decline is uninterrupted until the lowest point is reached (No flat line)

//• You stop counting when the water reaches the first ridge
//• The response must be -1 if there is no pits found in the provided array

#endregion
