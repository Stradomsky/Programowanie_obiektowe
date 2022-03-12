using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek nowyulamek = new Ulamek(1, 2);
            Console.WriteLine(nowyulamek);
            
        }

    }
    public class Ulamek

    {
        private int licznik { get; set; }
        private int mianownik { get; set; }

        public Ulamek()
        {

        }


        public Ulamek(int licznik1, int mianownik1)
        {
            licznik = licznik1;
            mianownik = mianownik1;
        }
        public Ulamek(Ulamek prev)
        {
            licznik = prev.licznik;
            mianownik = prev.mianownik;
        }

        public override string ToString()
        {
            return "Licznik = " + licznik + " & mianownik = " + mianownik;
        }

    }
}
