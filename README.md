# Intuition
The goal is to maximize the sum of binary numbers represented by each row in the matrix. To achieve the highest value for each row, we need to ensure that the most significant bit (leftmost) of each row is 1. Additionally, for each column, maximizing the number of 1s will help in achieving higher values when these rows are interpreted as binary numbers.

# Approach
1. **Toggle Rows for Leading 1s**: 
   - Traverse each row of the matrix. If the first element (most significant bit) of a row is 0, toggle the entire row. This ensures that the leading bit of each row is 1.

2. **Toggle Columns for Maximum 1s**: 
   - For each column starting from the second column, count the number of 1s. If the count of 0s is greater than the count of 1s, toggle the entire column. This maximizes the number of 1s in each column, thereby maximizing the binary value of each row.

3. **Calculate the Score**: 
   - After performing the row and column toggles, convert each row to its binary representation and sum these values to get the highest possible score.

# Complexity
- Time complexity:
  The time complexity of the solution is $$O(m \cdot n)$$ where \(m\) is the number of rows and \(n\) is the number of columns. This is because we iterate through the entire matrix to toggle rows and columns and then again to calculate the score.

- Space complexity:
  The space complexity is $$O(1)$$ (ignoring the input space) because we are modifying the matrix in place and do not use any additional data structures that scale with the input size.
