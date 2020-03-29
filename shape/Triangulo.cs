using System;

namespace shape
{
    class Triangulo : Objeto
    {
        public double getArea(double baseTri,double alturaTri){
            this.area = (baseTri*alturaTri)/2;
            return area;
        }

        public double getPerimetro(double lado1,double lado2,double lado3){
            this.perimetro = lado1+lado2+lado3;
            return this.perimetro;
        }
    }
}
