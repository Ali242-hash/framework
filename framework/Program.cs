using System.Text;

namespace framework
{
    internal class Program
    {
        static List<string> all = new();
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            // ===========================================================
            // 3.7.1.6.1 Bevezetés a szoftverfejlesztésbe
            // ===========================================================
            // Kiinduló szintaxis, kódsorok olvasása, debugolás, utasítások lezárása

            Kolbasz onekolbasz = new(5);
            Console.WriteLine(Kolbasz.text);
            Console.WriteLine(onekolbasz.taste);
            Console.WriteLine(onekolbasz.taste / 2);
            Console.WriteLine((double)onekolbasz.taste);
            Console.WriteLine((int)(1.5));

            string number = "666";

            Console.WriteLine((int)(int.Parse(number) + 1.9));


            // ===========================================================
            // 3.7.1.6.5 Beépített segédosztályok - File olvasás
            // ===========================================================

            FileReader reader = new();
            List<string> alllines = reader.readFile("kolbasz.text");


            // ===========================================================
            // 3.7.1.6.3 Változók
            // ===========================================================
            // Primitívek, string kezelés, type casting

            all.Add(("sajtos es Szalonna").Substring(5, 5));
            Console.WriteLine(all.Last());
            Console.WriteLine(all.Last().IndexOf("S"));
            Console.WriteLine(all.Last().IndexOf("lo"));
            Console.WriteLine(all.Last()[4]);
            Console.WriteLine(all.Last().CompareTo("szalo"));

            string szamszoveg = "123";
            Console.WriteLine(szamszoveg.CompareTo("1200"));

            string datum = "2025.09.01-02:00:00";
            Console.WriteLine("Nagyobb-e mint 2026.01.01: " + datum.CompareTo("2026.01.01"));

            string gyumolcs = "alma";

            gyumolcs += "es korte";
            Console.WriteLine(gyumolcs);

            // ===========================================================
            // 3.7.1.6.5 Beépített segédosztályok - Random, Math, String
            // ===========================================================

            Console.WriteLine(rnd.Next(1));
            Console.WriteLine(rnd.Next(10));
            Console.WriteLine(rnd.Next(10, 21));
            Console.WriteLine(Math.Pow(10, Math.PI));

            int num = int.MinValue;
            Console.WriteLine(num - 1);

            uint num2 = uint.MaxValue;
            Console.WriteLine(num2 - 1);

            Console.WriteLine(string.Join(";"), alllines);

            Console.WriteLine("elso sor" + alllines.IndexOf("k"));
            Console.WriteLine("második sor' a filban: " + alllines.IndexOf("masodik sor"));

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - Boolean, if-then-else
            // ===========================================================

            bool logicValue = false;
            logicValue = !logicValue;
            logicValue = true;

            logicValue = 4 < 9;

            if (gyumolcs.Contains("alma"))
            {
                Console.WriteLine("van benne alma");
            }

            else
            {
                Console.WriteLine("nincs benne alma");
            }

            if (gyumolcs.Length > 14)
            {
                Console.WriteLine("ez tobb gyumolcs");
            }
            else if (gyumolcs.Length >= 4)
                Console.WriteLine("ez valoszinuleg 1 darab gyumolcs");
            else
                Console.WriteLine("ez valosziuleg nincs gyumolcs, tul rovid");


            string gyumolcsvolt = gyumolcs.Contains("alma") ? "van benne alma" : "nincs benne alma";

            string datum2 = DateTime.Now.Hour >= 12 ? "Mar nincs reggel van" : "mar meg reggel van";

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - Switch és pattern matching
            // ===========================================================

            string szoveg = "asd123";

            foreach (char letter in szoveg)
            {
                string betuE = letter switch
                {
                    >= '0' and <= '9' => "az szam",
                    >= 'a' and <= 'z' => "az kisszo",
                    >= 'A' and <= 'Z' => "az nagybetu",
                    'á' or 'é' or 'í' or 'ó' or 'ő' or 'ú' or 'ű' or 'ü' or 'ö' => "az ertekesek",
                    _ => "az nem ertekese"

                };

                Console.WriteLine("A karakter" + letter + " " + betuE);
            }

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - For ciklusok
            // ===========================================================

            for (int i = 1; i < 10; i++) Console.WriteLine(i);
            for (int i = 0; i < 100; i += 2) Console.WriteLine(i);
            for (int i = 0; i < 54; i += 6) Console.WriteLine(i);
            for (int i = 11; i < 33; i += 2) Console.WriteLine(i);

            List<int> szamol100Ig = new(100);

            for (int i = 100; i >= 1; i--)
            {
                szamol100Ig.Add(i);
                Console.WriteLine(i);
            }

            for (int i = 66; i >= 11; i--) Console.WriteLine(i);

            for (int i = 0; i < gyumolcs.Length; i++)
            {
                Console.WriteLine(gyumolcs[i]);
            }

            for (int i = gyumolcs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(gyumolcs[i]);
            }

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - While és Do-While
            // ===========================================================

            bool voltBenneSzo = false;
            int index = 0;

            while (!voltBenneSzo && index < (all.Count - 1))
            {
                voltBenneSzo = true;
                continue;
            }
            index++;

            string kiiaras = voltBenneSzo ? "volt benne szo" : "nem volt benne szo";
            Console.WriteLine(kiiaras);

            // ===========================================================
            // 3.7.1.6.3 Változók - tömbök, mátrixok, listák
            // ===========================================================


            int[] szamok = new int[3];
            szamok[0] = 0;
            szamok[1] = 7;
            szamok[2] = 11;

            List<int> szamokLista = new();
            szamokLista.Add(0);
            szamokLista.Add(7);
            szamokLista.Add(11);

            int[,] matrix;
            //matrix[0, 0] = 0;
            //matrix[1, 0] = 1;
            //matrix[0, 1] = 1;
            //matrix[1, 1] = 0;

            int matrixMerete = 10;

            matrix = new int[matrixMerete, matrixMerete];

            for (int i = 0; i < matrixMerete; i++)
            {
                for (int j = 0; j < matrixMerete; j++)
                {
                    matrix[i, j] = (j % 2 + i % 2) % 2;
                }
            }

            for (int magassag = 0; magassag < matrix.GetLength(1); magassag++)
            {
                for (int szelesseg = 0; szelesseg < matrix.GetLength(0); szelesseg++)
                {
                    Console.Write(matrix[magassag, szelesseg] + " ");
                }
                Console.Write('\n');
            }

            // ===========================================================
            // 3.7.1.6.3 Változók és lambda kifejezések
            // ===========================================================

            int listadarabSzam = szamol100Ig.Count(szam => szam % 2 == 0 && szam % 3 == 0);
            Console.WriteLine("oszthato 2es es 3os : " + listadarabSzam);

            List<int> hatososzthato = szamol100Ig.Where(sz => sz % 6 == 0).ToList();
            hatososzthato.Sort();
            Console.WriteLine(string.Join(' ', hatososzthato));

            List<Kolbasz> kolbaszok = new();

            for (int i = 30; i >= 0; i--)
            {
                kolbaszok.Add(new Kolbasz(i));

            }

            kolbaszok.OrderBy(k => k.taste).ToList();
            Console.WriteLine(string.Join(' ', kolbaszok.Select(k => k.taste)));

            //írjuk ki a 7-el osztható taste-el rendelkező kolbászokat, hogy mennyi a taste, soronként
            //legyenek csökkenő sorrendben

            Console.WriteLine(string.Join(' ', kolbaszok.Where(k => k.taste % 7 == 0).Select(k => k.taste).OrderByDescending(k => k)));

            //Írjuk ki annak a kolbásznak az id-ját aminek az átlag taste-je van, egészre kerekítve

            Console.WriteLine(string.Join(' ', kolbaszok.Average(k => k.taste)));
            Console.WriteLine(kolbaszok[kolbaszok.FindIndex(k => k.taste == (int)kolbaszok.Average(a => a.taste))].taste);
        }

        internal class Kolbasz
        {
            public int taste { get; private set; }
            public static string text = "kolbasz fionm";
            public int taste2 = 0;

            public Kolbasz(int taste = 0)
            {
                this.taste = taste;
            }

        }

        class FileReader
        {
            public List<string> readFile(string filename)
            {
                List<string> lines = new();

                try
                {
                    foreach (string item in File.ReadAllLines(filename, Encoding.UTF8))
                        lines.Add(item);
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return lines;
            }
        }


    }

}