namespace IsErrorCode_MicrosoftLearning
{
    using IsErrorCode_MicrosoftLearning.Interfaces;
    using System;

    public class Program
    {
        public static IErrorCheckable ErrorCheck { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Use refactored version (otherwise old one)? (y/n)");
            var res = Console.ReadLine();

            if(res.ToLower() == "y")
            {
                ErrorCheck = new ErrorCheckRefactored();
            }
            else
            {
                ErrorCheck = new ErrorCheck();
            }

            while (true)
            {
                Console.WriteLine("What number do you want to try?");

                try
                {
                    var errorCode = Convert.ToInt32(Console.ReadLine());
                    var returnedCodeAccepted = ErrorCheck.IsErrorCode(errorCode);
                    Console.WriteLine(string.Format("IsErrorCode: {0}", returnedCodeAccepted ? "YES" : "NO"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Here an ugly error msg: {0}", ex.Message));
                }
            }
        }
    }
}
