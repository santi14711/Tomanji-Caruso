using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomanji_trucho
{
    public static class todo
    {
        public static List<Jugadores> nombresjugadores = new List<Jugadores>(); //array de personas
        public static Random TurnoJug = new Random();//numero random
        public static List<Retos> CantidadRetos = new List<Retos>(); //array de retos
        public static PantalladeJuego PantallaJuego = new PantalladeJuego();
        public static int retoactual = 0;
        public static PantalladeJuego pan = new PantalladeJuego();
        public static string ruta = "";
        public static string mensaje = "";
        public static Boolean ContieneNums(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

    }
}
