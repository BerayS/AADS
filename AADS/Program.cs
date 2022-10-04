
int[,] matrix = new int[,] {
    { 9, 2, 7, 8 },
    { 6, 4, 3, 7 },
    { 5, 8, 1, 8 },
    { 7, 6, 9, 4 },
};

int[,] lossMatrix = new int[4, 4];

for (int j = 0; j < matrix.GetLength(1); j++) {

    int[] column = Enumerable.Range(0, matrix.GetLength(0)).Select(i => matrix[i, j]).ToArray();
    int smallest = column.Min();
    for (int i = 0; i < matrix.GetLength(0); i++) {
        lossMatrix[i, j] = smallest - matrix[i, j];
    }
}
    
List<string> assignedJobs = new List<string>();
List<int> skippedColumns = new List<int>();
List<int> skippedRows = new List<int>();

int totalTimeSpent = 0;

for (int i = 0; i < lossMatrix.GetLength(0); i++) {
    if(skippedRows.Contains(i)) {
        continue;
    }
    int[] row = Enumerable.Range(0, matrix.GetLength(1)).Where(j => !skippedColumns.Contains(j)).Select(j => lossMatrix[i, j]).ToArray();
    int smallest = row.Max();
    for (int j = 0; j < lossMatrix.GetLength(1); j++) {
        if (skippedColumns.Contains(j)) continue;

        if (lossMatrix[i, j] == smallest) {
            totalTimeSpent += matrix[i, j];
            skippedColumns.Add(j);
            skippedRows.Add(i);
            assignedJobs.Add($"Worker {i} = Job {j}");
        }
    }
}

Console.WriteLine(String.Join("\n", assignedJobs));
Console.WriteLine($"Total Time Spent: {totalTimeSpent}");

Console.ReadLine();