using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public abstract bool MegmentiAVilagot();
        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos.MekkoraAzEreje()<this.MekkoraAzEreje())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double MekkoraAzEreje()
        {
            return szuperero;
        }

        public override string ToString()
        {
            if (vanEGyengesege==true)
            {
                return $"Szupererő: {this.szuperero}; van gyengesége";
            }
            else
            {
                return $"Szupererő: {this.szuperero}; nincs gyengesége";
            }
        }
    }
}
