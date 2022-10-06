    internal class Bulb {

        // Code
        //int[] states = { 0, 1, 0, 1 };
        //int N = states.Length;

        // Function Code
        int bulbs(int[] A, int N) {
            // To keep track of switch presses so far
            int count = 0;
            for (int i = 0; i < N; i++) {
                if (A[i] == 0) {
                    A[i] = 1;
                    for (int j = i + 1; j < N; j++) {
                        if (A[j] == 1) {
                            A[j] = 0;
                        } else {
                            A[j] = 1;
                        }
                    }
                    count++;
                }
            }
            return count;
        }
    }