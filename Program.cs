using System;

namespace AttributeAndReflections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.PropertyType);
                var attrs = prop.GetCustomAttributes(false);
                foreach (var a in attrs)
                {
                    Console.WriteLine(a);
                }
            }
            
            Console.ReadLine();
        }
    }
}