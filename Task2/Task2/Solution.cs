using System;
public class Solution
{
    /*
    * Time complexity:  O(N), since we traverse the input array and where N is the length of the input array.
    * Space complexity: O(X), since X is the size of the input array, this solution uses an array of size X+1 to keep track of which positions are covered by leaves.
    */
    public int solution(int X, int[] A)
    {
        var covered = 0;

        // Array to track when each position is covered
        int[] leaves = new int[X + 1];

        for (int i = 0; i < A.Length; i++)
        {
            var position = A[i];

            // If leaf is on valid position and hasn't been covered before
            if (leaves[position] == 0 && position >= 1 && position <= X )
            {
                // Mark position as covered and increment the covered counter
                leaves[position] = 1;
                covered++;

                // If all positions are covered, return current time
                if (covered == X)
                {
                    return i;
                }
            }
        }

        // If all positions aren't covered, return -1
        return -1;
    }
}
