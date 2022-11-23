Console.WriteLine("Rechner");
Console.WriteLine("1 Cosinus");
Console.WriteLine("2 Sinus");
Console.WriteLine("3 Tangens");
Console.WriteLine("Geben sie eine zahl von 1-3 ein.");
short Opperator = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Geben sie den winkel ein(in grad).");
double Winkel = Convert.ToDouble(Console.ReadLine());
double ergebniss;


switch (Opperator)
{
    case 1:
        ergebniss = Math.Cos(Winkel);
        Console.WriteLine(ergebniss);
        break;
    case 2:
        ergebniss = Math.Sin(Winkel);
        Console.WriteLine(ergebniss);
        break;
    case 3:
        ergebniss = Math.Tan(Winkel);
        Console.WriteLine(ergebniss);
        break;
}