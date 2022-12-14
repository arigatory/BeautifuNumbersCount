namespace BeautifuNumbersCount;

// Ordinary generating function (OGF)
public class OGF
{
    private int[] Coefficients;

    public OGF(int length)
    {
        Coefficients = Enumerable.Repeat(1, length).ToArray();
    }

    private OGF(int[] coefficients)
    {
        Coefficients = coefficients;
    }

    public static OGF operator *(OGF op1, OGF op2)
    {
        int[] coefficients
            = new int[op1.Coefficients.Length + op2.Coefficients.Length - 1];

        for (int i = 0; i < op1.Coefficients.Length; ++i)
            for (int j = 0; j < op2.Coefficients.Length; ++j)
                coefficients[i + j] += op1.Coefficients[i] * op2.Coefficients[j];
        return new OGF(coefficients);
    }

    public UInt64 SumOfSquareCoefficients
    {
        get
        {
            UInt64 result = 0;
            foreach (int coefficient in Coefficients)
            {
                result += (UInt64)coefficient * (UInt64)coefficient;
            }

            return result;
        }
    }
}
