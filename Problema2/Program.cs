using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] {0,1};
            int n=2;
            int i, key, j;
                for (i = 1; i < n; i++)
                {
                    key = arr[i];
                    j = i - 1;
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }

        }
    }
}
