using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    class Estado
    {
        private int codReso { get; set; }
        private string estadoResolucion { get; set; }
        private string motivoResolucion { get; set; }


        public Estado()
        {
            codReso = 0;
            estadoResolucion = string.Empty;
            motivoResolucion = string.Empty;
        }
    }
}
