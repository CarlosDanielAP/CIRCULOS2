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
    class Colision
    {
               
       public bool checarColision( Circulo bola, Cuadro jugador, Cuadro jugador2)
        {
            if (bola.Derecha <= jugador.Izquierda)
            {
                return false;

            } 
         

            if (bola.Izquierda <= jugador2.Derecha)
            {
                return false;
            }
          
           /* if (bola.Abajo >= jugador.Arriba)
            {
                return false;
            }
            if (bola.Izquierda >= jugador.Derecha)
            {
                return false;
            }*/
                  
             
                return true;
            

          
        }


    }
}
