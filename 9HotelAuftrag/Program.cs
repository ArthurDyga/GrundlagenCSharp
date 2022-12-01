uint Aufenthaltsdauer = 0;
uint anzahl_der_personen = 0;
uint saison = 1;
double saisonpreis = 1;
uint Zimmerkategorie = 0;
uint Kundenkategorie = 0;
uint Anzahl_der_Kinder = 0;
double Kinderpreis = 0;
int B = 0;
double Zimmerpreis = 0;
double Kundenrabatt = 0;
double Endpreis = 0;
double ERGEB_NIS = 0;
Console.OutputEncoding = System.Text.Encoding.Unicode;
string Hotel_Rechner1 = "============================================================", Hotel_Rechner2 = "                    Hotel rechner", Hotel_Rechner3 = "============================================================";

// 1
bool Erste_Abfrage = true;
while (Erste_Abfrage == true)
{
    try
    {
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Geben sie die Aufenthaltsdauer an (in tage):");
        Aufenthaltsdauer = Convert.ToUInt16(Console.ReadLine());
        Erste_Abfrage = false;
        Console.Clear();
    }
    catch (Exception)
    {
        
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Erste_Abfrage = true;
        Console.Clear();
    }
}

// 2
bool Zweite_Abfrage = true;
while (Zweite_Abfrage == true)
{
    try
    {
        Zweite_Abfrage = false;
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Geben sie die Anzahl der personen an:");
        anzahl_der_personen = Convert.ToUInt16(Console.ReadLine());
        Console.Clear();
    }
    catch (Exception)
    {

        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Zweite_Abfrage = true;
        Console.Clear();
    }
}

bool Dritte_Abfrage = true;
while (Dritte_Abfrage == true)
{   
    try
    {
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Geben sie die saison an:");
        Console.WriteLine("Frühling (+0 %) = 1");
        Console.WriteLine("Sommer   (+15%) = 2");
        Console.WriteLine("Herbst   (+0 %) = 3");
        Console.WriteLine("Winter   (-15%) = 4");
        saison = Convert.ToUInt16(Console.ReadLine());
        Console.Clear();
        switch (saison)
        {
            case 1:
                saisonpreis = 1;
                Dritte_Abfrage = false;
                break;
            case 2:
                saisonpreis = 1.15;
                Dritte_Abfrage = false;
                break;
            case 3:
                saisonpreis = 1;
                Dritte_Abfrage = false;
                break;
            case 4:
                saisonpreis = 0.85;
                Dritte_Abfrage = false;
                break;
            case > 4:
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Console.WriteLine();
                Console.WriteLine("Falsche Eingabe bitte geben sie eine zahl von 1 bis 4 an.");
                Console.WriteLine("App wird neu gestartet.");
                Console.WriteLine();
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Thread.Sleep(7000);
                Console.Clear();
                break;
        }
    }
    catch (Exception)
    {

        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Erste_Abfrage = true;
        Console.Clear();
    }
}

bool Vierte_Abfrage = true;
while (Vierte_Abfrage == true)
{
    try
    {
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Geben sie die Zimmerkategorie an:");
        Console.WriteLine("Standard (70€ pro Nacht) = 1");
        Console.WriteLine("Komfort (100€ pro Nacht) = 2");
        Console.WriteLine("Suit    (250€ pro Nacht) = 3");
        Zimmerkategorie = Convert.ToUInt16(Console.ReadLine());
        Console.Clear();
        switch (Zimmerkategorie)
        {
            case 1:
                Zimmerpreis = 70;
                Vierte_Abfrage = false;
                break;
            case 2:
                Zimmerpreis = 100;
                Vierte_Abfrage = false;
                break;
            case 3:
                Zimmerpreis = 250;
                Vierte_Abfrage = false;
                break;
            case > 3:
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Console.WriteLine();
                Console.WriteLine("Falsche Eingabe bitte geben sie eine zahl von 1 bis 3 an.");
                Console.WriteLine("App wird neu gestartet.");
                Console.WriteLine();
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Thread.Sleep(7000);
                Console.Clear();
                break;
        }
    }
    catch (Exception)
    {

        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Vierte_Abfrage = true;
        Console.Clear();
    }
}


// 5
bool Fünfte_Abfrage = true;
while (Fünfte_Abfrage == true)
{
    try
    {
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine("Geben sie die Kundenkategorie an:");
        Console.WriteLine("Stammkunde   (20%) = 1");
        Console.WriteLine("Firmenkunde  (15%) = 2");
        Console.WriteLine("Reisebüro    (0%)  = 3");
        Kundenkategorie = Convert.ToUInt16(Console.ReadLine());
        Console.Clear();
        switch (Kundenkategorie)
        {
            case 1:
                Kundenrabatt = 0.8;
                Fünfte_Abfrage = false;
                break;
            case 2:
                Kundenrabatt = 0.85;
                Fünfte_Abfrage = false;
                break;
            case 3:
                Kundenrabatt = 1;
                Fünfte_Abfrage = false;
                break;
            case > 3:
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Console.WriteLine();
                Console.WriteLine("Falsche Eingabe bitte geben sie eine zahl von 1 bis 3 an.");
                Console.WriteLine("App wird neu gestartet.");
                Console.WriteLine();
                Console.WriteLine(Hotel_Rechner1);
                Console.WriteLine(Hotel_Rechner2);
                Console.WriteLine(Hotel_Rechner3);
                Thread.Sleep(7000);
                Console.Clear();
                break;
        }
    }
    catch (Exception)
    {

        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Fünfte_Abfrage = true;
        Console.Clear();
    }
}

bool Test_Abfrage = true;
while (Test_Abfrage == true)
{
    try
    {
        Test_Abfrage = false;
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine("Geben sie die anzahl der Kinder an:");
        Anzahl_der_Kinder = Convert.ToUInt16(Console.ReadLine());
        Console.Clear();
    }
    catch (Exception)
    {

        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Console.WriteLine();
        Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
        Console.WriteLine("App wird neu gestartet.");
        Console.WriteLine();
        Console.WriteLine(Hotel_Rechner1);
        Console.WriteLine(Hotel_Rechner2);
        Console.WriteLine(Hotel_Rechner3);
        Test_Abfrage = true;
        Console.Clear();
    }
}
uint[] KinderAlter = new uint[Anzahl_der_Kinder];

bool Test1 = true;
while (Test1 == true)
{
    while (Anzahl_der_Kinder > 0)
    {
        try
        {
            Test1 = false;
            ++B;
            Console.WriteLine(Hotel_Rechner1);
            Console.WriteLine(Hotel_Rechner2);
            Console.WriteLine(Hotel_Rechner3);
            Console.WriteLine();
            Console.WriteLine($"Geben sie das alter des {B}. kindes an");
            --B;
            KinderAlter[B] = Convert.ToUInt16(Console.ReadLine());
            --Anzahl_der_Kinder;
            Console.Clear();
            if (KinderAlter[B] == 0)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 1)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 2)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 3)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 4)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 5)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 6)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 7)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.7;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 8)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.7;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 9)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.7;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 10)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.7;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] == 11)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.7;
                ERGEB_NIS += Kinderpreis;
            }
            else if (KinderAlter[B] > 11)
            {
                Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer) * 0.3;
                ERGEB_NIS += Kinderpreis;
            }
            ++B;
        }
        catch (Exception)
        {
            Console.WriteLine(Hotel_Rechner1);
            Console.WriteLine(Hotel_Rechner2);
            Console.WriteLine(Hotel_Rechner3);
            Console.WriteLine();
            Console.WriteLine("Falsche Eingabe bitte geben sie eine gültige zahl an.");
            Console.WriteLine("App wird neu gestartet.");
            Console.WriteLine();
            Console.WriteLine(Hotel_Rechner1);
            Console.WriteLine(Hotel_Rechner2);
            Console.WriteLine(Hotel_Rechner3);
            Test1 = true;
            Console.Clear();
        }
    }
}

/* RECHNUNG
ERGEB_NIS = ERGEB_NIS + ERGEB_NIS * 19 / 100;
double Elternpreis = anzahl_der_personen * Zimmerpreis * Aufenthaltsdauer;
Elternpreis = Elternpreis + Elternpreis * 19 / 100;
Endpreis = Elternpreis + ERGEB_NIS;
Endpreis = Endpreis * saison;
Endpreis = Endpreis * Kundenrabatt;
*/

//Load
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots.");
Console.WriteLine($"Rechnung (kinder) : {ERGEB_NIS} + {ERGEB_NIS} * 19 / 100;");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
ERGEB_NIS = ERGEB_NIS + ERGEB_NIS * 19 / 100;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots..");
Console.WriteLine($"Rechnung (Erwachsene) : {anzahl_der_personen} + {Zimmerpreis} * {Aufenthaltsdauer}");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
double Elternpreis = anzahl_der_personen * Zimmerpreis * Aufenthaltsdauer;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots...");
Console.WriteLine($"Rechnung (Erwachsene) : {Elternpreis} + {Elternpreis} * 19 / 100;");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Elternpreis = Elternpreis + Elternpreis * 19 / 100;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots.");
Console.WriteLine($"Rechnung (Endsumme) : {Elternpreis} + {ERGEB_NIS}");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Endpreis = Elternpreis + ERGEB_NIS;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots..");
Console.WriteLine($"Rechnung (Rabatte) : {Endpreis} * {saisonpreis}");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Endpreis = Endpreis * saison;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Berechnen eines Angebots...");
Console.WriteLine($"Rechnung (Rabatte) : {Endpreis} * {Kundenrabatt}");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Endpreis = Endpreis * Kundenrabatt;
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);
Console.WriteLine();
Console.WriteLine($"Endsumme mit rabatten: {Endpreis,10:C2}");
Console.WriteLine();
Console.WriteLine(Hotel_Rechner1);
Console.WriteLine(Hotel_Rechner2);
Console.WriteLine(Hotel_Rechner3);