using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion02.Modelos
{
    internal class Superheroe
    {
        public string Nombre { get; set; }
        public string Superpoder { get; set; }

        public override string ToString()
        {
            return $"Superhéroe: {Nombre} tiene el poder de {Superpoder}";
        }
    }
}
