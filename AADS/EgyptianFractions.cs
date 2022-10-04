class EgyptianFractions {
   
 void GetEgyptianFractions(int p, int q){
    if (p == 0 || q == 0) {
        return;
    }

    if (q % p == 0) {
        Console.Write($"1/{q / p} ");
        return;
    }

int r = (p + q) / p;
Console.Write($"1/{r} ");

int newP = p * r - q;
int newQ = q * r;
GetEgyptianFractions(newP, newQ);

}

}