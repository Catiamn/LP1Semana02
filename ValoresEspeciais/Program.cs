using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Exercicio 6
            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;

            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;

            double dbMin = double.MinValue;
            double dbMax = double.MaxValue;

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

            long lMax = long.MaxValue;
            long lMin = long.MinValue;

            int iMax = int.MaxValue;
            int iMin = int.MinValue;

            uint uiMax = uint.MaxValue;
            uint uiMin = uint.MinValue;
            Console.WriteLine($"{sbMax}\n{sbMin}\n{bMax}\n{bMin}\n{dbMax}\n{dbMin}\n{fMax}\n{fMin}\n{ulMax}\n{ulMin}\n{lMax}\n{lMin}\n{iMax}\n{iMin}\n{uiMax}\n{uiMin}");
            double x = double.PositiveInfinity ;
            double y = double.NegativeInfinity ;
            float x2 = float.PositiveInfinity;
            float y2 = float.NegativeInfinity;
            double xx = double.PositiveInfinity / double.PositiveInfinity ; //NaN!
            float yy = float.NaN; //Direto
            Console.WriteLine($"{x}\n{y}\n{x2}\n{y2}\n{xx}\n{yy}");

            //Exercicio 7
            //overflow
            double a = 2∗double.MaxValue;
            double b = double.MaxValue + 1;


        }
    }
}
