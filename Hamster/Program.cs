using System;

namespace Hamster
{
    class Animal
    {
        public string name;
        public int age = 0;
        public double weight;
        public int lifeSpan = 0;

        public void AnimalInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight}");
            

        }

        public void Eat()
        {
            
            weight += 0.2;
        }
        public void Run()
        {
            weight -=  0.1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal hamster = new Animal();
            hamster.name = "Piuks";
            hamster.weight = 0.1;

          

            for (int i = 0; i < 10; i++)
            {
                hamster.age++;
                hamster.Eat();

                while (hamster.weight > 0.7)
                {
                    hamster.Run();

                    if (hamster.weight == 0.7)
                    {
                        break;
                    }
                    
                }
            }

            if (hamster.age == 10)
            {
                Console.WriteLine("I'm sorry, we can't help it");
            }

           
            hamster.AnimalInfo();
        }
    }
}
