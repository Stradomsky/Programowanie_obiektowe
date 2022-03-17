using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek[] ulamki = new Ulamek[]
            {
                new Ulamek(4, 5),
                new Ulamek(1, 2),
                new Ulamek(3, 4),
                new Ulamek(2, 3),
                new Ulamek(5, 6),
                new Ulamek(3, 4)
            };

            /*
            Ulamek a = new Ulamek(1, 2);
            Console.WriteLine(a);
            Ulamek b = new Ulamek(a);
            Console.WriteLine(b);

            Console.WriteLine();

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            */

            Console.WriteLine("Nieposortowane: ");
            for (int i = 0; i < ulamki.Length; i++)
            {
                Console.WriteLine(ulamki[i]);
            }

            Array.Sort(ulamki);

            Console.WriteLine("Posortowane: ");
            for (int i = 0; i < ulamki.Length; i++)
            {
                Console.WriteLine(ulamki[i]);
            }

        }

    }
    public class Ulamek: IComparable<Ulamek>

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

        public int CompareTo(Ulamek other)
        {
            int a = this.licznik * other.mianownik,
                b = other.licznik * this.mianownik;

            if (other == null || a < b) return -1;
            else if (a > b) return 1;
            else return 0;

        }

        public bool Equals(Ulamek other)
        {
            if (other == null) return false;
            else if (other == this) return true;
            return Object.Equals(this.licznik, other.licznik) && Object.Equals(this.mianownik, other.mianownik);
        }

        public override string ToString()
        {
            return "Licznik = " + licznik + " & mianownik = " + mianownik;
        }

    }
}
