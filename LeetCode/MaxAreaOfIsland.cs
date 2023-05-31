namespace LeetCode;

public static class MaxAreaOfIsland
{
    private record GridIndices(int I, int J) { }
    
    public static int CalculateOfMaxArea(int[][] grid)
    {
        var myStack = new Stack<GridIndices>();
        for(var i = 0; i < grid.Length; i++) 
        {
            for(var j = 0; j < grid.Length; j++) 
            {
                if (grid[i][j] == 1)
                {
                }
            }
        }
        return 1;    
    }
}