using BeautifuNumbersCount;
const int numeraBase = 13;

// Ordinary generating function (OGF)
var ogf1 = new OGF(numeraBase);
var ogf3 = ogf1 * ogf1 * ogf1;
var ogf6 = ogf3 * ogf3;

long result = ogf6.SumOfSquareCoefficients;
result *= numeraBase;

Console.WriteLine(result);