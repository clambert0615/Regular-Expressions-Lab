using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAsking = true;
            while (keepAsking)
            {
                Console.WriteLine("Enter a name");
                string userName = Console.ReadLine();
                if (IsValidName(userName) == true)
                {
                    Console.WriteLine(userName);
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");

                }
            }
            keepAsking = true;
            while (keepAsking)
            {
                Console.WriteLine("Enter an email");
                string userEmail = Console.ReadLine();
                if (IsValidEmail(userEmail) == true)
                {
                    Console.WriteLine(userEmail);
                    keepAsking = false;
                }
                else
                {
                    Console.WriteLine("Invalid email. Try again.");


                }
            }
            keepAsking = true;
                while (keepAsking)
                {
                    Console.WriteLine("Enter a phone number in format xxx-xxx-xxxx");
                    string userPhone = Console.ReadLine();
                    if (IsValidPhoneNumber(userPhone) == true)
                    {
                        Console.WriteLine(userPhone);
                        keepAsking = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid phone number. Try again.");

                    }
                }
            keepAsking = true;
                while (keepAsking)
                {
                    Console.WriteLine("Enter a date in format dd/mm/yyyy");
                    string userDate = Console.ReadLine();
                    if (IsValidDate(userDate) == true)
                    {
                        Console.WriteLine(userDate);
                        keepAsking = false;
                    }
                    else

                    {
                        Console.WriteLine("Invalid date. Try again.");

                    }
                }


            }

            public static bool IsValidName(string name)
            {

                bool isName = Regex.IsMatch(name, "^[A-Z][a-z]{0,29}$");
                return isName;

            }
            public static bool IsValidEmail(string email)
            {
                bool isEmail = Regex.IsMatch(email, @"^[A-Za-z0-9]{5,30}\@[A-Za-z0-9]{5,10}\.[A-Za-z0-9]{2,3}$");
                return isEmail;
            }
            public static bool IsValidPhoneNumber(string phoneNumber)
            {
                bool isPhoneNumber = Regex.IsMatch(phoneNumber, @"^[0-9]{3}\-[0-9]{3}\-[0-9]{4}$");
                return isPhoneNumber;
            }
            public static bool IsValidDate(string date)
            {
                bool isDate = Regex.IsMatch(date, @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$");
                return isDate;
            }



        }
    }
