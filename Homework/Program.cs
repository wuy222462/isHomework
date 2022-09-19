using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project;

class Class1

{

    static void Main()
    {
        //分别利用while和for循环，计算出1000 + 999 + 998 + 997 +……+100/*的值*/
        int i, sum;
        i = 100;
        sum = 0;
        while (i <= 1000)
        {
            sum += i;
            Console.WriteLine(sum);
            i++;

        }


    }

}



