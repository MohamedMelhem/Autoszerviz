using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
        private int akkumulatorSzint;
        // extra adattag hozzadas + ell.
        public int AkkumulatorSzint
        {
            get { return akkumulatorSzint; }
            set
            {
                if (value < 0)
                    akkumulatorSzint = 0;
                else if (value > 100)
                    akkumulatorSzint = 100;
                else
                    akkumulatorSzint = value;
            }
        }
        //konstuktor
        public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint) : base(rendszam, kor, kilometerOra, 0)
        {
            AkkumulatorSzint = akkumulatorSzint;
        }
        //kiirás info adas
        public override void Infotad()
        {
            Console.WriteLine(
                $"{Rendszam} - {Kor} eves az elektromos auto, " +
                $"{KilometerOra} km-rel, " +
                $"{akkumulatorSzint} % töltöttséggel.");
        }
        //szervizeles
        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }

            AkkumulatorSzint += 20;

            Console.WriteLine(
                $"{Rendszam} rendzamu elektromos auto  szervize meg valosut");
        }

    }
}
