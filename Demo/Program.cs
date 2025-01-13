
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        static void SumMul(int x,int y,out int summation,out int multiplication)//The output parameters must be initialized with value into function, regardless they enter function with value or not.
        {
            summation = x + y;
            multiplication = x * y;
        }

        #endregion

        #region Ex02 - Part 06 Functions - Passing By Out (REAL Example) - Function check if customer has discount based on his points

        static bool CheckDiscount(int customerId,out decimal discount)
        {
            //Simulate Fetching Data of this customer from DataBase
            int points = GetCustomerPoints(customerId);

            if(points > 1000)
            {
                discount = points * .1m;
                return true;
            }
            discount = default;//Default value of decimal(0).
            return false;
        }

        private static int GetCustomerPoints(int customerId)
        {
            if (customerId == 1001)
            {
                return 10_000;
            }
            else if (customerId == 2002)
            {
                return 5_000;
            }
            else
                return 0;//Unknown Customer
        }

        #endregion

        #endregion

        #region Part 07 Functions - Params

        static int SumArr(params int[] arr)
        {
            int result = 0;
            if (arr?.Length > 0)
            {
                for (int i= 0; i < arr.Length; i++)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        #endregion

        #region Part 08 Functions - Params in C# 13.0

        #region Ex01 - Params Parameter Of Type List of integers.

        static int SumNumbers(params List<int> numbers)//Params Parameter Of Type List of integers [C# 13.0] feature
        {
            int result = 0;
            if (numbers?.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    result += numbers[i];
                }
            }
            return result;
        }

        #endregion

        #region Ex02 - Params Parameter/reference Of Type Interface IEnumerable [Develop Against Interface not specific class].

        static int SumNumbers02(params IEnumerable<int> numbers)//This Reference "numbers" can refer to reference/object of type any class that implement IEnumerable interface
                                                                //and implement the method "enumeration" meaning this class is collection which can iterate over it
         //Note => The reference "numbers" only sea the method "enumeration" that is inside the object passed to it when calling the function, so the field count is not accessible so ypu can't use it inside code.
         //{
         //    int result = 0;
         //    if (numbers?.Count > 0)
         //    {
         //        for (int i = 0; i < numbers.Count; i++)
         //        {
         //            result += numbers[i];
         //        }
         //    }
         //    return result;
         //}

        {
            int result = 0;
            if (numbers is not null)
            {
               foreach(int number in numbers)
                {
                    result += number;
                }
            }
            return result;
        }

        #endregion

        #endregion

        #region Part 10 Exception Handling and Protective Code

        #region Ex01 - Without Using Try-Catch.

        static void DummyCode01()
        {
            int x, y, z;
            x = int.Parse(Console.ReadLine());//Through exception if user enter string (and string can't be converted to int) [Format Exception].
            y = int.Parse(Console.ReadLine());//Through exception if user enter string (and string can't be converted to int) [Format Exception].

            z = x / y;//Through exception if user enter y = 0 [Divide By Zero Exception].

            int[] arr = new int[] { 1, 2, 3 };
            arr[100] = 20;//Through Exception [Out Of Range Exception] [Try to access index out of array range].
        }

        #endregion

        #region Ex02 - Using Try-Catch.

        static void DummyCode02()
        {
            try
            {
                int x, y, z;
                x = int.Parse(Console.ReadLine());//Through exception if user enter string (and string can't be converted to int) [Format Exception].
                y = int.Parse(Console.ReadLine());//Through exception if user enter string (and string can't be converted to int) [Format Exception].

                z = x / y;//Through exception if user enter y = 0 [Divide By Zero Exception].

                int[] arr = new int[] { 1, 2, 3 };
                arr[100] = 20;//Through Exception [Out Of Range Exception] [Try to access index out of array range].
            }
            catch (Exception ex)//reference in stack refer to the created object in heap while exception occur.
            { 
                Console.WriteLine(ex.Message);//Friendly message to user.
            }
        }

        #endregion

        #region Ex03 - Write DummyCode() In Protective way - not use try-catch because i expected the exception that will occured

        static void DummyCodeProtective()
        {
            int x, y, z;
            do
            {
                Console.Write("Enter The First Number: ");
            } while ( !(int.TryParse(Console.ReadLine(),out x)) );

            do
            {
                Console.Write("Enter The Second Number: ");
            } while ( !(int.TryParse(Console.ReadLine(),out y)) || y==0 );

            z = x / y;

            int[] arr = new int[] { 1, 2, 3 };
            if (arr?.Length > 100)
            {
                arr[100] = 20;
            }
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

            //int num1 = 5, num2 = 6, summ, mull;
            //SumMul(num1, num2, out summ, out mull);

            //Console.WriteLine($"Summation =      {summ}");//11
            //Console.WriteLine($"Multiplication = {mull}");//30

            #endregion

            #region Ex02 - Part 06 Functions - Passing By Out (REAL Example) - Function check if customer has discount based on his points

            //int customerId = 1001;
            //bool isEligable = false;
            //decimal discount;

            //isEligable = CheckDiscount(customerId, out discount);

            //if (isEligable)
            //{
            //    Console.WriteLine($"This Customer Is Eligable For Discount : {discount:c}");
            //}
            //else
            //{
            //    Console.WriteLine($"This Customer Is Not Eligable And discount is : {discount}");
            //}

            #endregion

            #endregion

            #region Part 07 Functions - Params

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };//No Need To Do This.
            //int result = SumArr(1, 2, 3, 4, 5, 6, 7);//Do this.

            //Console.WriteLine(SumArr(numbers));//28  
            //Console.WriteLine(result);//28

            ///*
            //     * Params Parameter Must Be The Last Parameter In Method Parameters.
            //     * Params Parameter Must Be of Type array of integers int[].
            //     * Method can have only one params parameter.
            //     * Start with (.NET 9 - C# 13) params parameter may be of type array of integers or any collection.
            // */

            #endregion

            #region Part 08 Functions - Params in C# 13.0

            #region Ex01 - Params Parameter Of Type List of integers.

            //List<int> listNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };//No need to do this, if the parameter is params.
            //int result = SumNumbers(1, 2, 3, 4, 5, 6, 7);

            //Console.WriteLine(SumNumbers(listNumbers));//28
            //Console.WriteLine(result);//28

            #endregion

            #region Ex02 - Params Parameter/reference Of Type Interface IEnumerable [Develop Against Interface not specific class]

            // int[] ArrayNumbers = new int[] { 1, 2, 3, 4, 5 };

            // int result01 = SumNumbers02(ArrayNumbers);//Passing Reference of type Array of integers "ArrayNumbers" to the reference of type interface "numbers" in method parameter. 
            // int result02 = SumNumbers02(1, 2, 3, 4, 5);//Passing seperated values because the parameter of method "SumNumbers02" is "params"

            // Console.WriteLine(result01);//15
            // Console.WriteLine(result02);//15

            ////===================================================================================================================================================================================

            // List<int> ListNumbers = new List<int>(){ 1, 2, 3, 4, 5 };

            // int result001 = SumNumbers02(ArrayNumbers);//Passing Reference of type List of integers "ListNumbers" to the reference of type interface "numbers" in method parameter. 
            // int result002 = SumNumbers02(1, 2, 3, 4, 5);//Passing seperated values because the parameter of method "SumNumbers02" is "params"

            // Console.WriteLine(result01);//15
            // Console.WriteLine(result02);//15

            #endregion

            #endregion

            #region  Part 10 Exception Handling and Protective Code

            #region Ex01 - Without Using Try-Catch.
            
            //DummyCode01();

            ///*
            //     * In This Case If Any Of Lines Inside Function Caused Exception The Program Will Stop The Execution And Throught Exception
            //     * Mean That If I Have Any Thing After This Calling Of Function "DummyCode01()" in Main(), it will not executed.
            // */

            //Console.WriteLine("Code After DummyCode() Will Not Executeed If there is any lines inside DummyCode() through exception!");

            #endregion

            #region Ex02 - Using Try-Catch.

            //DummyCode02();

            /*
                 * In This Case If Any Of Lines Inside Try block Caused Exception The CLR Will Stop The Execution of rest lines inside try block 
                 * And make object from caused exception and i hold it in reference of type Exception in Catch parameter, and view friendly message, after this if Main() has any code after calling of DummyCode() it will be executed
                 * Mean That If I Have Any Thing After This Calling Of Function "DummyCode01()" in Main(), it will  executed.
             */

            //Console.WriteLine("Code After DummyCode() Will Executed Regardless there is exception inside try block or not!");

            #endregion

            #region Exeptions Types =>

            //There Are Two Classes Inherit From Exception Class => 

            /*
                 * 1- SystemException -> For Software/Coding Exceptions 
                    * 1.1- FormatException
                    * 1.2- OutOfRangeException
                    * 1.3- NullReferenceException
                    * 1.4- InvalidOperationException
                    * 1.5- ArithmeticException
                        * 1.5.1- DivideByZeroException
                        * 1.5.2- OverFlowException
                 * 2- ApplicationException -> For Hardware Exceptions (RAM,CPU,...).  
            */

            #endregion

            #region Ex03 - Write DummyCode() In Protective way - not use try-catch because i expected the exception that will occured

            //DummyCodeProtective();

            #region try - catch - finally

            //We use finally to deallocate unmanaged resources like (close open connection of DB - close the file that we open or modify in it in PC).
            //Finally block will executed regardless there are exception or not.

            #region Finally block executed although it's no exceptions

            //try
            //{
            //    DummyCodeProtective();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");//Finally block
            //}

            #endregion 

            #region Finally block executed although exceptions

            //try
            //{
            //    DummyCodeProtective();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);//Exception of type 'System.Exception' was thrown.
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block");//Finally block
            //}

            #endregion

            #endregion

            #endregion

            #endregion

        }
    }
}
