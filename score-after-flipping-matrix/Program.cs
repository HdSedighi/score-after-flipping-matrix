using System;

public class Solution
{
    public int MatrixScore(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        
        // Step 1: Ensure the leading bit of each row is 1
        for (int i = 0; i < m; i++)
        {
            if (grid[i][0] == 0)
            {
                ToggleRow(grid, i);
            }
        }

        // Step 2: Ensure each column has the maximum number of 1s
        for (int j = 1; j < n; j++)
        {
            int countOnes = 0;
            for (int i = 0; i < m; i++)
            {
                if (grid[i][j] == 1)
                {
                    countOnes++;
                }
            }
            if (countOnes <= m / 2)
            {
                ToggleColumn(grid, j);
            }
        }

        // Step 3: Calculate the score
        int score = 0;
        for (int i = 0; i < m; i++)
        {
            int rowValue = 0;
            for (int j = 0; j < n; j++)
            {
                rowValue = (rowValue << 1) | grid[i][j];
            }
            score += rowValue;
        }

        return score;
    }

    private void ToggleRow(int[][] grid, int row)
    {
        int n = grid[0].Length;
        for (int j = 0; j < n; j++)
        {
            grid[row][j] = grid[row][j] == 0 ? 1 : 0;
        }
    }

    private void ToggleColumn(int[][] grid, int col)
    {
        int m = grid.Length;
        for (int i = 0; i < m; i++)
        {
            grid[i][col] = grid[i][col] == 0 ? 1 : 0;
        }
    }
}
