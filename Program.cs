﻿namespace LambdaExpression
{
    public class Program
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Wellcome to Lambda Expression Problem");

            //UC1
            //Console.WriteLine("Please Enter First Name");
            //string pattern = Console.ReadLine();
            //Patterns patterns = new Patterns();
            //bool val = patterns.validateFirstName(pattern);
            //if (val)
            //    Console.WriteLine("Pattern Matched");
            //else
            //    Console.WriteLine("Pattern Not Matched");


            //UserRegistration user = new UserRegistration();
            //Console.WriteLine("**********User Registration****************");
            //Console.WriteLine("Enter Firstname");
            //string Firstname = Console.ReadLine();
            //string opt = user.FirstnameCheckusingLambda(Firstname);
            //if (opt == "FirstName is Valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}


            UserRegistration user = new UserRegistration();
            //Console.WriteLine("**********User Registration****************");
            //Console.WriteLine("Enter Firstname");
            //string Firstname = Console.ReadLine();
            //string opt = user.FirstnameCheckusingLambda(Firstname);
            //if (opt == "FirstName is Valid")
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine(opt);
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(opt);
            //    Console.ResetColor();

            //}






            //Console.WriteLine("Enter Lastname");
            //string LastName = Console.ReadLine();
            //string opt = user.validateLastNameusingLambda(LastName);
            //if (opt == "Valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}

            //Console.WriteLine("Enter Email");
            //string Email = Console.ReadLine();
            //string opt = user.validateEmailusingLambda(Email);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}

            //Console.WriteLine("Enter Mobile Number");
            //string mobile = Console.ReadLine();
            //string opt = user.validateMobileNumberusingLambda(mobile);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}


            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();
            //string opt = user.validatePasswordusingLambda(password);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}

            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();
            //string opt = user.validatePassword6usingLambda(password);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}

            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();
            //string opt = user.validatePassword7usingLambda(password);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}

            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();
            //string opt = user.validatePassword8usinglambda(password);
            //if (opt == "valid")
            //{
            //    Console.WriteLine("Pattern is matched");
            //}
            //else
            //{
            //    Console.WriteLine("Pattern is not matched");
            //}


            Console.WriteLine("Enter Email");
            string Email = Console.ReadLine();
            string opt = user.validateEmail9usingLambda(Email);
            if (opt == "valid")
            {
                Console.WriteLine("Pattern is matched");
            }
            else
            {
                Console.WriteLine("Pattern is not matched");
            }
           
        }
    }
}
