using System.Text;
using System.Threading.Channels;

namespace framework
{
    class Program
    {
        static List<string> all = new();
        static Random rnd = new();
        static void Main(string[] args)
        {
            // ===========================================================
            // 3.7.1.6.1 Bevezetés a szoftverfejlesztésbe
            // ===========================================================
            // Kiinduló szintaxis, kódsorok olvasása, debugolás, utasítások lezárása

            Kolbasz onekolbasz = new(5);
            Console.WriteLine(Kolbasz.text);
            Console.WriteLine(onekolbasz.taste);
            Console.WriteLine(onekolbasz.taste/2);
            Console.WriteLine((double)onekolbasz.taste/2);
            Console.WriteLine((int)(1.5));

            string number = "666";

            Console.WriteLine((int)(int.Parse(number)+1.9));

            // ===========================================================
            // 3.7.1.6.5 Beépített segédosztályok - File olvasás
            // ===========================================================

            FileReader reader = new();

            List<string> alllines = reader.readFile("kolbasz.text");

            // ===========================================================
            // 3.7.1.6.3 Változók
            // ===========================================================
            // Primitívek, string kezelés, type casting

            all.Add(("sajtos es szallona").Substring(5,5));
            Console.WriteLine(all.Last());
            Console.WriteLine(all.Last().IndexOf("sz"));
            Console.WriteLine(all.Last().IndexOf("llo"));
            Console.WriteLine(all.Last()[4]);
            Console.WriteLine(all.Last().CompareTo("lo"));

            string szoveg = "123";

            Console.WriteLine(szoveg.CompareTo("1200"));

            string datum = "2025:09:01-02:00:00";

            Console.WriteLine("Nagyob mint 2026:01:06" + datum.CompareTo("2026:01:06"));

            string gyumolcs = " Alma ";
            gyumolcs += " es korte ";
            Console.WriteLine(gyumolcs);

            // ===========================================================
            // 3.7.1.6.5 Beépített segédosztályok - Random, Math, String
            // ===========================================================

            Console.WriteLine(rnd.Next(1));
            Console.WriteLine(rnd.Next(1,10));
            Console.WriteLine(rnd.Next(11,33));
            Console.WriteLine(Math.Pow(10,Math.PI));

            int num = int.MinValue;
            Console.WriteLine(num-1);

            uint num2 = uint.MaxValue;
            Console.WriteLine(num2-1);

            Console.WriteLine(string.Join(' ', alllines));
            Console.WriteLine("a betu elso sor" + alllines.First().IndexOf("a"));
            Console.WriteLine("Masodik sor" + alllines.IndexOf("Masodik sor"));

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - Boolean, if-then-else
            // ===========================================================

            bool logicValue = false;
            logicValue = !logicValue;
            logicValue = true;
            logicValue = 4 < 9;

            if(gyumolcs.Contains("alma"))
                Console.WriteLine("van benne alma");
            else
                Console.WriteLine("nincs benne alma");

            if(gyumolcs.Length >=14)
                Console.WriteLine("tobb gyumolcs van");
            else if(gyumolcs.Length >=3)
                Console.WriteLine("valoszinuleg egy darab gyumolcs benne van");
            else
                Console.WriteLine("nincs benne gyumolcs");

            string gyumolcsvolt = gyumolcs.Contains("alma") ? "van benne alma" : "nincs benne alma";

            string datum2 = DateTime.Now.Hour >= 12 ? "Mar nem reggel van" : "Mar reggel van";

            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - Switch és pattern matching
            // ===========================================================

            string szovegszam = "asd123";

            foreach(char letter in szovegszam)
            {
                string betuE = letter switch
                {
                    >='0'and<='9'=>"az szam",
                    >='a'and<='z'=>"az kis szo",
                    >='A'and <='Z'=>"az nagy betu",
                    'á' or 'é' or 'í' or 'ó' or 'ő' or 'ú' or 'ű' or 'ü' or 'ö'=>"Ez ertekese",_=>"nem ertekese"
                };

                Console.WriteLine("ő Karakter", letter + " " + betuE );
            }


            // ===========================================================
            // 3.7.1.6.6 Vezérlési szerkezetek, ciklusok - For ciklusok
            // ===========================================================

            for(int i = 0;i<10;i++)
                Console.WriteLine(i);
            for(int i = 1;i<100;i+=2)
                Console.Write(i);
            for(int i = 2;i<54;i+=6)
                Console.Write(i);
            for(int i = 30; i>=1;i--)
                Console.Write(i);

            List<int> szamol100ig = new(100);
            for(int i = 100; i >= 0; i--)
            {
                szamol100ig.Add(i);
                Console.WriteLine(i);
            }

            for(int i =66;i>=11;i--)
                Console.WriteLine(i);

            for(int i =0; i<gyumolcs.Length;i++)
            for(int i2 = gyumolcs.Length-1;i2>=0;i2--)
                Console.WriteLine(gyumolcs[i2]);

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

            do
            {
                Console.WriteLine("jaj de jó, végtelen ciklus");
            } while(voltBenneSzo);

            // ===========================================================
            // 3.7.1.6.3 Változók - tömbök, mátrixok, listák
            // ===========================================================

            int[] szamok = new int[3];
            szamok[0]= 0;
            szamok[1] = 8;
            szamok[2] = 9;

            List<int> szamlista = new();
            szamlista.Add(0);
            szamlista.Add(1);
            szamlista.Add(2);

            int[,] matrix;

            int matrixMerete = 10;

            matrix = new int[matrixMerete,matrixMerete];

            for(int i = 0; i < matrixMerete; i++)
            {
                for(int j = 0; j < matrixMerete; j++)
                {
                    matrix[i, j] = (j % 2 + i % 2) % 2;
                }
            }

            for(int magassag = 0; magassag < matrix.GetLength(1); magassag++)
            {
                for(int szelesseg = 0;szelesseg < matrix.GetLength(0); szelesseg++)
                {
                    Console.Write(matrix[magassag,szelesseg] + " ");
                }
                Console.WriteLine("\n");
            }

            // ===========================================================
            // 3.7.1.6.3 Változók és lambda kifejezések
            // ==========================================================

            int listaszam = szamol100ig.Count(sz=>sz % 2 == 0 && sz % 3 ==0);
            Console.WriteLine($"2es es 3os oszthato {listaszam}");

            List<int> hatososzthato = szamol100ig.Where(hot=>hot % 6 == 0).ToList();
            hatososzthato.Sort();
            Console.WriteLine(string.Join(' ', hatososzthato));

            List<Kolbasz> kolbaszok = new();

            for(int i = 30; i >= 11; i--)
            {
                kolbaszok.Add(new Kolbasz(i));
            }

            Console.WriteLine(string.Join(' ',kolbaszok.Select(k=>k.taste)));

            //írjuk ki a 7-el osztható taste-el rendelkező kolbászokat, hogy mennyi a taste, soronként
            //legyenek csökkenő sorrendben

            Console.WriteLine(string.Join(' ',kolbaszok.Where(k=>k.taste % 7 ==0).Select(k=>k.taste).OrderByDescending(k=>k)));

            //Írjuk ki annak a kolbásznak az id-ját aminek az átlag taste-je van, egészre kerekítve

            Console.WriteLine(string.Join(' ',kolbaszok.Average(k=>k.taste)));
            Console.WriteLine(kolbaszok[kolbaszok.FindIndex(k => k.taste == (int)kolbaszok.Average(a => a.taste))].taste);

            //minden változónak van default értéke

            int szam = default;
            bool logicvalue2 = default;
            string szam2 = default;

            if (szam2 == null)
                Console.WriteLine(szam2);

            char oneChar = default;

            if(oneChar==char.MinValue)
                Console.WriteLine(oneChar);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            List<Ivehichle> cars = new();

            cars.Add(new Car("Honda") { year = 1992, power = 85,topspeed = 190 });
            cars.Add(new Car("Trabant") {year=1990,power=35,topspeed=135,model="1.1" });

            Console.WriteLine((cars.Last()as Car).topspeed);
            Console.WriteLine((cars.First()as Car).year);
            Console.WriteLine((cars.First()as Car).make);
            Console.WriteLine((cars.Last()as Car).model);

            if (cars[0].CompareTo(cars[1])>0)
            {
                Console.WriteLine("Honda erosebb");
            }

            else if (cars[0].CompareTo(cars[1]) == 0)
            {
                Console.WriteLine("Ket kocsi egyenlu");
            }

            else
                Console.WriteLine("Trabant erosebb");


            cars.Sort();
            Console.WriteLine(string.Join(' ',cars.Select(car=>car.power)));

            cars.Add(new Motorcycle() { power = 150, year = 2020,topspeed=280 });

            Console.WriteLine(string.Join(' ',cars.Select(car=>car.power)));

            int motorcyclecount = cars.Count(car=>car is Motorcycle);
            Console.WriteLine($"M count {motorcyclecount}");

            int carcount = cars.Count(car=>car is Car);
            Console.WriteLine($"Car count {carcount}");

            IEnumerable<Ivehichle> over150 = cars.Where(car => car.topspeed > 150);
            Console.WriteLine(string.Join(' ', over150.Select(car => car.topspeed)));





        }

   
        internal interface Ivehichle : IComparable<Ivehichle>
        {
            public int power { get; set; }
            public int year { get; set; }
            public int topspeed { get; set; }

            public double Move(int distance);
        }

        internal class Motorcycle : Ivehichle
        {
            public int power { get; set; }
            public int year { get; set; }

            public int topspeed { get; set; }

            public int CompareTo(Ivehichle? obj)
            {
                return power - obj.power;
            }

            public double Move(int distance)
            {
                return (double)distance / topspeed * 1.1;
            }
        }

        internal class Car : Ivehichle
        {
            public int power { get; set; }
            public string make { get;private set; }

            private int _year;
            public int year
            {
                get
                {
                    return _year;
                }

                set
                {
                    if (value <= DateTime.UtcNow.Year && value > 1896)
                    {
                        _year = value;
                    }
                    else
                        throw new Exception("Hibas evjarat");
                }
            }

            public Car(string make = "")
            {
                this.make = make;
            }
            public int topspeed { get ; set ; }

            public string _model = "";
            
            public string model
            {
                get
                {
                    if (_model.Length < 2)
                    {
                        return "igyen model nem ervengyes";
                    }
                    return _model;
                }

                set
                {
                    _model = value;
                }

            }

            public double Move(int distance)
            {
                return (double) distance / topspeed;
            }

            public int CompareTo(Ivehichle? other)
            {
               return power - other.power;
            }
        }

    

        class FileReader
        {
            public List<string>readFile(string filename)
            {
                List<string> lines = new();

                try
                {
                    foreach(string item in File.ReadAllLines(filename,Encoding.UTF8))
                    {
                        lines.Add(item);
                    }
                }

                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return lines;
            }
        }

        internal class Kolbasz
        {
           public static string text = "Kolbasz finom";
            public int taste { get; set; }

            public int taste2 = 0;

            public Kolbasz(int taste =0)
            {
                this.taste = taste;
            }

        }
    }
}