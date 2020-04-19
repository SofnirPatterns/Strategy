using Strategy.MovieApp;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFavouriteWorkout();

            Console.WriteLine("\n----------\n");

            RunVideoApp();
        }
        static void RunFavouriteWorkout()
        {
            Console.WriteLine("Favourite workout\n");

            Person josh = new Person("Josh", Enums.FavouriteWorkout.Gym);
            josh.Workout();
            SmartPerson smartJosh = new SmartPerson("Smart Josh", new Soccer());
            smartJosh.Workout();
        }
        static void RunVideoApp()
        {
            Console.WriteLine("VideoApp\n");
            List<Video> videos = new List<Video>()
            {
                new Video("Harry Portier"),
                new Video("Denver kumpel sprzed 6 tys. lat"),
                new Video("Generał Daimos pracuje zdalnie w robocie"),
            };

            Console.WriteLine("VideView");
            VideoView videoView = new VideoView(videos, Enums.DisplayMode.List);
            videoView.Display();
            videoView.DisplayMode = Enums.DisplayMode.Tiles;
            videoView.Display();

            Console.WriteLine();

            Console.WriteLine("Smart VideoView");
            SmartVideoView smartVideo = new SmartVideoView(videos, new DisplayList());
            smartVideo.Display();
            smartVideo.DisplayMode = new DsiplayTiles();
            smartVideo.Display();

            Console.ReadKey();
        }
    }
}
