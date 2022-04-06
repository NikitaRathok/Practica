using System;
using num1.Models;

namespace num1.Models
{
   
        class Square
        {
            readonly string name;
            public int a;

            public Square(int a)
            {
                this.a = a;
            }
            public virtual double CalculatS()
            {
                return Math.Pow(a, 2);
            }
        }
    
}
