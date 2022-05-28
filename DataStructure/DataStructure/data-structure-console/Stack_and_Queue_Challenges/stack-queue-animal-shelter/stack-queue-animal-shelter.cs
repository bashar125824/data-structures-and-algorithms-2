using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelter
{

    public class Animal{}

    public class Cat : Animal { }

    public class Dog : Animal { }

    public class stack_queue_animal_shelter
    {

        
        public Queue<Dog> d = new Queue<Dog>();
        public Queue<Cat> c = new Queue<Cat>();

        public void Enqueue(Animal a)
        {

            if (a is Cat)
            {
                Cat cat = new Cat();
                c.Enqueue(cat);
            }
            else if (a is Dog)
            {
                Dog dog = new Dog();
                d.Enqueue(dog);
            }
        }

        public Animal Dequeue(string pref)
        {
            if (pref == "Cat")
            {
                return c.Dequeue();

            }
            else if (pref == "Dog")
            {
                return d.Dequeue();
            }
            return null;
        }


    }
}
