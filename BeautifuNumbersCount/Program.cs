using BeautifuNumbersCount;
const int numeraBase = 13;

var A1 = new OGF(numeraBase);
var A3 = A1 * A1 * A1;
var A6 = A3 * A3;

long result = A6.SumOfSquareCoefficients;
result *= numeraBase;

Console.WriteLine(result);