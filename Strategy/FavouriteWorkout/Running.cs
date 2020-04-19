using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Running : IFavouriteWorkout
    {
        public void Workout()
        {
            Console.WriteLine("Go running on the park.");
        }
    }
}
