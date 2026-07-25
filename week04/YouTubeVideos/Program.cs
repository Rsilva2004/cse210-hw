using System;

class Program
{
    static void Main(string[] args)
    {
        // VIDEO 1
        Video video1 = new Video();
        video1._title = "How to Make Pasta";
        video1._author = "Erick Jacquin";
        video1._length = 300;

        Comment comment1 = new Comment();
        comment1._name = "Alice";
        comment1._comment = "Wow, it looks delicious!";

        Comment comment2 = new Comment();
        comment2._name = "Bob";
        comment2._comment = "I'll try this recipe today.";

        Comment comment3 = new Comment();
        comment3._name = "Charlie";
        comment3._comment = "Thanks for the tips! It looks great :)";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);


        // VIDEO 2
        Video video2 = new Video();
        video2._title = "Is GTA VI a Great Game?";
        video2._author = "The Professional";
        video2._length = 470;

        Comment comment4 = new Comment();
        comment4._name = "Franklin";
        comment4._comment = "I'm excited to play it!";

        Comment comment5 = new Comment();
        comment5._name = "Michael";
        comment5._comment = "The graphics look amazing.";

        Comment comment6 = new Comment();
        comment6._name = "Trevor";
        comment6._comment = "Wooow, Can't wait for that!";

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);


        // VIDEO 3
        Video video3 = new Video();
        video3._title = "Playing Pokémon Songs on Piano";
        video3._author = "PianoMan";
        video3._length = 250;

        Comment comment7 = new Comment();
        comment7._name = "Peter";
        comment7._comment = "Amazing performance!";

        Comment comment8 = new Comment();
        comment8._name = "Sophia";
        comment8._comment = "I love Pokémon music.";

        Comment comment9 = new Comment();
        comment9._name = "Daniel";
        comment9._comment = "Please make more videos!";

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);


        // LIST OF VIDEOS
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        // DISPLAY VIDEOS
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._comment}");
            }

            Console.WriteLine();
        }
    }
}