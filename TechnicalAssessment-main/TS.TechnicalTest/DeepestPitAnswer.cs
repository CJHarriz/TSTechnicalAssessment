namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        /* Breakdown - (Writing out my thoughts)
         * A pit requires 3 provided points.
         *  - The first point P must be greater or equals to 0
         *  - The second point Q must be less than the first point P and the third point R
         *  - The third point R must be greater than the second point Q
         *  
         * Point from P continuously decrease until point Q is found in the sequence
         * Likewise the sequence from Q continuously increases until point R is found.
         * Depth is the smaller of the two differences between the points. [*]
         * 
         * Use change in direction to determine a pit?
         * Try get relevent points below 0 that actually matter in defining a pit.
        */

        // Guard clause ensuring we can capture at least 3 points
        if (points.Length < 3)
        {
            Console.WriteLine("Not enough points to form a pit.");
            return -1;
        }

        // Store all points below 0
        int[] potentialPitBottoms = points.Where(x => x < 0).ToArray();

        // Guard clause ensuring we can capture at least 1 point below 0
        if (potentialPitBottoms.Length < 1)
        {
            Console.WriteLine("No points below 0 to form a pit.");
            return -1;
        }

        // Compare adjacent points  


        // Default return -1
        return -1;
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
