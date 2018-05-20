namespace LotteryMachine
{
    public class Eurojackpot : LotteryRow
    {
        protected override int NumbersCount { get => 5; }
        protected override int AdditionalNumbersCount { get => 2; }

        protected override int NumberArea { get => 50; }
        protected override int AdditionalNumberArea { get => 10; }
    }
}
