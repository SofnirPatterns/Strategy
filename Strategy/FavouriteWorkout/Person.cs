using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Person
    {
        public string Name { get; set; }
        public Enums.FavouriteWorkout FavouriteWorkout { get; set; }

        public Person(string name, Enums.FavouriteWorkout favouriteWorkout)
        {
            Name = name;
            FavouriteWorkout = favouriteWorkout;
        }

        public void Workout()
        {
            Console.WriteLine($"{Name} decided to: ");

            if(FavouriteWorkout == Enums.FavouriteWorkout.Gym)
            {
                Console.WriteLine("Go to the gym.");
            }
            else if(FavouriteWorkout == Enums.FavouriteWorkout.Running)
            {
                Console.WriteLine("Go running on the park.");
            }
            else if(FavouriteWorkout == Enums.FavouriteWorkout.Soccer)
            {
                Console.WriteLine("Play soccer with friends.");
            }
        }
    }
}
