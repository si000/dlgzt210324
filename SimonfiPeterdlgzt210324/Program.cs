using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonfiPeterdlgzt210324
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            dolgozat();

            Console.ReadKey();
        }

        private static void dolgozat()
        {
            // Hozzon létre egy 100 elemű tömböt!

            int[] tomb = new int[100];

            // Töltse fel 5 - el osztható, 4 számjegyű véletlenszámokkal!

            Console.WriteLine(" - Töltse fel 5-el osztható, 4 számjegyű véletlenszámokkal!");

            int index = 0;
            while (index < 100)
            {
                int x = r.Next(1000, 10000);
                if (x % 5 == 0)
                {
                    tomb[index] = x;
                    index++;
                }
            }

            // Írja ki a tömb elemeit úgy, hogy kiírásnál egy sorban pontosan 10 elem szerepeljen!

            Console.WriteLine(" - Írja ki a tömb elemeit úgy, hogy kiírásnál egy sorban pontosan 10 elem szerepeljen!");

            // Kiírásnál minden 7. elem színe legyen világoszöld!

            Console.WriteLine(" - Kiírásnál minden 7. elem színe legyen világoszöld!\n");

            for (int i = 0; i < tomb.Length; i++)
            {

                if ((i + 1) % 10 != 0)
                {

                    if ((i + 1) % 7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($" \t{tomb[i]}  ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.Write($" \t{tomb[i]}  ");

                    }
                }

                else
                {
                    if ((i + 1) % 7 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" \t{tomb[i]}  ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.WriteLine($" \t{tomb[i]}  ");

                    }




                }
            }
            // Határozza meg a tömb elemeinek összegét!

            Console.WriteLine(" \n- Határozza meg a tömb elemeinek összegét!\n");

            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine($"\tA tömb elemeinek összege: {osszeg}");

            // Határozza a 4000-nél nem kisebb, de 5000-nél kisebb elemek átlagát!

            Console.WriteLine("\n - Határozza a 4000-nél nem kisebb, de 5000-nél kisebb elemek átlagát!");

            int mennyi = 0;
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] >= 4000 && tomb[i] < 5000)
                {
                    mennyi += tomb[i];
                    db++;
                }
            }
            int atlag = mennyi / db;

            Console.WriteLine($"\n\tA meghatározott feltételnek {db} elem felel meg, az átlaguk: {atlag}");

            /* Határozza meg, hogy szerepel-e a tömbben 65 valamelyik többszöröse! ha igen,
            írjuk ki az első ilyen számot és az indexét is!*/

            Console.WriteLine("\n - Határozza meg, hogy szerepel-e a tömbben 65 valamelyik többszöröse! ha igen,\n   írjuk ki az első ilyen számot és az indexét is !");

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 65 == 0)
                {
                    Console.WriteLine($"\n\tA feltételnek megfelelő elem a {i} -ik, az összege {tomb[i]} ");
                    break;
                }
            }

            // Határozza meg, hány db 3-as számmal kezdődő szám van a tömbben!

            Console.WriteLine("\n - Határozza meg, hány db 3-as számmal kezdődő szám van a tömbben!");

            int hanydb = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] / 1000 == 3)
                {
                    hanydb++;
                }
            }
            Console.WriteLine($"\n\t3-as számmal kezdödő elem {hanydb} db van ");

            /* Írja ki a tömbnek az első olyan elemének indexét, amelyet elfogadható
            forintban értelmezett órabérnek gondol egy junior szoftverfejlesztő számára!*/

            Console.WriteLine("\n - Írja ki a tömbnek az első olyan elemének indexét, amelyet elfogadható forintban\n   értelmezett órabérnek gondol egy junior szoftverfejlesztő számára!");

            int ber = 0;
            int max_i = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > ber)
                {
                    ber = tomb[i];
                    max_i = i;   
                }               
            }
            Console.WriteLine($"\n\tAz elfogatható összeg a {max_i} indexü elem :)");

            // Válogassa ki a kerek 100-asokat a tömbből egy másik tömbbe!

            Console.WriteLine("\n - Válogassa ki a kerek 100-asokat a tömbből egy másik tömbbe!");

            int[] tomb2 = new int[100];

            /* írja ki ennek a tömbnek a tartalmát is, de úgy, hogy minden szám, aminek az
            ezres és a százas helyiértéken azonos szám szerepel, a mögött legyen piros a háttér!*/

            Console.WriteLine(" - írja ki ennek a tömbnek a tartalmát is, de úgy, hogy minden szám, aminek az ezres és a százas\n   helyiértéken azonos szám szerepel, a mögött legyen piros a háttér!\n");
            int j = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 100 == 0)
                {
                    tomb2[j] = tomb[i];
                    j++;                   
                }
            }
         
            int i_index = 90;
            int g_index = 90;
            for (int i = 0; i < tomb2.Length; i++)
            {
                if (tomb2[i] > 0)
                {
                    for (int g = i + 1; g < tomb2.Length; g++)
                    {
                        if (tomb2[i] / 100 == tomb2[g] / 100 )
                        {
                            i_index = i;
                            g_index = g;                           
                        }  
                    }
                }
            }
            
            for (int i = 0; i < tomb2.Length; i++)
            {
                if (tomb2[i] > 0)
                {
                    if (tomb2[i] == tomb2[i_index] || tomb2[i] == tomb2[g_index])
                    {
                        Console.Write("\t");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{tomb2[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                        Console.Write($"{tomb2[i]}");
                    }

                }
            }
            /* Kerekítse a születési évedet a magyar forint kerekítési szabályainak
             megfelelően „5 - el osztható” számmá! Határozza meg, hogy szerepel - e ez a
             szám a tömbben!*/

            Console.WriteLine("\n\n - Kerekítse a születési évedet a magyar forint kerekítési szabályainak megfelelően „5 - el osztható” számmá!\n   Határozza meg, hogy szerepel - e ez a szám a tömbben!");
            int evszam = 0;
            int szulev = 1965;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == szulev)
                {
                    evszam++;
                }
            }
            if (evszam > 0)
            {
                Console.WriteLine($"" +
                    $"\n\t1965 {evszam} * szerepel a tömbben.");
            }
            else
            {
                Console.WriteLine("\n\t1965 nem szerepel a tömbben.");
            }
        }
    }
}
