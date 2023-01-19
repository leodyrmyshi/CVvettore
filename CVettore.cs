using System;
using System.Linq;

public class Vettore {

    int idx;
    private int[] vettore;
    public Vettore () {
        vettore = new int[]{0};        
    }


    public Vettore(int N)
    {

        vettore = new int[N];
    }

    public bool Aggiungi(int val)
    {

        if( idx >= vettore.Length)
            return false;

        vettore[idx] = val;
        idx++;

        return true;
    }


    public int Somma()
    {
        int retval = 0;

        for(int idx=0 ; idx < vettore.Length; idx++)
        retval = retval + vettore[idx];

        return retval;
    }

    public int Ultimo()
    {
        if(vettore.Length==0)
        return 0;

        if(idx==0)
          return vettore[idx];

        return vettore[idx-1];
    }


}