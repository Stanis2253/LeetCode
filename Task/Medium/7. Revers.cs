using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversInteger
{
    public class Revers
    {
        public static int GetValue(int x) {

            

            bool IsDegree = false;

            double result = 0;

            int length = 0;

            int degree = 1;

            if (x < 0)
            {
                IsDegree = true;
                x *= -1;
            }

            int num = x;




            while (num > 0)
            {
                num /= 10;

                length++;
            }

            for (int i = 0; i < length;)
            {
                double a = (x % Math.Pow(10, degree)) / Math.Pow(10, degree - 1);

                double b = Math.Pow(10, length - 1);

                double c = (int)a;

                result += c * b;

                length--;
                degree++;
            }

            if (IsDegree)
            {
                result *= -1;
            }

            return int.Parse( result.ToString());
        }
    }
}
