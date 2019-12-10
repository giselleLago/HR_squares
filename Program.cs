using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the squares function below.
    static int squares(int a, int b)
    {
        var contSquare = 0;
       // var finalR = b - a + 1;
        //IEnumerable<int> rang = Enumerable.Range(a, finalR);
        for (int i = a; i <= b; i++)
        {
            if ((Math.Ceiling(Math.Sqrt(i))) == (Math.Floor(Math.Sqrt(i))))
            {
                contSquare++;
            }
        }
        return contSquare;
    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            int result = squares(a, b);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
