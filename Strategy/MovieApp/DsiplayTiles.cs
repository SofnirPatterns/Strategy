using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.MovieApp
{
    class DsiplayTiles : IDisplayMode
    {
        public void Display(List<Video> videos)
        {
            Console.WriteLine("Videos tiles: ");
            foreach (Video video in videos)
            {
                Console.Write($"{video.Name} | ");
            }
        }
    }
}
