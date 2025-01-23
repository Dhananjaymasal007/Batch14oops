using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch14oops
{
    //Abstract Class
    public abstract class Animal1
    {
        public int a, b;

        // Abstract Method (No implementation)

        public abstract void MakingSound();

        //non abstract method(that has implemantation)

        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }


    //derived class 

    public class Dog1 : Animal1
    {
        public override void MakingSound()
        {
            Console.WriteLine("Dog Barks");
        }

    }

    public class Cat1 : Animal1
    {
        //implementation of abstract method
        public override void MakingSound()
        {
            Console.WriteLine("Cat  is  Meows");
        }

    }

    internal class Abstractcls
    {
        static void Main()
        {

            //Animal1  animal = new Animal1();
            //crating objects for derived classess
            Dog1 dog = new Dog1();
            Cat1 cat = new Cat1();


            //call method
            dog.MakingSound();
            dog.Eat();

            cat.MakingSound();
            cat.Eat();

        }


    }
}
