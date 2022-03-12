using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(1, 2);
            Console.WriteLine(a);
            Ulamek b = new Ulamek(a);
            Console.WriteLine(b);

            Console.WriteLine();

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }

    }
    public class Ulamek

    {
        private int licznik { get; set; }
        private int mianownik { get; set; }

        public Ulamek()
        {
            this.licznik = 1;
            this.mianownik = 1;
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

        public static Ulamek operator + (Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik + b.licznik * a.mianownik, a.mianownik * b.mianownik);
        }

        public static Ulamek operator - (Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik - b.licznik * a.mianownik, a.mianownik * b.mianownik);
        }

        public static Ulamek operator * (Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.licznik, a.mianownik * b.mianownik);
        }

        public static Ulamek operator / (Ulamek a, Ulamek b)
        {
            return new Ulamek(a.licznik * b.mianownik, a.mianownik * b.licznik);
        }

        public override string ToString()
        {
            return "Licznik = " + licznik + " & mianownik = " + mianownik;
        }

    }
}
