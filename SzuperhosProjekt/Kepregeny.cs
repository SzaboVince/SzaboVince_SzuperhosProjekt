using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string eleresiUt)
        {
            StreamReader sr=new StreamReader(eleresiUt);
            while (!sr.EndOfStream)
            {
                string[] adatok = sr.ReadLine().Split(' ');
                string a = adatok[0];
                int b = Convert.ToInt32(adatok[1]);
                if (a=="Batman")
                {
                    Batman batman = new Batman();
                    szuperhosok.Add(batman);
                    for (int i = 0; i < b; i++)
                    {
                        batman.KutyutKeszit();
                    }
                }
                else if (a=="Vasember")
                {
                    Vasember vasember = new Vasember();
                    szuperhosok.Add(vasember);
                    for (int i = 0; i < b; i++)
                    {
                        vasember.KutyutKeszit();
                    }
                }
            }
            sr.Close();
        }
        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
