namespace LotteryMachine
{
    public class CustomLottery : LotteryRow
    {
        protected override int NumbersCount { get => m_numbersCount; }
        protected override int AdditionalNumbersCount { get => m_additionalNumbersCount; }

        protected override int NumberArea { get => m_numberArea; }
        protected override int AdditionalNumberArea { get => m_AdditionalNumberArea; }

        int m_numbersCount;
        int m_additionalNumbersCount;

        int m_numberArea;
        int m_AdditionalNumberArea;

        public CustomLottery(
            int p_numbersCount,
            int p_additionalNumbersCount,
            int p_numberArea,
            int p_additionalNumberArea)
        {
            m_numbersCount = (p_numbersCount > 0) ? p_numbersCount : 1; // Requires at least 1 number
            m_additionalNumbersCount = (p_additionalNumbersCount >= 0) ? p_additionalNumbersCount : 0; // Cannot be negative value
            m_numberArea = (p_numberArea > m_numbersCount) ? p_numberArea : m_numbersCount + 1; // NumberArea has to be greater than the value of numbers
            m_AdditionalNumberArea = (p_additionalNumberArea >= m_additionalNumbersCount) ? p_additionalNumberArea : m_additionalNumbersCount; // AdditionalNumberArea has to be at least the same value as additional number count

            base.Populate();
        }

        /// <summary>
        /// Override Populate method so it will not be run by LotteryRow class automatically, instead base.Populate() is called in CustomLottery constructor when lottery configurations are ready.
        /// </summary>
        protected override void Populate() { }
    }
}