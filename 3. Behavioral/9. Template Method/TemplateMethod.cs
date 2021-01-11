using System;

namespace Patterns._3._Behavioral._9._Template_Method
{
    public abstract class BaseClass
    {
        public void TemplateMethod()
        {
            Console.Write("1");
            difference();
            Console.Write("3");
        }

        public abstract void difference();
    }

    public class A : BaseClass
    {
        public override void difference()
        {
            Console.Write("4");
        }
    }
    
    public class B : BaseClass
    {
        public override void difference()
        {
            Console.Write("2");
        }
    }
        
}