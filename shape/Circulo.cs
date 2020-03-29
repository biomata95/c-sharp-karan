using System;

namespace shape
{
    class Circulo : Objeto
    {
        public double getArea(double raio){
            this.area = raio*raio*3.14;
            return this.area;

        }

        public double getPerimetro(double raio){
            this.perimetro = 2*3.14*raio;
            return this.perimetro; 
        }
    }
}
