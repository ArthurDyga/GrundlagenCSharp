Console.WriteLine("BMI rechner");
double Gewicht;
double größe;
double BMI;

Console.WriteLine("Gewicht in KG:");
Gewicht = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Größe in CM:");
größe = Convert.ToDouble(Console.ReadLine());
größe /= 100;

BMI = Gewicht / Math.Pow(größe, 2);
if (BMI < 18.5)
{
    Console.WriteLine("Sie sind Untergewichtig.");
}
else if (BMI <= 25)
{
    Console.WriteLine("Sie sind Normalgewichtig.");
}
else
{
    Console.WriteLine("Sie sind Übergewichtig");
}