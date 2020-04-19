using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class SmartPerson
    {
        public string Name { get; set; }
        public IFavouriteWorkout FavouriteWorkout { get; set; }

        public SmartPerson(string name, IFavouriteWorkout favouriteWorkout)
        {
            Name = name;
            FavouriteWorkout = favouriteWorkout;
        }

        public void Workout()
        {
            Console.WriteLine($"{Name} decided to: ");

            FavouriteWorkout.Workout();
        }
    }
}
