namespace LotteryMachine
{
    public class Lotto : LotteryRow
    {
        protected override int NumbersCount { get => 7; }
        protected override int AdditionalNumbersCount { get => 0; }

        protected override int NumberArea { get => 40; }
        protected override int AdditionalNumberArea { get => 0; }
    }
}
