using System.Linq;
// Highest Product
// Test Cases:
// {1, 2, 3, 4} - 24 ; {0, -1, 10, 5, 7} - 350
// {-5, -2, -1, 0, 0, 1, 1, 5} - 50; {-5, -2, -1, 0, 0, 3, 4, 5} - 60;
List<int> n = new List<int> { 0, -1, 10, 5, 7 };

n.Sort();

Console.WriteLine(String.Join(", ",n));

int lo2hi1 = n[0] * n[1] * n[n.Count - 1];
int hi3 = n[n.Count - 1] * n[n.Count - 2] * n[n.Count - 3];

if(lo2hi1 > hi3) {
    Console.WriteLine(lo2hi1);
} else {
    Console.WriteLine(hi3);
}