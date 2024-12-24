namespace Assignment
{
    internal class Program
    {
        #region Q1
        //Value
        public static void IncrementByValue(int num)
        {
            num += 1;
        }
        //Reference
        public static void IncrementByReference(ref int num)
        {
            num += 1;
        }
        #endregion

        #region Q2
        //Value 
        public static void ModifyContent(Person person)
        {
            person.Name = "Modified";
        }

        //Reference
        public static void ReplaceReference(ref Person person)
        {
            person = new Person { Name = "New Object" };
        }
        #endregion

        #region Q3
        public static void Calculate(int num1, int num2, out int sum, out int difference)
        {
            sum = num1 + num2;       
            difference = num1 - num2;
        }
        #endregion

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

        #region Q6
        #region MinFunc
        public static int MinArr(int[] arr,int size)
        {
            int min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        #endregion

        #region MaxFunc
        public static int MaxArr(int[] arr, int size)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        #endregion

        #region MaxMinArr
        public static void MaxMinArr(int[] arr, int size)
        {
            Console.WriteLine($"Max => {MaxArr(arr,size)}");
            Console.WriteLine($"Min => {MinArr(arr,size)}");
        }
        #endregion
        #endregion

        #region Q7
        //public static int Factorial(int num)
        //{
        //    int result = 1;
        //    for(int i = 1; i <= num; i++)
        //    {
        //        result *= i; 
        //    }
        //    return result;
        //}
        #endregion

        #region Q8
        public static void ChangeChar(ref string input, int position, char newChar)
        {
            char[] charArray = input.ToCharArray();

            charArray[position-1] = newChar;

            input = new string(charArray);
        }
        #endregion


        static void Main(string[] args)
        {
            #region Q1
            /*
         
                By Value:
                -A copy of the variable is passed.
                -Modifications inside the function do not affect the original value.

                By Reference (ref):
                -The actual variable is passed.
                -Modifications inside the function directly affect the original value.
            
             */

            //int value = 10;

            //// Value
            //IncrementByValue(value);
            //Console.WriteLine("After Pass by Value: " + value);//10

            //// Reference
            //IncrementByReference(ref value);
            //Console.WriteLine("After Pass by Reference: " + value); //11
            #endregion

            #region Q2
            /*
                By Value:
                -The reference (address) of the object is passed, not the object itself.
                -Changes made to the object content affect the original object.
                -However, assigning a new object inside the method does not affect the original reference.

                By Reference (ref):
                -Passes the reference itself by reference.
                -Allows modifying the entire reference (can refer to a new object) and affects the original reference.
             */
            //Person person = new Person { Name = "Original" };

            ////value
            //ModifyContent(person);
            //Console.WriteLine("After ModifyContent: " + person.Name);

            ////Reference
            //ReplaceReference(ref person);
            //Console.WriteLine("After ModifyReference: " + person.Name);
            #endregion

            #region Q3
            //Console.Write("Enter Num1: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter Num2: ");
            //int.TryParse(Console.ReadLine(), out int num2);

            //int summ, diff;
            //Calculate(num1, num2, out summ, out diff);
            //Console.WriteLine($"Summation => {summ}");
            //Console.WriteLine($"Difference => {diff}");
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

            #region Q6
            //int[] arr = { 1, 2, 3, -1, 5, 8 };
            //int size = arr.Length;
            //MaxMinArr(arr, size);
            #endregion

            #region Q7
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(Factorial(num));
            #endregion

            #region Q8
            //Console.WriteLine("Enter the String: ");
            //string text = Console.ReadLine()!;
            //Console.WriteLine("Enter the Position would you modify : ");
            //int.TryParse(Console.ReadLine(), out int Position);
            //Console.WriteLine("Enter the Replacement Char : ");
            //char.TryParse(Console.ReadLine(), out char newChar);

            //ChangeChar(ref text, Position, newChar);
            //Console.WriteLine(text);
            #endregion
        }
    }
}
