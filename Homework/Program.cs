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

        //        写一段代码，能够根据score（成绩）输出文本：
        //60以下：不及格
        //80以上：优秀
        //60 - 80：及格
        //注意：审查是否存在模糊的需求。如果存在，予以修正，作为注释包含在代码中。


        //模糊需求1优秀是否包含80分 
        //      2 如过成绩输入负数怎么办，
        //        3 满分是多少 输入超过满分怎么办
        //        


        int score;
        score = int.Parse(Console.ReadLine());

        if (score < 60)
        {
            Console.WriteLine("不及格");

        }
        else if (score < 80)
        {
            Console.WriteLine("及格");

        }
        else
        {

            Console.WriteLine("优秀");
        }


    }

}



