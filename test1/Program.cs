using System;

namespace test1
{
    class Program
    {
        class Obwod
        {
            public int _bok1;
            public int _bok2;

            public Obwod(int bok1, int bok2)
            {
                _bok1 = bok1;
                _bok2 = bok2;
            }

            public static Obwod operator &(Obwod ob1, Obwod ob2)
            {
                return new Obwod(ob1._bok1 & ob2._bok1, ob1._bok2 & ob2._bok2);
            }

            public static Obwod operator |(Obwod ob1, Obwod ob2)
            {
                return new Obwod(ob1._bok1 | ob2._bok1, ob1._bok2 | ob2._bok2);
            }

            public static bool operator true(Obwod ob1)
            {
                return ob1._bok1 != 0;
            }

            public static bool operator false(Obwod ob1)
            {
                return ob1._bok1 == 0;
            }

        }

        class Wyświetl
        {
            public static void Main()
            {
                Obwod fig1 = new Obwod(3, 4);
                Obwod fig2 = new Obwod(4, 5);
                Obwod fig3 = new Obwod(5, 6);

                if (fig1 && fig2)
                    Console.WriteLine("Długości boków różne od zera");

                if (fig1 || fig3)
                    Console.WriteLine("Długości boków fig1 lub fig2 różne od zera");
            }
        }
    }
}
