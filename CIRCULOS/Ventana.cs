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



    class VentanaGame : GameWindow
    {
        Cuadro raqueta1 = new Cuadro();
        Cuadro raqueta2 = new Cuadro();
        Cuadro paredIZQ = new Cuadro();
        Cuadro paredDer = new Cuadro();
        Circulo boli = new Circulo();
        Punto uno = new Punto(1, 0);
        Punto dos = new Punto(2,7 );
        Punto tres = new Punto(13, 0);
        Punto cuatro = new Punto(14,1);
        Punto cinco = new Punto(5, 5);//punto para pelotita
        //puntos para paredes
        Punto seis = new Punto(0, 0);
        Punto siete = new Punto(1,13 );

        Punto ocho = new Punto(14, 0);
        Punto nueve = new Punto(15.5, 13);

        Colision colisionador = new Colision();

        bool chocaJugador = false;
       

        public VentanaGame(int ancho, int alto) : base(ancho, alto)
        {
           
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);


            switch (e.KeyChar)
            {
                
                    case 'w':
                    dos.y++;
                    
                    break;
                    case 's':
                    dos.y--;
                    break;

                case 'o':
                    cuatro.y++;
                    break;
                case 'l':
                    cuatro.y--;
                    break;



                }
        }
       


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0, 15, 0, 13, -1, 1);
          

        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.ClearColor(0.5f, 0.5f, 1f, 1f);

        }



        protected override void OnRenderFrame(FrameEventArgs e)
        {
            /////rebote de pelotita////
            if (chocaJugador == false)
            {

                if (!colisionador.checarlacolision(raqueta1, boli))
                {
                    cinco.x -= 0.1;
                }
                else
                {
                    chocaJugador = true;
                }
            }
            else
            {
                if (!colisionador.checarlacolision(raqueta2, boli))
                {
                    cinco.x += 0.1;
                }
                else
                {
                    chocaJugador = false;
                }

            }
            ///paredes limites
            if (colisionador.checarlacolision(paredIZQ, boli))
            {
                Console.WriteLine("punto p1");
            }
            if (colisionador.checarlacolision(paredDer, boli))
            {
                Console.WriteLine("punto p2");
            }



            base.OnRenderFrame(e);

            paredDer.Imprime(seis, siete);
            paredIZQ.Imprime(ocho, nueve);
            raqueta1.Imprime(uno, dos);
            raqueta2.Imprime(tres, cuatro);
            boli.Imprime(cinco, 0.5);
            uno.y = dos.y - 3;
            tres.y = cuatro.y - 3;

            this.SwapBuffers();
        }

       

    }
}
