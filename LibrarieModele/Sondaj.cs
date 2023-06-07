using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Sondaj
    {
    public string NumePrenume { get; set; }
    public string Localitate { get; set; }
    public string PostRadio { get; set; }
    public bool Anonim { get; set; }
    public Sondaj() { }
    public Sondaj(string numePrenume, string localitate, string postRadio, bool anonim)
    {
        NumePrenume = numePrenume;
        Localitate = localitate;
        PostRadio = postRadio;
        Anonim = anonim;
    }
    public override string ToString()
    {
        return string.Format("{0}, Localitate: {1}, Post Radio preferat: {2}, Anonim: {3}", NumePrenume,
        Localitate, PostRadio, Anonim);
    }
}
}
