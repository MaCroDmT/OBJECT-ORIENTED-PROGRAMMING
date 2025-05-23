using CC;
using System;




namespace CC
{
    class Animal
    {
        public virtual void acry()
        {
            Console.WriteLine("Animal Cry");
        }
    }
}
 
 

using System;
using CC;

 

namespace OOP2BLAB
{
    class Cat : CC.Animal
    {

        public override void acry()
        {
            Console.WriteLine("Meow");
        }




    }
}
 
 

using System;
using CC;

 

namespace OOP2BLAB
{
    class Dog : Animal
    {
        public override void acry()
        {
            Console.WriteLine("Ghew");
        }
    }
}
 
 

using System;
using CC;

 


namespace OOP2BLAB
{
    class Program
    {

        static void Main(string[] args)
        {
            Animal A = new Animal();
            Animal B = new Cat();
            Animal C = new Dog();



            A.acry();
            B.acry();
            C.acry();
            Console.ReadLine();

        }
    }
}