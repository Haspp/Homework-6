double b1 = InputDouble("Введите координаты b1: ");
double k1 = InputDouble("Введите координаты k1: ");

double b2 = InputDouble("Введите координаты b2: ");
double k2 = InputDouble("Введите координаты k2: ");

double x = -(b1 - b2)/(k1 - k2);
double y = k1 * x + b1;
// double y = (b1 - b2)/(k1 - k2);

Console.WriteLine($"({x};{y})");

double InputDouble(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
    
}