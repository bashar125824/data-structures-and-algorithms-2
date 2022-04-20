using System;
using Xunit;
using Shelter;

namespace stack_queue_animal_shelter
{
    public class UnitTest1
    {
        [Fact]
        public void Test1_Enqueue_Cat()
        {

            Shelter.stack_queue_animal_shelter S = new Shelter.stack_queue_animal_shelter();
            Shelter.Cat c = new Cat();

            S.Enqueue(c);
            Assert.True(S.c.Dequeue() is Cat);

        }

        [Fact]
        public void Test2_Dequeue_Cat()
        {

            Shelter.stack_queue_animal_shelter S = new Shelter.stack_queue_animal_shelter();
            Shelter.Cat c1 = new Cat();
            Shelter.Cat c2 = new Cat();


            S.Enqueue(c1);
            S.Dequeue("Cat");
            S.Enqueue(c2);
            Assert.NotNull(S);

        }

        [Fact]
        public void Test3_Enqueue_Dog()
        {

            Shelter.stack_queue_animal_shelter S = new Shelter.stack_queue_animal_shelter();
            Shelter.Dog d = new Dog();

            S.Enqueue(d);
            Assert.True(S.d.Dequeue() is Dog);

        }

        [Fact]
        public void Test4_Dequeue_Dog()
        {

            Shelter.stack_queue_animal_shelter S = new Shelter.stack_queue_animal_shelter();
            Shelter.Dog d1 = new Dog();
            Shelter.Dog d2 = new Dog();


            S.Enqueue(d1);
            S.Dequeue("Dog");
            S.Enqueue(d2);
            Assert.NotNull(S);

        }



        [Fact]
        public void Test5_Dequeue_Null()
        {
            Shelter.stack_queue_animal_shelter S = new Shelter.stack_queue_animal_shelter();
            Shelter.Cat c = new Cat();
            Assert.Null(S.Dequeue("Tiger"));
        }
    }
}
