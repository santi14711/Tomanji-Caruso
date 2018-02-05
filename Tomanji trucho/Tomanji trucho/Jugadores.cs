using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomanji_trucho
{
    public class Jugadores
    {
        public string Nombre { get; set; }
        public int Puntos { get; set; }

        public Jugadores(string Pnom)
        {
            Nombre = Pnom;
            Puntos = 0;
        }
    }
}
