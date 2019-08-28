using System;

namespace Fastfood
{
    class Program
    {
        static void Main(string[] args)
        {
            string valg;
            int antal;
            double totalpris;
            double rabat;
            double fratrukket;

            
                Console.Clear();
                Console.WriteLine("M E N U");
                Console.WriteLine("Ønskes der en lille menu, tastes der: L");
                Console.WriteLine("Ønskes der en mellem menu, tastes der: M");
                Console.WriteLine("Ønskes der en stor menu, tastes der: S");
                Console.WriteLine("Ønskes du at afslutte, tastes der: A");

            valg = Console.ReadLine();

                switch (valg.ToLower())
                {
                    case "l":
                        
                        Console.Clear();
                        Console.WriteLine("Du har valgt at købe menuen lille, hvor mange ønskes der?");

                        antal = Convert.ToInt16(Console.ReadLine());

                        if(antal > 10)
                    {
                        rabat = antal * 0.10;
                        totalpris = 35 * antal;
                        fratrukket = totalpris - rabat;
                        
                        Console.WriteLine("Totalprisen {0:N2} kr og du har sparet {1:N2} kr, det du skal betale er {2} kr", totalpris, rabat, fratrukket);

                    } else
                    {
                        totalpris = 35 * antal;

                        Console.WriteLine("Din pris er {0} kr", totalpris);
                    }



                        break;


                    case "m":

                    Console.Clear();
                    Console.WriteLine("Du har valgt at købe menuen mellem, hvor mange ønskes der?");

                    antal = Convert.ToInt16(Console.ReadLine());

                    if (antal > 10)
                    {
                        rabat = antal * 0.10;
                        totalpris = 35 * antal;
                        fratrukket = totalpris - rabat;

                        Console.WriteLine("Totalprisen {0:N2} kr og du har sparet {1:N2} kr, det du skal betale er {2} kr", totalpris, rabat, fratrukket);

                    }
                    else
                    {
                        totalpris = 45 * antal;

                        Console.WriteLine("Din pris er {0} kr", totalpris);
                    }

                    break;

                    case "s":

                    Console.Clear();
                    Console.WriteLine("Du har valgt at købe menuen mellem, hvor mange ønskes der?");

                    antal = Convert.ToInt16(Console.ReadLine());

                    if (antal > 10)
                    {
                        rabat = antal * 0.10;
                        totalpris = 35 * antal;
                        fratrukket = totalpris - rabat;

                        Console.WriteLine("Totalprisen {0:N2} kr og du har sparet {1:N2} kr, det du skal betale er {2} kr", totalpris, rabat, fratrukket);

                    }
                    else
                    {
                        totalpris = 65 * antal;

                        Console.WriteLine("Din pris er {0} kr", totalpris);
                    }


                    break;

                    case "a":

                        Console.WriteLine("Du har nu afsluttet dit køb");


                        break;
                }





            
        }
    }
}
