using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Dipendente
    {
        public string Name { get; set; }
        public DateTime Entrata { get; set; }
        public DateTime Uscita { get; set; }
        public Animale AnimaleDomestico2 { get; set; }
        public Veicolo VeicoloAziendale { get; set; }
    }

}
