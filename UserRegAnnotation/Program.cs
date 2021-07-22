using System;

namespace UserRegAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ValidateUserDetails vud = new ValidateUserDetails();
            vud.ValidateUser();
        }
    }
}
