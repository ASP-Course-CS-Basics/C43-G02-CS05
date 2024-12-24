namespace Assignment
{
    internal class Program
    {
        #region Q4
        public static int SumDigits(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result += num % 10;
                num /= 10;
            }
            return result;
        }
        #endregion

        #region Q5
        public static bool IsPrime(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
        #endregion


        static void Main(string[] args)
        {
            #region Q1!!

            #endregion

            #region Q2!!

            #endregion

            #region Q3!!

            #endregion

            #region Q4
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(SumDigits(num));
            #endregion

            #region Q5
            //Console.Write("Enter Number To Check Prime Or Not: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(IsPrime(num));
            #endregion


        }
    }
}
