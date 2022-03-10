using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public class Ulamek

    {
        private int licznik, mianownik;

        public Ulamek() { }
        

        public  Ulamek(int licznik1, int licznik2)
        {
            licznik = licznik1;
            mianownik = licznik2;
        }
        public  Ulamek(Ulamek prev)
        {
            licznik = prev.licznik;
            mianownik = prev.mianownik;
        }
    }
}
