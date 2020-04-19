using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.MovieApp
{
    class VideoView
    {
        public List<Video> Videos { get; set; }

        public Enums.DisplayMode DisplayMode { get; set; }

        public VideoView(List<Video> videos, Enums.DisplayMode displayMode)
        {
            Videos = videos;
            DisplayMode = displayMode;
        }

        public void Display()
        {
            if(DisplayMode == Enums.DisplayMode.List)
            {
                Console.WriteLine("List of videos: ");
                foreach(Video video in Videos)
                {
                    Console.WriteLine($"- {video.Name}");
                }
            }
            else if (DisplayMode == Enums.DisplayMode.Tiles)
            {
                Console.WriteLine("Videos tiles: ");
                foreach (Video video in Videos)
                {
                    Console.Write($"{video.Name} | ");
                }
            }

            Console.WriteLine();
        }
    }
}
