Console.WriteLine("введите чисела");
double b1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);

double[] intersectPoint = GetIntersectPoint(b1, b2, k1, k2);

Console.WriteLine(intersectPoint[0]);
Console.WriteLine(intersectPoint[1]);

double[] GetIntersectPoint(double b1, double b2, double k1, double k2)
{
    double[] result = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    result[0] = x;
    result[1] = y;

    return result;
}
