namespace Lab15
{
    delegate void CalcMethod(int a, int b, ref int result);
    internal class Calculator
    {
        public static CalcMethod Sum = delegate (int a, int b, ref int result)
        {
            result += a + b;
        };
        public static CalcMethod Sub = delegate (int a, int b, ref int result)
        {
            result += a - b;
        };
        public static CalcMethod Mult = delegate (int a, int b, ref int result)
        {
            result += a * b;
        };
        public static CalcMethod Del = delegate (int a, int b, ref int result)
        {
            result += a / b;
        };

    }
}
