using Program;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Program
{


    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;

        public string Rendszam
        {
            get { return rendszam; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    rendszam = "Ismertlen";
                else
                    rendszam = value;
            }
        }
        //kor ellenorzese
        public int Kor
        {
            get { return kor; }
            set
            {
                if (value < 0)
                    kor = 0;
                else if (value > 50)
                    kor = 50;
                else
                    kor = value;
            }
        }
        //kilometer ell.
        public int KilometerOra
        {
            get { return kilometerOra; }
            set
            {
                if (value < 0)
                    kilometerOra = 0;
                else
                    kilometerOra = value;
            }
        }
        //uzemanyag ell.
        public int UzemanyagSzint
        {
            get { return uzemanyagSzint; }
            set
            {
                if (value < 0)
                    uzemanyagSzint = 0;
                else if (value > 100)
                    uzemanyagSzint = 100;
                else
                    uzemanyagSzint = value;
            }
        }
        //szerviz szukseges-e ell.
        public bool Szervizszukseges
        {
            get { return KilometerOra >= 200000; }
        }

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }
        //kiiras
        public void Infotad()
        {
            Console.WriteLine($"{Rendszam}, {Kor} eves a jarmu, {KilometerOra} km-vel.");
        }

        public void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            UzemanyagSzint -= 10;

            Console.WriteLine($"A {Rendszam} Rendszámu auto szerivzelve lett");
        }
    }





}
