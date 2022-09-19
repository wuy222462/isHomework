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
        //让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值

        int i, sum;
        sum = 0;
        for (i = 1; i <= 99; i += 2)
        {
            sum += i;

        }
        Console.WriteLine(sum);//只输出一次和

    }

}



