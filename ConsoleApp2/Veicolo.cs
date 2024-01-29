using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Veicolo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string KmTagliando(int attuale)
        {
            if (attuale > 10000)
            {
                return "Tagliando da effettuare urgentemente";
            }
            else
            {
                return "Tagliando da effettuare tra " + (10000 - attuale) + " km";
            }
        }

    }
}
