using System;

namespace LotteryMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRow(Factory.NewRow(Game.Lotto), "Lotto: ");
            PrintRow(Factory.NewRow(Game.Eurojackpot), "Eurojackpot: ");
            PrintRow(Factory.NewRow(Game.VikingLotto), "Vikinglotto: ");
            PrintRow(Factory.CustomLottery(4, 4, 50, 20), "Custom: ");
        }

        static void PrintRow(LotteryRow row, string header = null)
        {
            Console.Write(header);
            Console.Write(string.Join(", ", row.Numbers));
            if (row.AdditionalNumbers.Length > 0) Console.Write(" | ");
            Console.WriteLine(string.Join(", ", row.AdditionalNumbers));
        }
    }
}
