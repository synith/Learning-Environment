using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Debug.Log(i);
            }
        }
        */

        int[] primes = new int[100];
        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = i;
        }

        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i] != 0)
            {
                for (int j = i + i; j < primes.Length; j += i)
                {
                    primes[j] = 0;
                }
            }
        }

        for (int i = 0; i < primes.Length; i++)
        {
            if (primes[i] != 0 && primes[i] != 1)
            {
                Debug.Log(primes[i]);
            }
        }












        /*
        int width = 2;
        int height = 3;

        for (int x = 0; x <= width; x++)
        {
            if (x == 1) continue;
            for (int y = 0; y <= height; y++)
            {
                if (y == 1) break;
                Debug.Log("x: " + x + ", y: " + y);
            }
        }
        */

        /*
        List<char> charList = new List<char> { 'a', 'b', 'c', 'd', 'e' };

        foreach (char c in charList)
        {
            if (c == 'b') break;
            Debug.Log(c);
        }

        
        for (int i = 0; i < charList.Count; i++)
        {
            Debug.Log(i + ": " + charList[i]);

            if (charList[i] == 'b')
            {
                charList.RemoveAt(i);
                i--;
            }
        }
        
        int i = 5;        
        while (i < 3)
        {
            i++;
            Debug.Log(i);
        }        

        do
        {
            i++;
            Debug.Log(i);
        } while (i < 3);
        */
    }

}
