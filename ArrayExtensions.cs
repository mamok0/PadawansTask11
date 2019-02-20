using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                throw new ArgumentException();
            if (accuracy <= 0 || accuracy >= 1)
                throw new ArgumentOutOfRangeException();
            for(int i=1; i<array.Length - 1; i++)
            {
                double num1 = 0, num2 = 0;
                for(int j=0; j<array.Length; j++)
                {
                    if (j < i)
                        num1 += array[j];
                    if (j > i)
                        num2 += array[j];
                }
                if (Math.Abs(num2 - num1) <= accuracy)
                    return i;
            }
            return null;
        }
    }
}
