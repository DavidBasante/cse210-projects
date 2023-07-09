using System;

namespace Foundation1
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius){
            this.radius = radius;
        }

        public double GetRadius(){
            return radius;
        }

        public override double CalculateArea(){
            return 3.14 * radius * radius;
        }
    }
}