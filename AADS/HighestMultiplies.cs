using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AADS {
    internal class HighestMultiplies {
        // Highest Product
        //        // Test Cases:
        //        // {1, 2, 3, 4} - 24 ; {0, -1, 10, 5, 7} - 350
        //        // {-5, -2, -1, 0, 0, 1, 1, 5} - 50; {-5, -2, -1, 0, 0, 3, 4, 5} - 60;
        //        List<int> n = new List<int> { 0, -1, 10, 5, 7 };
        //        List<int> nCopy = new List<int> { 0, -1, 10, 5, 7 };
        //        List<int> highestN = new List<int>();
        //        List<int> lowestAndHighest = new List<int>();
        //        int highestThree = 1;
        //        int lowestAndHighestResult = 1;
        //        int finalResult = 0;
        //        int i = 0;

        //for (i = 0; i< 3; i++) {
        //    int temporaryHighest = n.Max();
        //        highestN.Add(temporaryHighest);
        //    n.Remove(temporaryHighest);
        //}

        //for (int j = 0; j< 3; j++) {
        //    int temporaryLowestAndHighest;
        //    if(j == 2) {
        //        temporaryLowestAndHighest = nCopy.Max();
        //        lowestAndHighest.Add(temporaryLowestAndHighest);
        //    } else {
        //    temporaryLowestAndHighest = nCopy.Min();
        //    lowestAndHighest.Add(temporaryLowestAndHighest);
        //    nCopy.Remove(temporaryLowestAndHighest);
        //}
        //}

        //foreach (int num in highestN) highestThree = highestThree * num;
        //foreach (int num in lowestAndHighest) lowestAndHighestResult = lowestAndHighestResult * num;

        //if (lowestAndHighestResult > highestThree) {
        //    finalResult = lowestAndHighestResult;
        //} else if (lowestAndHighestResult < highestThree) {
        //    finalResult = highestThree;
        //}

        //Console.WriteLine(finalResult);
        //    }
    }
}
