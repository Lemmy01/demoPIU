using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace AdministrareStocare
{
    public class AdministrareSondaje
    {

       List<Sondaj> sondaje = new List<Sondaj>();

        public AdministrareSondaje() { }

        public void adaugaSondaj(Sondaj sondaj)
        {
            sondaje.Add(sondaj);
        }

        public List<Sondaj> getSondaje()
        {
            return sondaje;
        }
    }
}
