using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.MovieApp
{
    interface IDisplayMode
    {
        void Display(List<Video> videos);
    }
}
