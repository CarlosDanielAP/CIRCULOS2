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



       

   class Cuadro
    {
        double Arr;
        double Aba;
        double Izq;
        double Der;
      

        public Cuadro()
        {
            Arr = 0;
            Aba = 0;
            Izq = 0;
            Der = 0;
        }

        
       public void Imprime(Punto a, Punto b)
        {
            Der = a.x + b.x;
            Izq = a.x;
            Arr = a.y + b.y;
            Aba = a.y;

            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(a.x, a.y);
            GL.Vertex2(b.x, a.y);
            GL.Vertex2(b.x, b.y);
            GL.Vertex2(a.x, b.y);

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

        /*public double Abajo
        {
            get { return Aba; }
        }

        public double Arriba
        {
            get { return Arr; }
        }*/

    }
}

