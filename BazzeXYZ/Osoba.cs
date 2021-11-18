using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazzeXYZ
{
    public class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeIPrezime => $"{Ime} {Prezime}";

        public int Godiste { get; set; }

        public int Id { get; set; }
    }
}
