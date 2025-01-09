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

        }
    }
}
