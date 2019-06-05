using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public static class TriangleSolver
    {
        public static int s1;
        public static int s2;
        public static int s3;



        public static string Analyze(int s1, int s2, int s3)
        {
            string gogo = "";

            if ((s1 + s2 > s3) && (s2 + s3 > s1) && (s3 + s1 > s2))
            {

                //gogo = "Forms Triangle";

                if (s1 == s2 && s2 == s3 && s3 == s1)
                {
                    gogo = "Forms Equilateral Triangle";
                }
                else if (s1 == s2 || s2 == s3 || s3 == s1)
                {
                    gogo = "Forms Isosceles Triangle";

                }
                else if (s1 != s2 && s2 != s3 && s3 != s1)
                {
                    gogo = "Forms Scalene Triangle";
                }
                Console.ReadLine();
            }
            else
            {
                gogo = "Doesnot Form Triangle";
            }

            return gogo;
        }
    }

}


