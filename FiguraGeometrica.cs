namespace clase_11
{
    public abstract class FiguraGeometrica 



    {
        protected  string Nombre { get { string nombre = null; return nombre; } }
        public virtual  double Area()
        {
            return 0;
        }

        public  virtual double Perimetro()
        {
            return 0;
        }

      
    }
}
        
       
