namespace RandomNumberator
{
    public class NumberatorGenerate
    {
        public int GenerateMyNumber(int start, int end)
        {
            if (start == 0 && end == 0) throw new ArgumentException("Both values cannot be null");
            if (start > end) throw new ArgumentException("Starting value cannot be higher then Ending vaule");

            var randoGen = new Random();

            return randoGen.Next(start, end);
        }

    }
}