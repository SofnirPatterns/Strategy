using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.MovieApp
{
    class DisplayList : IDisplayMode
    {
        public void Display(List<Video> videos)
        {
            Console.WriteLine("List of videos: ");
            foreach (Video video in videos)
            {
                Console.WriteLine($"- {video.Name}");
            }
        }
    }   
}
