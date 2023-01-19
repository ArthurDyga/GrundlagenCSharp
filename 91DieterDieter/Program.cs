double Schirttgröße;
double Abstand;
double Resistor;

Console.WriteLine("Geben sie die scrhrittgröße an");
Schirttgröße = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geben sie den Abstand an");
Abstand = Convert.ToDouble(Console.ReadLine());
double länge = Abstand / Schirttgröße;
while (länge > 0)
{
    --länge;
    Resistor = 0.017 * (länge / 1.5);
    Console.WriteLine(Resistor);
}
