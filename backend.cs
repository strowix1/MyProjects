using System;

namespace Logowanie
{
    class Program
    {
        //USER
        public static string Login_User = "Strowix";
        public static string Password_User = "FNowak123";
        public static int PIN_User = 5342;
        //ADMIN
        public static string Login_Admin = "Boesner";
        public static string Password_Admin = "Boesner123";
        public static int PIN_Admin = 4750;
        //ZAPYTANIA
        public static int PodajPin;
        public static string Password;
        public static string Login;
        //DO PETLI
        public static int i;

        //PETLA GLOWNA
        static void Main(string[] args)
        {

            //try
            //{
                Console.WriteLine("Podaj PIN uzytkownika: ");
                PodajPin = int.Parse(Console.ReadLine());
                Console.Clear();
           // }
           // catch
           // {
          //      C
          //  }
            if (PodajPin == PIN_Admin)
            {
                Admin_Log(PodajPin);
            }
            else if (PodajPin == PIN_User)
            {
                User_Log(PodajPin);
            }
        }

        
        //Funkcja logowania admina
        static void Admin_Log(int PodajPin)
        {
            if (PodajPin == PIN_Admin)
            {

                //Funkcje i pętle do loginu
                Console.WriteLine("Podaj Login: ");
                Login = Console.ReadLine();
                Console.Clear();
                i = 4;
                while (Login != Login_Admin)
                {
                    i--;
                    Console.Clear();
                    if (i == 2 || i == 3)
                    {
                        Console.WriteLine($"                                    Zostały {i} próby");
                        Console.WriteLine($"Spróbuj ponownie\nLogin: ");
                        Login = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine($"                                    Została {i} próba");
                        Console.WriteLine("Spróbuj ponownie\nLogin: ");
                        Login = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (i == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Zbyt wiele nieudanych prób");
                        break;
                    }
                }
            }
            //Funkcje i pentle do hasła
            Console.WriteLine("Podaj haslo: ");
            Console.Clear();
            i = 4;
            while (Password != Password_Admin)
            {
                i--;
                Console.Clear();
                if (i == 2 || i == 3)
                {
                    Console.WriteLine($"                                    Zostały {i} próby");
                    Console.WriteLine("Spróbuj ponownie\nHasło: ");

                    Password = Console.ReadLine();
                    Console.Clear();
                }
                else if (i == 1)
                {
                    Console.WriteLine($"                                   Została {i} próba");
                    Console.WriteLine("Spróbuj ponownie\nHasło: ");
                    Password = Console.ReadLine();
                    Console.Clear();
                }
                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Zbyt wiele nieudanych prób");
                    break;
                }
            }
            if (Password == Password_Admin)
            {
                Console.WriteLine("Uzyskano dostep");
            }
        }


        //Funkcja logowania usera
        static void User_Log(int PodajPin)
        {
            if (PodajPin == PIN_User)
            {

                //Funkcje i pętle do loginu
                Console.WriteLine("Podaj Login: ");
                Login = Console.ReadLine();
                Console.Clear();
                i = 4;
                while (Login != Login_User)
                {
                    i--;
                    Console.Clear();
                    if (i == 2 || i == 3)
                    {
                        Console.WriteLine($"                                    Zostały {i} próby");
                        Console.WriteLine($"Spróbuj ponownie\nLogin: ");
                        Login = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (i == 1)
                    {
                        Console.WriteLine($"                                    Została {i} próba");
                        Console.WriteLine("Spróbuj ponownie\nLogin: ");
                        Login = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (i == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Zbyt wiele nieudanych prób");
                        break;
                    }
                }
            }
            //Funkcje i pentle do hasła
            Console.WriteLine("Podaj haslo: ");
            Console.Clear();
            i = 4;
            while (Password != Password_User)
            {
                i--;
                Console.Clear();
                if (i == 2 || i == 3)
                {
                    Console.WriteLine($"                                    Zostały {i} próby");
                    Console.WriteLine("Spróbuj ponownie\nHasło: ");

                    Password = Console.ReadLine();
                    Console.Clear();
                }
                else if (i == 1)
                {
                    Console.WriteLine($"                                   Została {i} próba");
                    Console.WriteLine("Spróbuj ponownie\nHasło: ");
                    Password = Console.ReadLine();
                    Console.Clear();
                }
                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Zbyt wiele nieudanych prób");
                    break;
                }
            }
            if (Password == Password_User)
            {
                Console.WriteLine("Brak dostępu");
            }
        }
        //Petla jezeli PodajPin nie zgadza sie z zadnym zapisanym w systemie
        static void BrakDanych()
        { 
            i = 4;
            while (PodajPin != PIN_Admin && PodajPin != PIN_User)
            {
                i--;
                Console.Clear();
                if (i == 3 || i == 2)
                {
                    Console.WriteLine($"                                    Zostały {i} próby");
                    Console.WriteLine("Spróbuj ponownie\nPIN: ");
                    PodajPin = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else if (i == 1)
                {
                    Console.WriteLine($"                                    Została {i} próba");
                    Console.WriteLine("Spróbuj ponownie\nPIN: ");
                    PodajPin = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Zbyt wiele nieudanych prób");
                    break;
                }
            }
            if (PodajPin == PIN_Admin)
            {
                Admin_Log(PodajPin);
            }
            else if (PodajPin == PIN_User)
            {
                User_Log(PodajPin);
            }
                
        }
        
    }
}