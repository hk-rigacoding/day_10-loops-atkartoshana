using System;

namespace day_10_loops_atkartoshana
{

    public class Cik
    {


        public int[][] MassivuSaliksana(int[] array1, int[] array2)
        {
            int[][] kombinedJaggedArray = new int[2][];//[0] un [1]
            
            kombinedJaggedArray[0] = new int[array1.Length];
            kombinedJaggedArray[1] = new int[array2.Length];

            //pirmais [x x x x] (4)
            //otrais  [x x ? ?] (2)


            //ja pirmais ir garāks par otro, tad es iterēšu mazāko
            if (array1.Length > array2.Length)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = (array2[i] > array1[i]) ? array2[i] : array1[i];

                    //Console.WriteLine(array1[i] + " " + array2[i]);
                }
            }
            else if (array1.Length < array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = (array1[i] > array2[i]) ? array1[i] : array2[i];
                }
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = (array1[i] > array2[i]) ? array1[i] : array2[i];
                }
            }
            kombinedJaggedArray[0] = array1;
            kombinedJaggedArray[1] = array2;
            return kombinedJaggedArray;
        }


        public int Arr(int num1, int num2)
        //public int Arr(ref int[] num1, ref int[] num2)
        {
            int[] masivs1 = new int[num1];
            int[] masivs2 = new int[num2];
            


            //salīdzināt visu triju masīvu vērtības - 
            //!!! (vai katru ar katru ?) ... /*un noteikt lielāko, mazāko*/
            //vai tikai atbilstošos indeksus ? pirmo ar pirmo, otro ar otro utml m1[i] == m2[i]



            /*
            for()
            {
                for()
                {
                }
            }
            */



            //masīvs[10 - 20] ???
            Random r = new Random();
            //pieņemot, ka abu masīvu garumi ir vienādi !
            /*
            for (int i = 0; i < masivs1.Length; i++)
            {
                int sk1 = r.Next(1, 1000);
                masivs1[i] = sk1;

                sk1 = r.Next(1, 1000);
                masivs2[i] = sk1;
            }
            */

            //metodē `main`
            //vienu int tipa masīvu, 10 elementus garu
            //ar randomu aizpildiet to

            //jūsu metode
            //uztaisiet to kā metodi, kas saņem kā parametru int[] masīvu un atgriež lielāko skaitli masīvā

            //izvadiet visus elementus - masīva saturu
            //izvadiet uz ekrāna lielāko skaitli šajā masīvā

            //1. variants : ar if () pārbaudam vai nākamais ir lielāks par tekošo


            /*
            for (int i = 0; i < masivs1.Length; i++)
            {
                int sk1 = r.Next(1, 1000);
                masivs1[i] = sk1;

                sk1 = r.Next(1, 1000);
                masivs2[i] = sk1;
            }
            */

            //pielieciet otru masīvu klāt
            //metode saņem 2 masīvus, kas atrod lielāko elementa vērtību, nosakiet lielāko 
            // 1. katram masīvam lielāko
            // 2. lielo no abiem masīviem - kurš lielāks, masīva1 lielākais vai masīva2 lielākais




            masivs1 = new int[20];
            int hVal = 0;

            //pieņemot, ka abu masīvu garumi ir vienādi !
            for (int i = 0; i < masivs1.Length; i++)
            {
                int sk1 = r.Next(1, 1000);
                masivs1[i] = sk1;
                Console.Write("{0} ", masivs1[i]);

                //sk1 = r.Next(1, 1000);
                //masivs2[i] = sk1;
                if (sk1 > hVal)
                {
                    hVal = sk1;
                }
            }

            Console.WriteLine("\nLielakais skaitlis: {0}", hVal);

            Console.ReadKey();







            for (int i = 0; i < masivs1.Length; i++)
            {
                if (masivs1[i] > masivs2[i])
                {
                    masivs2[i] = masivs1[i];
                    //Console.WriteLine("{0} {1}", sk1, sk2);
                }
                else if (masivs1[i] < masivs2[i])
                {
                    masivs1[i] = masivs2[i];
                    //Console.WriteLine("{0} {1}", sk1, sk2);
                }

            }
            //return Arr(num1, num2);


            return 1;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Cik c = new Cik();
            c.Arr(20,20);

            Console.WriteLine("Hello World!");
        }
    }
}
