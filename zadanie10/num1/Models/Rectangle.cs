using num1.Models;

namespace num1.Models
{
  
        class Rectangle :Square
        {
           public int raznStaron;

            public Rectangle(int a):base(a)
            {

            }
            public Rectangle(int raznStaron,int a) :base(a)
            {
                this.raznStaron = raznStaron;
                
            }
            
            
            public override double CalculatS()
            {
                return raznStaron * a ;
            }
        }
    
}
