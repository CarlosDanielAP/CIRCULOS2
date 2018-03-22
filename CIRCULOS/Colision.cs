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
