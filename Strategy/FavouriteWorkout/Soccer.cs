using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Soccer : IFavouriteWorkout
    {
        public void Workout()
        {
            Console.WriteLine("Play soccer with friends.");
        }
    }
}
