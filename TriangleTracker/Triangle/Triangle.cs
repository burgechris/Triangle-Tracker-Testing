// using System;
// using System.Collections.Generic;

namespace TriangleTracker
{
    public class Triangle
    {
       public static bool IsTriangle(int a, int b, int c)
       {
           if((a < b + c) && (b < a + c) && (c < b + a)) 
           {
               return true;
           }
           return false;    
       }

       public static bool IsEquilateral(int a, int b, int c)
       {
           if(a == b && b == c && a == c)
           {
               return true;
           }
           return false;
       }

       public static bool IsIsosceles(int a, int b, int c)
       {
           if(a == b && a != c || a == c && a!= b || b == c && b != a)
           {
               return true;
           }
           return false;
       }

       public static bool IsScalene(int a, int b, int c)
       {
           if(a != b && b != c && c != a)
           {
               return true;
           }
           return false;
       }
    }
}