using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCULOS
{
   
    class Program
    {
        static void Main(string[] args)
        {

            VentanaGame screen = new VentanaGame(800, 700);
            screen.Title = "Mi otro cuadro";
            screen.Run();
        }
    }
}
