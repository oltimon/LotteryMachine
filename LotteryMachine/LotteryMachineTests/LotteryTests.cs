using Microsoft.VisualStudio.TestTools.UnitTesting;
using LotteryMachine;

namespace LotteryMachineTests
{
    [TestClass]
    public class LotteryTests
    {
        [TestMethod]
        public void Eurojackpot_CorrectCount()
        {
            int numbers_expected = 5;
            int additionalNumbers_expected = 2;
            LotteryRow row = Factory.NewRow(Game.Eurojackpot);

            Assert.AreEqual(numbers_expected, row.Numbers.Length);
            Assert.AreEqual(additionalNumbers_expected, row.AdditionalNumbers.Length);

        }

        [TestMethod]
        public void Lotto_CorrectCount()
        {
            int numbers_expected = 7;
            int additionalNumbers_expected = 0;
            LotteryRow row = Factory.NewRow(Game.Lotto);

            Assert.AreEqual(numbers_expected, row.Numbers.Length);
            Assert.AreEqual(additionalNumbers_expected, row.AdditionalNumbers.Length);

        }

        [TestMethod]
        public void Vikinglotto_CorrectCount()
        {
            int numbers_expected = 6;
            int additionalNumbers_expected = 1;
            LotteryRow row = Factory.NewRow(Game.VikingLotto);

            Assert.AreEqual(numbers_expected, row.Numbers.Length);
            Assert.AreEqual(additionalNumbers_expected, row.AdditionalNumbers.Length);

        }

        [TestMethod]
        public void CustomLottery_CorrectCount()
        {
            int numbers_expected = 10;
            int additionalNumbers_expected = 10;
            LotteryRow row = Factory.CustomLottery(numbers_expected, additionalNumbers_expected, 0, 0);

            Assert.AreEqual(numbers_expected, row.Numbers.Length);
            Assert.AreEqual(additionalNumbers_expected, row.AdditionalNumbers.Length);

        }

        [TestMethod]
        public void CustomLottery_SortedCorrectly()
        {
            LotteryRow row = Factory.CustomLottery(10, 10, 0, 0);

            for (int i = 0; i < row.Numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < row.Numbers.Length; j++)
                    Assert.IsTrue(row.Numbers[i] < row.Numbers[j], "Numbers not sorted correctly.");
            }

            for (int i = 0; i < row.AdditionalNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < row.AdditionalNumbers.Length; j++)
                    Assert.IsTrue(row.AdditionalNumbers[i] < row.AdditionalNumbers[j], "Additional numbers not sorted correctly.");
            }

        }

        [TestMethod]
        public void Eurojackpot_SortedCorrectly()
        {
            LotteryRow row = Factory.NewRow(Game.Eurojackpot);

            for (int i = 0; i < row.Numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < row.Numbers.Length; j++)
                    Assert.IsTrue(row.Numbers[i] < row.Numbers[j], "Not sorted correctly.");
            }

            Assert.IsTrue(row.AdditionalNumbers[0] < row.AdditionalNumbers[1], "Additional numbers in wrong order.");

        }
    }
}
