using System;

namespace UserRegAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //object creation for class
            ValidateUserDetails vud = new ValidateUserDetails();
            vud.ValidateUser();
        }
    }
}
