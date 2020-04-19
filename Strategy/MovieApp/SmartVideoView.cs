using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.MovieApp
{
    class SmartVideoView
    {
        public List<Video> Videos { get; set; }

        public IDisplayMode DisplayMode { get; set; }

        public SmartVideoView(List<Video> videos, IDisplayMode displayMode)
        {
            Videos = videos;
            DisplayMode = displayMode;
        }

        public void Display()
        {
            DisplayMode.Display(Videos);
            Console.WriteLine();
        }
    }
}
