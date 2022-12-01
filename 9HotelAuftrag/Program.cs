double Aufenthaltsdauer;
double anzahl_der_personen;
double saison;
double Zimmerkategorie;
double Kundenkategorie;
double Anzahl_der_Kinder;
double Alter_Der_Kinder;
double[] Kinder = new double[10] {0,0,0,0,0,0,0,0,0,0};
double[] KinderAlter = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
double Kinderpreis = 0;
int B = 0;
double Zimmerpreis = 0;
double Kundenrabatt = 0;
double Endpreis = 0;
double Endpreis_Kinder = 0;
double ERGEB_NIS = 0;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Hotel rechner");
Console.WriteLine();
Console.WriteLine("Geben sie die Aufenthaltsdauer an:");
Aufenthaltsdauer = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geben sie die Anzahl der personen an:");
anzahl_der_personen = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geben sie die saison an:");
Console.WriteLine("Frühling = 1");
Console.WriteLine("Sommer = 2");
Console.WriteLine("Herbst = 3");
Console.WriteLine("Winter = 4)");
saison = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geben sie die Zimmerkategorie an:");
Console.WriteLine("Standard = 1");
Console.WriteLine("Komfort = 2");
Console.WriteLine("Suit = 3");
Zimmerkategorie = Convert.ToDouble(Console.ReadLine());
switch (Zimmerkategorie)
{
    case 1:
        Zimmerpreis = 70;
        break;
    case 2:
        Zimmerpreis = 100;
        break;
    case 3:
        Zimmerpreis = 250;
        break;
}
Console.WriteLine("Geben sie die Kundenkategorie an:");
Console.WriteLine("Stammkunde = 1");
Console.WriteLine("Firmenkunde = 2");
Console.WriteLine("Reisebüro = 3");
Kundenkategorie = Convert.ToDouble(Console.ReadLine());
switch (Kundenkategorie)
{
    case 1:
        Kundenrabatt = 20;
        break;
    case 2:
        Kundenrabatt = 15;
        break;
    case 3:
        Kundenrabatt = 10;
        break;
}
Console.WriteLine("Geben sie die anzahl der Kinder an:");
Anzahl_der_Kinder = Convert.ToDouble(Console.ReadLine());
if (Anzahl_der_Kinder > 0)
{
    while (Anzahl_der_Kinder > 0)
    {
        ++B;
        Console.WriteLine($"Geben sie das alter des {B}. kindes an");
        --B;
        KinderAlter[B] = Convert.ToDouble(Console.ReadLine());
        --Anzahl_der_Kinder;
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
            Kinderpreis += (1 * Zimmerpreis * Aufenthaltsdauer)*0.7;
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
}

Console.WriteLine(ERGEB_NIS);
ERGEB_NIS = ERGEB_NIS + ERGEB_NIS * 19 / 100;
double Elternpreis = anzahl_der_personen * Zimmerpreis * Aufenthaltsdauer;
Elternpreis = Elternpreis + Elternpreis * 19 / 100;
Endpreis = Elternpreis + ERGEB_NIS;
Console.WriteLine($"Der preis beträgt: {Endpreis,10:C2}");