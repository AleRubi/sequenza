using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
        if(N <= 0){
            return new int[0];
        }
        int dim = 0;
        for (int i = 0; i < N; i++){
            dim += (i + 1);
        }
        int[] arr = new int[dim];
        int pos = 0, j = 0;
        for (int i = 0; i < N; i++){
            for (; j <= pos; j++){
                arr[j] = i + 1;
            }
            pos = j + i + 1;
        }
        return arr;
    }
}