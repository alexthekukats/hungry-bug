using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace éhes_bogár
{
    class Program
    {
        static int probasz = 100000000;
        static Random ran = new Random();
        static int[] alma = new int[probasz];
        static int sz = 0;
        static int i;
        static void Main()
        {
            for (i = 0; i < probasz; i++)
            {
                A();
                Console.WriteLine("Átlag: " + avg(alma));
                //Console.ReadKey();
            }
            Console.WriteLine(alma.Average());
            Console.ReadKey();
        }

        static void A()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; B();
                    break;
                case 1: sz++; D();
                    break;
                case 2: sz++; E();
                    break;
            }
        }

        static void B()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; A();
                    break;
                case 1: sz++; G();
                    break;
                case 2: sz++; C();
                    break;
            }
        }

        static void C()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; B();
                    break;
                case 1: sz++; D();
                    break;
                case 2: sz++; H();
                    break;
            }
        }

        static void D()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; A();
                    break;
                case 1: sz++; C();
                    break;
                case 2: sz++; F();
                    break;
            }
        }

        static void E()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; A();
                    break;
                case 1: sz++; F();
                    break;
                case 2: sz++; G();
                    break;
            }
        }
        
        static void F()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; H();
                    break;
                case 1: sz++; D();
                    break;
                case 2: sz++; E();
                    break;
            }
        }

        static void G()
        {
            switch (ran.Next(0, 3))
            {
                case 0: sz++; B();
                    break;
                case 1: sz++; H();
                    break;
                case 2: sz++; E();
                    break;
            }
        }

        static void H()
        {
            alma[i] = sz;
            Console.WriteLine("Megtett lépés: " + sz);
            sz = 0;
        }

        static double avg(int[] asd)
        {
            double szum = 0;
            for (int q = 0; q <= i; q++)
            {
                 szum += alma[q];
            }
            szum = szum / (i + 1);
            return szum;
        }
    }
}
