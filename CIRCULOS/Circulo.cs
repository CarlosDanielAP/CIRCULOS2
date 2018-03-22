using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace CIRCULOS
{
    class Circulo
    {
        double numLineas;


        double Arr;
        double Aba;
        double Izq;
        double Der;


        public Circulo()
        {
            Arr = 0;
            Aba = 0;
            Izq = 0;
            Der = 0;
            numLineas = 90;

        }


        public void Imprime(Punto a, double radio)
        {

            Der = a.x - radio;
            Izq = a.x + radio;
            Arr = a.y - radio;
            Aba = a.y + radio;
            GL.Color3(0.0f, 0.0f, 0.0f);
            GL.Begin(PrimitiveType.Polygon);
            for (double i = 0; i < numLineas; i++)
            {

                GL.Vertex2(a.x + (Math.Cos((i * Math.PI * 2) / numLineas) * radio), a.y + (Math.Sin((i * Math.PI * 2) / numLineas) * radio));


            }
            GL.End();

        }


        public double Derecha
        {

            get { return Der; }
        }

        public double Izquierda
        {
            get { return Izq; }
        }

        public double Abajo
        {
            get { return Aba; }
        }

        public double Arriba
        {
            get { return Arr; }
        }

    }
}




