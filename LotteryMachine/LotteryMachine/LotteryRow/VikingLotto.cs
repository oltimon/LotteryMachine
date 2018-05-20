namespace LotteryMachine
{
    public class VikingLotto : LotteryRow
    {
        protected override int NumbersCount { get => 6; }
        protected override int AdditionalNumbersCount { get => 1; }

        protected override int NumberArea { get => 48; }
        protected override int AdditionalNumberArea { get => 8; }
    }
}
