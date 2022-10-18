//// Largest Permutation

//using System.Collections.Immutable;

//string[] tokens = Console.ReadLine().Split(' ');
//string[] arr = Console.ReadLine().Split(' ');
//int n = int.Parse(tokens[0]);
//int k = int.Parse(tokens[1]);

//if (tokens.Length != 2 || arr.Length != n) {
//    throw new ArgumentException("Invalid input");
//}

//for (int i = 0; i < k; i++) {
//    int tempVar;
//    int maks;
//    if (arr[0] == arr.Max()) {
//        continue;
//    } else {
//        arr[0] = arr.Max();
//    }

//    maks = int.Parse(arr[0].Max());

//}

//int[] arr = new int[5] {4, 2, 3, 5, 1};

//Console.WriteLine(LargestPermutation(arr, 1));

//string LargestPermutation(int[] arr,int k) {
//    int tempVar;
//    foreach (int num in arr) {
//        if (arr[0] == arr.Max()) {
//            continue;
//        } else {
//            tempVar = arr[0];
//        }
//    }

//    string asd = string.Join(", ", arr);

//    return asd;
//}

string[] s = Console.ReadLine().Split(' ');
int N = int.Parse(s[0]);
int K = int.Parse(s[1]);
s = Console.ReadLine().Split(' ');
int[] P = new int[N];
int[] V = new int[N];

for (int i = 0; i < N; ++i) {
    int val = int.Parse(s[i]) - 1;
    P[val] = i;
    V[i] = val;
}
for (int i = 0; i < N && K > 0; ++i)
    if (P[N - i - 1] != i) {
        int idx = P[N - i - 1];
        int val = V[i];
        P[N - i - 1] = i;
        V[i] = N - i - 1;
        P[val] = idx;
        V[idx] = val;
        K--;
    }
Console.Write(V[0] + 1);
for (int i = 1; i < N; ++i)
    Console.Write(" {0}", V[i] + 1);
Console.WriteLine();