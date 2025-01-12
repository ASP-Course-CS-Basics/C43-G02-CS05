namespace Demo
{
    internal class Program
    {

        #region Part 01 Functions (Prototype, Calling)

        #region Without Parameter

        //static void PrintShapes01()//Function Signature [ReturnType(Void) - Name(PrintShapes) - Parameters( () )]
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("*_*");//Function Body
        //    }
        //}  

        #endregion

        #region With Parameters

        //static void PrintShapes02(int count, string shape)
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine(shape);
        //    }
        //}

        #endregion

        #region With Default value parameters

        //static void PrintShapes03(int count = 10, string shape = "###")//Note => if you make function that take default parameters, the default parameters order must be the last parameters in the function parameters
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.WriteLine(shape);
        //    }
        //}

        #endregion

        #endregion

        #region Part 02 Functions - ValueType Parameters

        #region Passing By Value [input parameters]

        static void Swap01(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        #endregion

        #region Passing by ref [Reference] [input output parameters]

        static void Swap02(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        #endregion


        #endregion

        #region Part 03 Functions - ReferenceType Parameters

        #region Passing By Value

        #region Ex01

        static int SumArrEx02_01(int[] arr) // when saying SumArr(numbers) => arr = numbers = addres of array {1,2,3,4,5};
        {
            int result = 0;
            if (arr is { } && arr.Length > 0)
            {
                arr[0] = 100; //{100,2,3,4,5};
                //This Modify of value of index [0] of reference "arr" that refer to the object array of integers {1,2,3,4,5} will affect the value of index [0] in numbers array because the references (arr,numbers) refer to the same object
                for (int i = 0; i < arr?.Length; i++)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        #endregion

        #region Ex02

        static int SumArrEx02_02(int[] arr) // when saying SumArr(numbers) => arr = Value of numbers = address of array {1,2,3,4,5};
        {
            int result = 0;
            if (arr is { } && arr.Length > 0)
            {
                //arr[0] = 100; //{100,2,3,4,5};
                arr = new int[] { 100, 200, 300 };//The reference "arr" leave referring to the object {1,2,3,4,5} and refer to new object, and numbers reference still refer to object {1,2,3,4,5} .
                for (int i = 0; i < arr?.Length; i++)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        #endregion

        #endregion

        #region Passing By Reference [ref]

        #region Ex01

        static int SumArrEx02_01(ref int[] arr) // when saying SumArr(ref numbers) => arr is alias for numbers that refer to address of array {1,2,3,4,5};
        {
            int result = 0;
            if (arr is { } && arr.Length > 0)
            {
                arr[0] = 100; //{100,2,3,4,5};
                //This Modify of value of index [0] of reference "arr" that refer to the object array of integers {1,2,3,4,5} will affect the value of index [0] in numbers array because the references (arr,numbers) refer to the same object
                for (int i = 0; i < arr?.Length; i++)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        #endregion


        #region Ex02

        static int SumArrEx02_02(ref int[] arr) // when saying SumArr(ref numbers) => "arr" is alias/Rename for reference "numbers" that refer to address of array {1,2,3,4,5};
        {
            int result = 0;
            if (arr is { } && arr.Length > 0)
            {
                //arr[0] = 100; //{100,2,3,4,5};
                arr = new int[] { 100, 200, 300 };//this arr itself modified it's elements values to be from {1,2,3,4,5} to {100,200,300}.
                for (int i = 0; i < arr?.Length; i++)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        #endregion

        #endregion

        #endregion

        #region Part 05 Functions - Passing By Out

        #region Ex01

        static void SumMul(int x,int y,out int summation,out int multiplication)
        {
            summation = x + y;
            multiplication = x * y;
        }

        #endregion

        #endregion

        static void Main(string[] args)
        {

            #region Part 01 Functions (Prototype, Calling)

            #region Without Parameter

            //Program.PrintShapes01();

            #endregion

            #region With Parameters

            //PrintShapes02(10,"#_#");

            #endregion

            #region With Default value parameters

            //PrintShapes03();//it will use the default parameters of function  to print the shape (count = 10 , shape = "###")
            ////Note => if you make function that take default parameters, the default parameters order must be the last parameters in the function parameters

            #endregion

            #region skip the meaning of bachslash \ in the string:

            //string folderPath01 = "D:\\TECK-COURSES\\Route-Courses\\Back-End(.NET)\\ENG-NASR\\02 C#\\01 Basics\\Session 05 {NEW}\\Videos";//skip meaning of backslash (\) using Escape character \.
            //string folderPath02 = @"D:\TECK-COURSES\Route-Courses\Back-End(.NET)\ENG-NASR\02 C#\01 Basics\Session 05 {NEW}\Videos"; //skip meaning of backslash (\) using @.

            //Console.WriteLine(folderPath01);//D:\TECK-COURSES\Route-Courses\Back-End(.NET)\ENG-NASR\02 C#\01 Basics\Session 05 {NEW}\Videos
            //Console.WriteLine(folderPath02);//D:\TECK-COURSES\Route-Courses\Back-End(.NET)\ENG-NASR\02 C#\01 Basics\Session 05 {NEW}\Videos

            #endregion

            #endregion

            #region Part 02 Functions - ValueType Parameters

            #region Passing By Value [input parameters]

            //int x = 5, y = 10;

            //Console.WriteLine("====== Before Swapping =======");
            //Console.WriteLine($"x = {x}, y = {y}");//x = 5, y = 10

            //Swap01(x, y);

            //Console.WriteLine("====== After Swapping =======");
            //Console.WriteLine($"x = {x}, y = {y}");//x = 5, y = 10 

            #endregion

            #region Passing by ref [Reference] [input output parameters]

            //int x = 5, y = 10;

            //Console.WriteLine("====== Before Swapping =======");
            //Console.WriteLine($"x = {x}, y = {y}");//x = 5, y = 10

            //Swap02(ref x,ref y);

            //Console.WriteLine("====== After Swapping =======");
            //Console.WriteLine($"x = {x}, y = {y}");//x = 10, y = 5

            #endregion


            #endregion

            #region Part 03 Functions - ReferenceType Parameters

            #region Passing By Value

            #region Ex01

            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(SumArrEx02_01(numbers));// (114) -  Passing by value => SumArrEx02_01(value) - SumArrEx02_01(numbers) - SumArrEx02_01(Address of The Array of integers in heap) ). Pass Value Of Numbers 
            //Console.WriteLine(numbers[0]);//100  

            #endregion

            #region Ex02

            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(SumArrEx02_02(numbers));// 600 [the sum of the new object elements that initialize into function SumArrEx02_02() ] -  Passing by value => SumArrEx02_01(value) - SumArrEx02_01(numbers) - SumArrEx02_01(Address of The Array of integers in heap) ). Pass Value Of Numbers 
            //Console.WriteLine(numbers[0]);// "1" not "100" - because I access the "numbers" elements which is {1,2,3,4,5} not "arr" elements {100,200,300} - and i pass the value of "numbers" which is address of {1,2,3,4,5} not the "numbers" it self and then "arr" decide to refer to new object inside the function  

            #endregion

            #endregion

            #region Passing By Reference [ref]

            #region Ex01

            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(SumArrEx02_01(ref numbers));// (114) -  Passing The Reference itself not value of reference => SumArrEx02_01(reference) - SumArrEx02_01(numbers) ). Pass The Reference "Numbers" to the function parameter "arr" 
            //Console.WriteLine(numbers[0]);//100
            //
            #endregion

            #region Ex02

            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(SumArrEx02_02(ref numbers));// (600) -  Passing The Reference itself not value of reference => SumArrEx02_02(reference) - SumArrEx02_02(numbers) ). Pass The Reference "Numbers" to the function parameter "arr" so any change to "arr" will affect the "numbers".
            //Console.WriteLine(numbers[0]);//100 

            #endregion

            #endregion

            #endregion

            #region Part 05 Functions - Passing By Out

            #region Ex01

            int num1 = 5, num2 = 6, summ, mull;
            SumMul(num1, num2, out summ, out mull);

            Console.WriteLine($"Summation =      {summ}");//11
            Console.WriteLine($"Multiplication = {mull}");//30

            #endregion

            #endregion

        }
    }
}
