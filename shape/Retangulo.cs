using System;

namespace shape
{
    class Retangulo : Objeto
    {

        public double getArea(double lado1,double lado2){
            this.area = lado1*lado2;
            return this.area;

        }

        public double getPerimetro(double lado1,double lado2){
            this.perimetro  = (lado1*2)+(lado2*2);
            return this.perimetro;
        }
    }
}
