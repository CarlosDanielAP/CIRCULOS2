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

        public bool checarmitad(Cuadro raqueta,Circulo pelotita)
        {
            double mitad = raqueta.Arriba / 2;
            //si la pelotita choca en la mitad de arriba es verdadero 
          
            if (pelotita.CentroY>mitad)
                return true;
           else 
                return false;
        }

        public bool checarlacolision(Cuadro player, Circulo pelota)
        {
        
            if (pelota.Derecha <= player.Izquierda)
            {


                return false;
            }
            if (pelota.Izquierda >= player.Derecha)
            {


                return false;
            }

            if (pelota.Arriba <= player.Abajo)
            {
               

                return false;
            }


            if (pelota.Abajo >= player.Arriba)
            {


                return false;
            }



            return true;
        }


    }
}
