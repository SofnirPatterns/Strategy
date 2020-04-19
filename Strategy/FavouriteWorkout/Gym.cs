using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Gym : IFavouriteWorkout
    {
        public void Workout()
        {
            Console.WriteLine("Go to the gym.");
        }
    }
}
