using SortingAlgo;


#region Quick Sort Algoritham
//Console.WriteLine("Hello, World!");

//QuickSort quickSort = new QuickSort();

//int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
//int n = 10, i;
//Console.WriteLine("Quick Sort");
//Console.Write("Initial array is: ");
//for (i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//quickSort.quickSort(arr, 0, 9);
//Console.WriteLine("\n");
//Console.Write("Sorted Array is: ");
//         for (i = 0; i < n; i++)
//{
//    Console.Write(arr[i] + " ");
//}

#endregion
#region Suduko Algoritham
//GFG gFG = new GFG();
//int[,] grid = { { 3, 0, 6, 5, 0, 8, 4, 0, 0 },
//                         { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
//                         { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
//                         { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
//                         { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
//                         { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
//                         { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
//                         { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
//                         { 0, 0, 5, 2, 0, 6, 3, 0, 0 } };

//if (gFG.solveSudoku(grid, 0, 0))
//    gFG.print(grid);
//else
//    Console.WriteLine("No Solution exists");

#endregion
#region Rat in Maze
RatMaze rat = new RatMaze();
 int N;
int[,] maze = { { 1, 0, 0, 0 },
                    { 1, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 1, 1, 1, 1 } };

N = maze.GetLength(0);
rat.solveMaze(maze);
#endregion



                             
