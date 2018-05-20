using System;

namespace LotteryMachine
{
    public enum Game
    {
        Eurojackpot,
        Lotto,
        VikingLotto
    }

    public static class Factory
    {
        public static Random random = new Random();

        public static LotteryRow NewRow(Game game)
        {
            switch (game)
            {
                case Game.Eurojackpot:
                    return new Eurojackpot();
                case Game.Lotto:
                    return new Lotto();
                case Game.VikingLotto:
                    return new VikingLotto();
                default:
                    return NewRow((Game)0);
            }
        }

        public static LotteryRow CustomLottery(
            int p_numbersCount,
            int p_additionalNumbersCount,
            int p_numberArea,
            int p_additionalNumberArea)
        {
            return new CustomLottery(p_numbersCount, p_additionalNumbersCount, p_numberArea, p_additionalNumberArea);
        }

        public static LotteryRow RandomLottery()
        {
            return NewRow((Game)random.Next(Enum.GetValues(typeof(Game)).Length));
        }
    }
}
