namespace Program
{
    public class Versenyauto : Jarmu
    {
        private int futamido;

        public int Futamido
        {
            get { return futamido; }
            set
            {
                if (value < 0)
                    futamido = 0;
                else if (value > 30)
                    futamido = 30;
                else
                    futamido = value;
            }

        }

        public Versenyauto(string rendszam,int kor, int kilometerOra,int futamido) : base(rendszam, kor, kilometerOra, 60)
        {
            Futamido = futamido;
        }

        public override void Infotad()
        {
            Console.WriteLine(
                $"{Rendszam} - {Kor} eves az elektromos auto, " +
                $"{KilometerOra} km-rel, " +
                $"{futamido} Futam idővel");
        }


        public override void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            futamido += 20;
            Console.WriteLine(
                $"{Rendszam} rendzamu verseny auto  szervize meg valosut");
        }
    }
}
