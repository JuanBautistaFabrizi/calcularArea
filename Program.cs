using System;

namespace clase_11
{
    class Program
    {
        static void Main(string[] args)
        {
             
            var rectangulo = new Rectangulo(4,6);
            Imprimir(rectangulo);

            Triangulo triangulo = new Triangulo(3.7,4.9);
            Imprimir(triangulo);

            Console.ReadKey();
           
    }
         static void Imprimir(FiguraGeometrica figura)
        {
            Console.WriteLine(figura.Area());
            Console.WriteLine(figura.Perimetro());
            Console.WriteLine("------------------------");
        }
  }

}

             
        
            
