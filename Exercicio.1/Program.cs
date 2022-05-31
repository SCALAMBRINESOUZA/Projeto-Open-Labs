using System;

namespace projectOpenLabs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            t.CalcularArea(30,20);
            Retangulo r = new Retangulo();
            r.CalcularArea(30,20);
            
        }
    }

class Poligono{
    public float Area { get;set; }
    public float @Base  { get;set; }
    public float Altura { get;set; }
    public virtual void CalcularArea(float base, float altura) {}
    };

    class Triangulo : Poligono{
        public override void CalcularArea(float base, float altura){
            this.Base = base;
            this.Altura = altura;
            this.Area = (base * altura) / 2 ;
        }
    } 
 
    class Retangulo : Poligono{
        public override void CalcularArea(float base, float altura){
            this.Base = base;
            this.Altura = altura;
            this.Area = base * altura;
    }  
  }
}
