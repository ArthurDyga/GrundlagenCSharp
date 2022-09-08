//Arbeitsauftrag 1
int Short = 2 * 8; //bytes x 8
int Integer = 4 * 8;
int Long = 8 * 8;
int Float = 4 * 8;
int Double = 8 * 8;
int Decimal = 16 * 8;
Console.WriteLine($"Short:{Short} Bits / {typeof(short)} hat {sizeof(short)} Bytes / MinValue: {short.MinValue} / MaxValue: {short.MaxValue}");
Console.WriteLine($"int:{Integer} Bits {typeof(int)} hat {sizeof(int)} Bytes / MinValue: {int.MinValue} / MaxValue: {int.MaxValue}");
Console.WriteLine($"long:{Long} Bits {typeof(long)} hat {sizeof(long)} Bytes / MinValue: {long.MinValue} / MaxValue: {long.MaxValue}");
Console.WriteLine($"float:{Float} Bits {typeof(float)} hat {sizeof(float)} Bytes / MinValue: {float.MinValue} / MaxValue: {float.MaxValue}");
Console.WriteLine($"double:{Double} Bits {typeof(double)} hat {sizeof(double)} Bytes / MinValue: {double.MinValue} / MaxValue: {double.MaxValue}");
Console.WriteLine($"decimal:{Decimal} Bits {typeof(decimal)} hat {sizeof(decimal)} Bytes / MinValue: {decimal.MinValue} / MaxValue: {decimal.MaxValue}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Arbeitsauuftrag 2
string Vorname = "Arthur";
short Alter = 15;
bool Ist_CSharp_Die_Erste_Programmiersprache_Die_sie_Lernen = true;
Console.WriteLine($"Vorname: {Vorname}");
Console.WriteLine($"Alter: {Alter}");
Console.WriteLine($"Ist C# Die erste Programmiersprache die sie lernen?: {Ist_CSharp_Die_Erste_Programmiersprache_Die_sie_Lernen}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Arbeitsauftrag 3
int DollarZahl = 36;
char Dollar = (char)DollarZahl;
Console.WriteLine($"{DollarZahl}{Dollar}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Arbeitsauftrag 4
Console.WriteLine("Zufällige zahl");
string Value1 = Console.ReadLine();
Console.WriteLine("Zufällige Dezimalzahl");
string Value2 = Console.ReadLine();

short Konvertiert1 = Convert.ToInt16(Value1);
double Konvertiert2 = Convert.ToDouble(Value2);

Console.WriteLine($"Erfolgreich {Konvertiert1} zu {typeof(short)} konvertiert");
Console.WriteLine($"Erfolgreich {Konvertiert2} zu {typeof(double)} konvertiert");
Console.ReadLine();