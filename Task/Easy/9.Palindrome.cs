using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy
{
    public class Palindrome
    {
        private int x;
        public Palindrome(int x)
        {

            this.x = x;

        }
        public bool GetValue()
        {
            bool IsNegativ = false;

            int Num = x;

            if (Num < 0)
            {
                IsNegativ = true;
                Num *= -1;
            }

            for (int i = 0; i < Num.ToString().Length; i++)
            {
                if (Num % Math.Pow(10, i) == 0)
                {
                    Num /= 10;
                }
                else
                {
                    break;
                }
            }



            if (IsNegativ)
            {
                Num *= -1;
            }

            string NumRev = "";

            for (int i = Num.ToString().Length; i > 0; i--)
            {
                NumRev += Num.ToString()[i - 1];
            }

            if (int.Parse(NumRev) == Num)
            {
                return true;
            }
            else { return false; }

        }
    }
}
