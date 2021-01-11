using System;

namespace Patterns._3._Behavioral._9._Template_Method
{
    public class Client
    {
        public static void Main()
        {
            var A = new A();
            A.TemplateMethod();
            
            Console.WriteLine();
            
            var B = new B();
            B.TemplateMethod();
        }
    }
}