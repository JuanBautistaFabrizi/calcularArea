using System;

namespace clase_11
{
    public class Triangulo : FiguraGeometrica
    {
        
        public double Base { get; }
        public double Altura { get; }

        public  Triangulo(double valorBase, double altura)
        {
            this.Base = valorBase;
            this.Altura = altura;
            
        }
        private double Hipotenusa
        {
            get
            {
                return Math.Sqrt(Math.Pow(Base,2) + Math.Pow(Altura, 2));
            }
        }

        public override double Area()
        {
            return Base * Altura / 2;
        }

        public override double Perimetro()
        {
            return this.Base + this.Altura + this.Hipotenusa;
        }
    }

}
    
