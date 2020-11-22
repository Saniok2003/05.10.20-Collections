using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace IDZ13
{
    class KolodaKart
    {
        public Karta[] Koloda = new Karta[37];
        public KolodaKart()
        {
            for (int i = 1; i <= 4; i++)
                for (int j = 6; j <= 14; j++)
                    Koloda[(i - 1) * 9 + (j - 5)] = new Karta(i, j);
        }
        public void Sort()
        {
            int zapom0, zapom1, zapom2, zapom3, isp, isp1, isp2, isp3;
            int i = 1;
            for (int z = 0; z < 3; z++)
            {

                for (; i < 36;)
                {
                    zapom0 = Koloda[i].Mastb;
                    zapom1 = Koloda[i].Num;
                    i++;
                    zapom2 = Koloda[i].Mastb;
                    zapom3 = Koloda[i].Num;
                    i++;
                    isp = Koloda[i].Mastb;
                    isp1 = Koloda[i].Num;
                    i++;
                    isp2 = Koloda[i].Mastb;
                    isp3 = Koloda[i].Num;

                    if (i % 5 == 0) //i =5 
                    {
                        Koloda[i].Mastb = zapom0;
                        Koloda[i].Num = zapom1;
                        i--;
                        Koloda[i].Mastb = zapom2;
                        Koloda[i].Num = zapom3;
                        i--;
                        Koloda[i].Mastb = isp;
                        Koloda[i].Num = isp1;
                        i--;
                        Koloda[i].Mastb = isp2;
                        Koloda[i].Num = isp3;
                        i += 5;
                    }

                }
            }
        }
        public string OutKarta(int id)
        {
            string answer;
            switch (Koloda[id].Num)
            {
                case 11:
                    answer = "Валет";
                    break;
                case 12:
                    answer = "Дама";
                    break;
                case 13:
                    answer = "Король";
                    break;
                case 14:
                    answer = "Туз";
                    break;
                default:
                    answer = Koloda[id].Num.ToString();
                    break;
            }
            switch (Koloda[id].Mastb)
            {
                case 1:
                    answer += " червей";
                    break;
                case 2:
                    answer += " бубей";
                    break;
                case 3:
                    answer += " крестей";
                    break;
                case 4:
                    answer += " пик";
                    break;
            }
            return answer;
        }
    }
    class Karta
    {
        
        public int Mastb;
        public int Num;
        public Karta(int i, int j)
        {
            this.Mastb = i;
            this.Num = j;
        }
    }
    class Programm
    {
        public static void Main()
        {
            int num;
            KolodaKart ad = new KolodaKart();
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ad.OutKarta(num));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            ad.Sort();

            for (int i = 1; i <= 36; i++)
            {
                Console.WriteLine(ad.OutKarta(i));
            }
            Console.ReadKey();
        }
    }
}