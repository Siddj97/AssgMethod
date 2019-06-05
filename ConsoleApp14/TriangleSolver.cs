using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public static class TriangleSolver
    {


            public static string Analyze(int s1, int s2, int s3)
            {
            string gogo = string.Empty;
            if (s1 + s2 > s3 && s2 + s3 > s1 && s3 + s1 > s2)
            {
                if (s1 == s2 && s2 == s3 && s3 == s1)
                {
                    gogo = "Its is a Triangle\nForms Equilateral Triangle";
                }
                else if (s1 == s2 || s2 == s3 || s3 == s1)
                {
                    gogo = "Its is a Triangle\nForms Isosceles Triangle";

                }
                else if (s1 != s2 && s2 != s3 && s3 != s1)
                {
                    gogo = "Its is a Triangle\nForms Scalene Triangle";
                }
                
            }
            else
            {
                gogo = "Doesnot Form Triangle";
            }

            return gogo;
        }
    }

}


