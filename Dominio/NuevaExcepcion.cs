using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex2020ProgIIIv2
{
    public class NuevaExcepcion : Exception
    {
        public NuevaExcepcion(string message) : base(message) { }
    }
}
